using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using prjt;
using System.Threading;

/*CuveE(70;90) Cuve1(140;160) Cuve2(215;235) Cuve3(295;315) CuveS(370;390)
 * 
 * Données :    qebCuveEVoyantVert, qebCuve3VoyantVert, qebCuve2VoyantVert, qebCuve1VoyantVert
 *              qebPontMonter, qebPontDescendre, qebPontDeplacerGauche, qebPontDeplacerDroite
*/

namespace ER4_SimuPontRoulant
{
    
    enum TDir { STOP = 0, LEFT, RIGHT };
    public partial class PontRoulant : Form
    {
        private CInterface mInterface;
        private CCommunication mCommunication;
        private int ixPosChariot;
        private System.Windows.Forms.Timer timer;
        private TDir Dir = TDir.STOP;
        private int iOffSetPince = 0;
        private Dictionary<String, bool> EtatVariables;
        private Dictionary<String, String> MethodVar;
        private String sDirectoryStu = "";

        private bool bMonterPont = false;
        private bool bDescendrePont = false;
        private bool bDplPontGauche = false;
        private bool bDplPontDroite = false;
        private bool bPinceHaute = false;
        private bool bPinceBasse = false;

        private bool bPinceBasseOld = true;
        private bool bPinceHauteOld = true;
        private bool bCuveEOld = false;
        private bool bCuveSOld = true;
        private bool bCuve1Old = true;
        private bool bCuve2Old = true;
        private bool bCuve3Old = true;

        public PontRoulant()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.mInterface = new CInterface(this);
            this.mInterface.Enabled = false;

            foreach (Control ctr in this.Gb_SelAutomate.Controls)
                if (ctr is Button)
                    ((Button)ctr).Click += new EventHandler(OnClickChoix);

            InitChariot();
            InitDictionary();

            this.timer = new System.Windows.Forms.Timer();
            this.timer.Interval = 80;
            this.timer.Tick += new EventHandler(timer_Tick);
            this.timer.Start();

        }

        private void InitChariot()
        {
            this.BoxChariot.Location = new Point(70, this.BoxChariot.Location.Y);
            this.ixPosChariot = this.BoxChariot.Location.X;

            this.BoxRoueD.Parent = this.BoxChariot;
            this.BoxRoueG.Parent = this.BoxChariot;
            this.BoxPince.Parent = this.BoxPont;         //Parent pince

            this.BoxPince.BackColor = Color.Transparent;
            this.BoxRoueD.BackColor = Color.Transparent;
            this.BoxRoueG.BackColor = Color.Transparent;

            this.BoxRoueG.Location = new Point(10, 65);
            this.BoxRoueD.Location = new Point(95, 65);
            this.BoxPince.Location = new Point(this.BoxChariot.Location.X, this.BoxChariot.Location.Y + this.BoxChariot.Height / 2);
        }
        private void InitInterface()
        {
            this.mInterface.Enabled = true;
            this.mInterface.MdiParent = this;
            this.mInterface.Show();
            this.mInterface.Location = new Point(10, this.PanelPont.Location.Y + this.PanelPont.Height);
        }

        public void timer_Tick(object sender, EventArgs e)
        {
            if (!this.mInterface.Enabled)
                InitInterface();

            if (this.mCommunication != null)
                MAJEntrees();
            if (this.bMonterPont ^ this.bDescendrePont)
            {
                if (this.bMonterPont && this.iOffSetPince > 0)
                    this.iOffSetPince -= 2;
                else if (this.bDescendrePont && this.iOffSetPince < 50)
                    this.iOffSetPince += 2;
            }
            this.Dir = (this.bDplPontDroite) ? TDir.RIGHT : (this.bDplPontGauche) ? TDir.LEFT : TDir.STOP;
            DeplaceChariot(this.Dir);
            AfficheChariot(this.ixPosChariot, this.iOffSetPince);

            if (this.mCommunication != null)
                MAJSorties();
        }

        private void AfficheChariot(int PosXChariot, int PosPince)
        {
            this.BoxChariot.Location = new Point(PosXChariot, this.BoxChariot.Location.Y);
            this.BoxPince.Location = new Point(this.BoxChariot.Location.X, this.BoxChariot.Location.Y + this.BoxChariot.Height / 2 + PosPince);
        }
        private void DeplaceChariot(TDir dir)
        {
            if ((this.ixPosChariot > 70 || dir == TDir.RIGHT) && (this.ixPosChariot < 390 || dir == TDir.LEFT))
                if (dir != TDir.STOP)
                    this.ixPosChariot += (dir == TDir.LEFT) ? -1 : 1;
        }

