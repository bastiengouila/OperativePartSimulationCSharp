using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ER4_SimuPontRoulant;

namespace prjt
{
    public partial class CInterface : Form
    {
        private PontRoulant mPontRoulant;
        private bool bGauche = false;
        private bool bDroite = false;
        private bool bHaut = false;
        private bool bBas = false;
        private bool bDepartCycle = false;
        private bool bReset = false;
        private bool bModeManu = false;
        private bool bModeAuto = false;
        private bool bAucunMode = false;
        private bool bArretUrgence = false;
        private string[] tabstrMonitor = new string[10];
        private String sOldRadioButton = "Aucun_mode";

        public CInterface(PontRoulant Pont)
        {
            InitializeComponent();
            foreach (Control ctr in this.panel1.Controls)
                ctr.Enabled = (ctr.Name != "ArretUrgence") ? this.bArretUrgence : !this.bArretUrgence;
            AffichageMonitor(tabstrMonitor);
            this.mPontRoulant = Pont;
        }

        private void On_Click_Radio_Button(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                if (this.sOldRadioButton != "Aucun_mode")
                    this.mPontRoulant.EcritureAPI(this.sOldRadioButton, false);
                if (((RadioButton)sender).Name != "Aucun_mode")
                    this.mPontRoulant.EcritureAPI(((RadioButton)sender).Name, true);
                this.sOldRadioButton = ((RadioButton)sender).Name;
                switch (((RadioButton)sender).Name)
                {
                    case "ModeManu":
                        this.Gauche.Enabled = true;
                        this.Droite.Enabled = true;
                        this.Haut.Enabled = true;
                        this.Bas.Enabled = true;
                        this.Reset.Enabled = true;
                        this.DepartCycle.Enabled = false;

                        this.bModeManu = true;
                        this.bModeAuto = false;
                        this.bAucunMode = false;
                        break;

                    case "ModeAuto":
                        this.Gauche.Enabled = false;
                        this.Droite.Enabled = false;
                        this.Haut.Enabled = false;
                        this.Bas.Enabled = false;
                        this.DepartCycle.Enabled = true;
                        this.Reset.Enabled = true;

                        this.bModeManu = false;
                        this.bModeAuto = true;
                        this.bAucunMode = false;
                        break;

                    case "Aucun_mode":
                        this.Gauche.Enabled = false;
                        this.Droite.Enabled = false;
                        this.Haut.Enabled = false;
                        this.Bas.Enabled = false;
                        this.DepartCycle.Enabled = false;
                        this.Reset.Enabled = false;

                        this.bModeManu = false;
                        this.bModeAuto = false;
                        this.bAucunMode = true;
                        break;
                }
                AffichageMonitor(tabstrMonitor);
            }
        }

        private void OnClick_ArretUrgence(object sender, EventArgs e)
        {
            this.bArretUrgence = !this.bArretUrgence;
            foreach (Control ctr in this.panel1.Controls)
                if (ctr.Name != ((Button)sender).Name)
                    ctr.Enabled = this.bArretUrgence;
            AffichageMonitor(tabstrMonitor);this.mPontRoulant.EcritureAPI(((Button)sender).Name, this.bArretUrgence);
        }

        private void Mouse_Down(object sender, MouseEventArgs e)
        {
                switch(((Button)sender).Name){
                    case "DepartCycle" :
                    bDepartCycle = true;
                    break;
                    case "Reset":
                    bReset = true;
                    break;
                    case "Droite":
                    bDroite = true;
                    break;
                    case "Gauche":
                    bGauche = true;
                    break;
                    case "Bas":
                    bBas = true;
                    break;
                    case "Haut":
                    bHaut = true;
                    break;
                }
                AffichageMonitor(tabstrMonitor);this.mPontRoulant.EcritureAPI(((Button)sender).Name, true);
        }
        private void Mouse_Up(object sender, MouseEventArgs e)
        {
                switch (((Button)sender).Name)
                {
                    case "DepartCycle":
                        bDepartCycle = false;
                        break;
                    case "Reset":
                        bReset = false;
                        break;
                    case "Droite":
                        bDroite = false;
                        break;
                    case "Gauche":
                        bGauche = false;
                        break;
                    case "Bas":
                        bBas = false;
                        break;
                    case "Haut":
                        bHaut = false;
                        break;
                }
                AffichageMonitor(tabstrMonitor);this.mPontRoulant.EcritureAPI(((Button)sender).Name, false);
        }

        private void AffichageMonitor(string[] tabstrAffichage)
        {
            int iBcl = 0;
            Monitor.Clear();
            tabstrMonitor[0] = "bGauche = " + Convert.ToString(bGauche);
            tabstrMonitor[1] = "bDroite = " + Convert.ToString(bDroite);
            tabstrMonitor[2] = "bBas = " + Convert.ToString(bBas);
            tabstrMonitor[3] = "bHaut = " + Convert.ToString(bHaut);
            tabstrMonitor[4] = "bDepartCycle = " + Convert.ToString(bDepartCycle);
            tabstrMonitor[5] = "bReset = " + Convert.ToString(bReset);
            tabstrMonitor[6] = "bArretUrgence = " + Convert.ToString(bArretUrgence);
            tabstrMonitor[7] = "bModeManu = " + Convert.ToString(bModeManu);
            tabstrMonitor[8] = "bModeAuto = " + Convert.ToString(bModeAuto);
            tabstrMonitor[9] = "bAucunMode = " + Convert.ToString(bAucunMode);
            for (iBcl = 0; iBcl <10 ;iBcl++ )
            {
                Monitor.Text += tabstrMonitor[iBcl] + "\r\n";
            }
        }

    }
}
