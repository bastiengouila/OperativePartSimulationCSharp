using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
//Bibliothèque pour la connexion OPC
using SAOFSGRPXLib;

namespace ER4_SimuPontRoulant
{
    enum TEtatConnexion { CONNECTE = 0, CONNEXION_EN_COURS, DECONNECTE };
    public class CCommunication
    {
        public const int NUM_MAX_API = 9;
        public const int NUM_MIN_API = 2;

        /*Attributs pour l OPC*/
        public SAOFSGroupXClass mSAOFSGroupX;
        private TEtatConnexion etatConnexion = TEtatConnexion.DECONNECTE;
        private Timer mTimerConnexion;
        private string sAPI = "";
        private string sDirectoryStu = "";
        private bool bConnecte = false;
        private string[,] sTabVariables;
        private Dictionary<String, bool> DictEtatVariables;


        public CCommunication(String API, String DirStu) {
            foreach (Process p in Process.GetProcessesByName("ofs"))
            {
                p.Kill();
                p.WaitForExit();
            }
            this.sAPI = API;
            this.sDirectoryStu = DirStu;
            InitServeurOPC(this.sDirectoryStu);
            this.DictEtatVariables = new Dictionary<string, bool>();
            try
            {
                this.sTabVariables = GetVarNameAdr(Application.ExecutablePath.Remove(Application.ExecutablePath.LastIndexOf("\\")) + @".\Bin\Variable_Simul.XSY");
                this.bConnecte = InitConnexionOPC(this.sTabVariables);
                InitTimer();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                Deconnexion();
            }

        }

        public String[,] GetVarNameAdr(String dir)
        {
            String[] sTabVarXML;
            int iIndex1 = 0;
            int iIndex2 = 0;
            int iStart = 0;
            int iEnd = 0;
            try
            {
                sTabVarXML = System.IO.File.ReadAllLines(@dir);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                return null;
            }
            for (int i = 0; i < sTabVarXML.Length; i++)
            {
                if (sTabVarXML[i].Contains("<dataBlock>"))
                    iIndex1 = i + 1;
                if (sTabVarXML[i].Contains("</dataBlock>"))
                    iIndex2 = i - 1;
            }

            String[,] sTabVarAuto = new String[iIndex2 - iIndex1, 2];
            for (int i = 0; i < sTabVarAuto.Length / sTabVarAuto.Rank; i++)
            {
                iStart = sTabVarXML[i + iIndex1].IndexOf("name=\"") + 6;
                iEnd = sTabVarXML[i + iIndex1].IndexOf("\"", iStart);
                sTabVarAuto[i, 0] = sTabVarXML[i + iIndex1].Substring(iStart, iEnd - iStart);

                iStart = sTabVarXML[i + iIndex1].IndexOf("topologicalAddress=\"") + 21;
                iEnd = sTabVarXML[i + iIndex1].IndexOf("\"", iStart);
                sTabVarAuto[i, 1] = sTabVarXML[i + iIndex1].Substring(iStart, iEnd - iStart);
            }
            return sTabVarAuto;
        }

        private void InitServeurOPC(String DirStu)
        {
            //Process[] OFS = Process.GetProcessesByName("ofs.exe");
            String sDirExe = Application.ExecutablePath.Remove(Application.ExecutablePath.LastIndexOf("\\"));
            String sDirConfigOPC = sDirExe + @"\Bin\ConfigOPCserveur.reg";
            String[] sTabReg = System.IO.File.ReadAllLines(sDirConfigOPC);
            for (int i = 0; !sTabReg[i].Contains("Comment"); i++)
            {
                if (sTabReg[i].Contains("Symb"))
                {
                    sTabReg[i] = sTabReg[i].Remove(sTabReg[i].IndexOf("="));
                    sTabReg[i] += "=" + DirStu;
                }
            }
            System.IO.File.WriteAllLines(sDirConfigOPC, sTabReg);

            Process pInitServeur = new Process();
            Process pConfigServeur = new Process();
            Process pOfsType = new Process();

            pInitServeur.StartInfo = new ProcessStartInfo("regedit.exe", "/s " + sDirExe + @"\Bin\InitServeurOFS.reg");
            pConfigServeur.StartInfo = new ProcessStartInfo("regedit.exe", "/s " + sDirConfigOPC);
            pOfsType.StartInfo = new ProcessStartInfo("regedit.exe", "/s" + sDirExe + @"\Bin\OfsFileTypes.reg");

            pInitServeur.Start();
            pInitServeur.WaitForExit();
            pConfigServeur.Start();
            pConfigServeur.WaitForExit();
            pOfsType.Start();
            pOfsType.WaitForExit();
           
        }