        public void OnClickChoix(object sender, EventArgs e)
        {
            if (((Button)sender).Name == this.Bt_Connexion.Name)
            {
                if ((String)this.Cbb_ChoixAutomate.SelectedItem != "Choix automate")
                {
                    this.Lb_EtatCo.Text = "Connexion en cours";
                    this.Bt_Deconnexion.Enabled = true;
                    this.Bt_Connexion.Enabled = !this.Bt_Deconnexion.Enabled;
                    this.Cbb_ChoixAutomate.Enabled = this.Bt_Connexion.Enabled;

                    this.mCommunication = new CCommunication((String)this.Cbb_ChoixAutomate.SelectedItem, this.sDirectoryStu);
                    if (this.mCommunication.Connecte)
                        this.Lb_EtatCo.Text = "Connecté";
                    else
                        this.Lb_EtatCo.Text = "Echec connexion";
                }
            }
            else if (((Button)sender).Name == this.Bt_Deconnexion.Name)
            {
                this.mCommunication.Deconnexion();
                this.Bt_Deconnexion.Enabled = false;
                this.Bt_Connexion.Enabled = !this.Bt_Deconnexion.Enabled;
                this.Cbb_ChoixAutomate.Enabled = this.Bt_Connexion.Enabled;
                this.Lb_EtatCo.Text = "Deconnecté";
                this.mCommunication = null;
                this.mInterface = null;
                this.mInterface = new CInterface(this);
                this.mInterface.Enabled = false;
                this.bPinceBasseOld = !this.bPinceBasseOld;
                this.bPinceHauteOld = !this.bPinceHauteOld;
                this.bCuveEOld = !this.bCuveEOld;
                this.bCuveSOld = !this.bCuveSOld;
                this.bCuve1Old = !this.bCuve1Old;
                this.bCuve2Old = !this.bCuve2Old;
                this.bCuve3Old = !this.bCuve3Old;
            }
        }
        private void MAJEntrees()
        {
            this.EtatVariables = this.mCommunication.Variables;
            this.bDplPontDroite = this.EtatVariables["qebPontDeplacerDroite"];
            this.bDplPontGauche = this.EtatVariables["qebPontDeplacerGauche"];
            this.bMonterPont = this.EtatVariables["qebPontMonter"];
            this.bDescendrePont = this.EtatVariables["qebPontDescendre"];

        }
        private void MAJSorties()
        {
            this.bPinceHaute = (this.iOffSetPince == 0);
            this.bPinceBasse = (this.iOffSetPince == 50);
            this.Cb_1.Checked = (this.ixPosChariot >= 70 && this.ixPosChariot <= 90);
            this.Cb_2.Checked = (this.ixPosChariot >= 140 && this.ixPosChariot <= 160);
            this.Cb_3.Checked = (this.ixPosChariot >= 215 && this.ixPosChariot <= 235);
            this.Cb_4.Checked = (this.ixPosChariot >= 295 && this.ixPosChariot <= 315);
            this.Cb_5.Checked = (this.ixPosChariot >= 370 && this.ixPosChariot <= 390);

            if (this.bPinceHauteOld != this.bPinceHaute)
            {
                EcritureAPI("PinceHaute", this.bPinceHaute);
                this.bPinceHauteOld = this.bPinceHaute;
            }
            if (this.bPinceBasseOld != this.bPinceBasse)
            {
                EcritureAPI("PinceBasse", this.bPinceBasse);
                this.bPinceBasseOld = this.bPinceBasse;
            }
            if (this.bCuveEOld != this.Cb_1.Checked)
            {
                EcritureAPI("PosCuveE", this.Cb_1.Checked);
                this.bCuveEOld = this.Cb_1.Checked;
            }
            if (this.bCuveSOld != this.Cb_5.Checked)
            {
                EcritureAPI("PosCuveS", this.Cb_5.Checked);
                this.bCuveSOld = this.Cb_5.Checked;
            }
            if (this.bCuve1Old != this.Cb_2.Checked)
            {
                EcritureAPI("PosCuve1", this.Cb_2.Checked);
                this.bCuve1Old = this.Cb_2.Checked;
            }
            if (this.bCuve2Old != this.Cb_3.Checked)
            {
                EcritureAPI("PosCuve2", this.Cb_3.Checked);
                this.bCuve2Old = this.Cb_3.Checked;
            }
            if (this.bCuve3Old != this.Cb_4.Checked)
            {
                EcritureAPI("PosCuve3", this.Cb_4.Checked);
                this.bCuve3Old = this.Cb_4.Checked;
            }
        }

        public void EcritureAPI(String Key, bool bVal)
        {
            if (this.mCommunication != null)
                this.mCommunication.EcritureSurAPI(this.MethodVar[Key], bVal);
        }

        private void InitDictionary()
        {
            //<Ditionnary>
            MethodVar = new Dictionary<string, string>();
            MethodVar.Add("DepartCycle", "iebBpPresencePiece");
            MethodVar.Add("Gauche", "iebDeplacementGauchePont");
            MethodVar.Add("Droite", "iebBpDeplacementDroitePont");
            MethodVar.Add("Bas", "iebBpDescendrePont");
            MethodVar.Add("Haut", "iebBpMonterPont");
            MethodVar.Add("Reset", "iebBpCuvesVides");
            MethodVar.Add("ArretUrgence", "iebBpanfArretUrgence");
            MethodVar.Add("ModeAuto", "iebComModeAuto");
            MethodVar.Add("ModeManu", "iebComModeManu");
            MethodVar.Add("PinceHaute", "iebPontPosHaute");
            MethodVar.Add("PinceBasse", "iebPontPosBasse");
            MethodVar.Add("PosCuveE", "iebPontPosCuveE");
            MethodVar.Add("PosCuveS", "iebPontPosCuveS");
            MethodVar.Add("PosCuve1", "iebPontPosCuve1");
            MethodVar.Add("PosCuve2", "iebPontPosCuve2");
            MethodVar.Add("PosCuve3", "iebPontPosCuve3");
            //</Dictionnary>
        }

        private void Bt_SelectDirectory_Click(object sender, EventArgs e)
        {
            this.OFD_Stu.ShowDialog();
            this.sDirectoryStu = this.OFD_Stu.FileName;
            this.sDirectoryStu = "\"" + this.sDirectoryStu.Replace("\\", "\\\\") + "\"";

        }
    }
}