        private bool InitConnexionOPC(String[,] sTab)
        {
            //Code susceptible de générer une erreur
            try
            {
                this.mSAOFSGroupX = new SAOFSGroupXClass();
                this.mSAOFSGroupX.Init("Schneider-Aut.OFS", "");

                //Ajout de tous les capteurs/Actionneurs
                for (int i = 0; i < sTab.Length / sTab.Rank; i++)
                {
                    this.mSAOFSGroupX.AddItem("", this.sAPI + "!" + sTab[i, 0]);
                    this.DictEtatVariables.Add(sTab[i, 0], /*(sTab[i, 0] == "iebBpanfArretUrgence")*/false);
                }

                //Souscription aux événements
                this.mSAOFSGroupX.OnDataChange += new _ISAOPCGrpXCallback_OnDataChangeEventHandler(mSAOFSGroupX_OnDataChange);
                this.etatConnexion = TEtatConnexion.CONNECTE;
                this.mSAOFSGroupX.Start(50);

                for (int i = 0; i < sTab.Length / sTab.Rank; i++)
                    EcritureSurAPI(sTab[i, 0], this.DictEtatVariables[sTab[i, 0]]);
                return true;
            }
            catch (Exception exception)
            {
                //Affichage du message d'erreur
                System.Windows.Forms.MessageBox.Show(exception.Message);
                return false;
            }
        }
        public void mSAOFSGroupX_OnDataChange()
        {
            try
            {
                //Lecture de tous les actionneurs/Capteurs
                if (etatConnexion == TEtatConnexion.CONNECTE)
                {
                    this.mSAOFSGroupX.Read();
                    for (int i = 0; i < this.sTabVariables.Length / this.sTabVariables.Rank; i++)
                        this.DictEtatVariables[this.sTabVariables[i,0]] = (bool)mSAOFSGroupX.GetValue(this.sAPI + "!" + this.sTabVariables[i,0]);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                //Etat "Déconnecté"
                //etatConnexion = TEtatConnexion.DECONNECTE;
                //Deconnexion();
            }
        }
        public void Deconnexion()
        {
            //Destruction de l'objet groupe OFS
            if (this.mSAOFSGroupX != null)
            {
                this.mSAOFSGroupX.Stop();
                this.mTimerConnexion.Stop();
                this.mSAOFSGroupX = null;
            }
            //Etat "Déconnecté"
            this.etatConnexion = TEtatConnexion.DECONNECTE;
            //AfficherEtatConnexion();
        }

        private void InitTimer()
        {
            //Permet de tester si la connexion est encore valide
            this.mTimerConnexion = new Timer();
            this.mTimerConnexion.Interval = 10000;
            this.mTimerConnexion.Tick += new EventHandler(mTimerConnexion_Tick);
            this.mTimerConnexion.Start();
        }
        private void mTimerConnexion_Tick(object sender, EventArgs e)
        {
            //On regarde si la commande de lecture échoue
            try
            {
                this.mSAOFSGroupX.Read();
            }
            catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show(exception.Message);
                Deconnexion();
            }
        }

        public void EcritureSurAPI(String sVar, bool bEtat)
        {
            if(this.mSAOFSGroupX != null)
                this.mSAOFSGroupX.Write(this.sAPI + "!" + sVar, bEtat);
        }

        public bool Connecte
        {
            get { return this.bConnecte; }
        }
        public Dictionary<String, bool> Variables
        {
            get { return this.DictEtatVariables; }
        }

    }
}
