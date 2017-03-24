namespace ER4_SimuPontRoulant
{
    partial class PontRoulant
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelPont = new System.Windows.Forms.Panel();
            this.Gb_SelAutomate = new System.Windows.Forms.GroupBox();
            this.Lb_EtatCo = new System.Windows.Forms.Label();
            this.Bt_SelectDirectory = new System.Windows.Forms.Button();
            this.Cbb_ChoixAutomate = new System.Windows.Forms.ComboBox();
            this.Bt_Deconnexion = new System.Windows.Forms.Button();
            this.Bt_Connexion = new System.Windows.Forms.Button();
            this.Tb_Var = new System.Windows.Forms.TextBox();
            this.Cb_1 = new System.Windows.Forms.CheckBox();
            this.Cb_2 = new System.Windows.Forms.CheckBox();
            this.Cb_3 = new System.Windows.Forms.CheckBox();
            this.Cb_4 = new System.Windows.Forms.CheckBox();
            this.Cb_5 = new System.Windows.Forms.CheckBox();
            this.BoxRoueG = new System.Windows.Forms.PictureBox();
            this.BoxRoueD = new System.Windows.Forms.PictureBox();
            this.BoxPince = new System.Windows.Forms.PictureBox();
            this.BoxChariot = new System.Windows.Forms.PictureBox();
            this.BoxPont = new System.Windows.Forms.PictureBox();
            this.OFD_Stu = new System.Windows.Forms.OpenFileDialog();
            this.PanelPont.SuspendLayout();
            this.Gb_SelAutomate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxRoueG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxRoueD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxPince)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxChariot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxPont)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPont
            // 
            this.PanelPont.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.PanelPont.Controls.Add(this.Gb_SelAutomate);
            this.PanelPont.Controls.Add(this.Tb_Var);
            this.PanelPont.Controls.Add(this.Cb_1);
            this.PanelPont.Controls.Add(this.Cb_2);
            this.PanelPont.Controls.Add(this.Cb_3);
            this.PanelPont.Controls.Add(this.Cb_4);
            this.PanelPont.Controls.Add(this.Cb_5);
            this.PanelPont.Controls.Add(this.BoxRoueG);
            this.PanelPont.Controls.Add(this.BoxRoueD);
            this.PanelPont.Controls.Add(this.BoxPince);
            this.PanelPont.Controls.Add(this.BoxChariot);
            this.PanelPont.Controls.Add(this.BoxPont);
            this.PanelPont.Location = new System.Drawing.Point(10, 10);
            this.PanelPont.Name = "PanelPont";
            this.PanelPont.Size = new System.Drawing.Size(929, 344);
            this.PanelPont.TabIndex = 1;
            // 
            // Gb_SelAutomate
            // 
            this.Gb_SelAutomate.Controls.Add(this.Lb_EtatCo);
            this.Gb_SelAutomate.Controls.Add(this.Bt_SelectDirectory);
            this.Gb_SelAutomate.Controls.Add(this.Cbb_ChoixAutomate);
            this.Gb_SelAutomate.Controls.Add(this.Bt_Deconnexion);
            this.Gb_SelAutomate.Controls.Add(this.Bt_Connexion);
            this.Gb_SelAutomate.Location = new System.Drawing.Point(567, 3);
            this.Gb_SelAutomate.Name = "Gb_SelAutomate";
            this.Gb_SelAutomate.Size = new System.Drawing.Size(230, 151);
            this.Gb_SelAutomate.TabIndex = 12;
            this.Gb_SelAutomate.TabStop = false;
            this.Gb_SelAutomate.Text = "Sélection automate";
            // 
            // Lb_EtatCo
            // 
            this.Lb_EtatCo.AutoSize = true;
            this.Lb_EtatCo.Location = new System.Drawing.Point(6, 74);
            this.Lb_EtatCo.Name = "Lb_EtatCo";
            this.Lb_EtatCo.Size = new System.Drawing.Size(78, 13);
            this.Lb_EtatCo.TabIndex = 3;
            this.Lb_EtatCo.Text = "Etat connexion";
            // 
            // Bt_SelectDirectory
            // 
            this.Bt_SelectDirectory.Location = new System.Drawing.Point(6, 90);
            this.Bt_SelectDirectory.Name = "Bt_SelectDirectory";
            this.Bt_SelectDirectory.Size = new System.Drawing.Size(89, 23);
            this.Bt_SelectDirectory.TabIndex = 11;
            this.Bt_SelectDirectory.Tag = "0";
            this.Bt_SelectDirectory.Text = "Read";
            this.Bt_SelectDirectory.UseVisualStyleBackColor = true;
            this.Bt_SelectDirectory.Click += new System.EventHandler(this.Bt_SelectDirectory_Click);
            // 
            // Cbb_ChoixAutomate
            // 
            this.Cbb_ChoixAutomate.DisplayMember = "Choix automate";
            this.Cbb_ChoixAutomate.FormattingEnabled = true;
            this.Cbb_ChoixAutomate.Items.AddRange(new object[] {
            "Choix automate",
            "API4_2",
            "API4_3",
            "API4_4",
            "API4_5",
            "API4_6",
            "API4_7",
            "API4_8"});
            this.Cbb_ChoixAutomate.Location = new System.Drawing.Point(101, 21);
            this.Cbb_ChoixAutomate.Name = "Cbb_ChoixAutomate";
            this.Cbb_ChoixAutomate.Size = new System.Drawing.Size(121, 21);
            this.Cbb_ChoixAutomate.TabIndex = 2;
            this.Cbb_ChoixAutomate.Text = "Choix automate";
            // 
            // Bt_Deconnexion
            // 
            this.Bt_Deconnexion.Enabled = false;
            this.Bt_Deconnexion.Location = new System.Drawing.Point(6, 48);
            this.Bt_Deconnexion.Name = "Bt_Deconnexion";
            this.Bt_Deconnexion.Size = new System.Drawing.Size(89, 23);
            this.Bt_Deconnexion.TabIndex = 1;
            this.Bt_Deconnexion.Text = "Déconnexion";
            this.Bt_Deconnexion.UseVisualStyleBackColor = true;
            // 
            // Bt_Connexion
            // 
            this.Bt_Connexion.Location = new System.Drawing.Point(6, 19);
            this.Bt_Connexion.Name = "Bt_Connexion";
            this.Bt_Connexion.Size = new System.Drawing.Size(89, 23);
            this.Bt_Connexion.TabIndex = 0;
            this.Bt_Connexion.Text = "Connexion";
            this.Bt_Connexion.UseVisualStyleBackColor = true;
            // 
            // Tb_Var
            // 
            this.Tb_Var.Location = new System.Drawing.Point(567, 160);
            this.Tb_Var.Multiline = true;
            this.Tb_Var.Name = "Tb_Var";
            this.Tb_Var.ReadOnly = true;
            this.Tb_Var.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Tb_Var.Size = new System.Drawing.Size(359, 181);
            this.Tb_Var.TabIndex = 10;
            // 
            // Cb_1
            // 
            this.Cb_1.AutoCheck = false;
            this.Cb_1.AutoSize = true;
            this.Cb_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cb_1.Location = new System.Drawing.Point(101, 34);
            this.Cb_1.Name = "Cb_1";
            this.Cb_1.Size = new System.Drawing.Size(12, 11);
            this.Cb_1.TabIndex = 9;
            this.Cb_1.UseVisualStyleBackColor = true;
            // 
            // Cb_2
            // 
            this.Cb_2.AutoCheck = false;
            this.Cb_2.AutoSize = true;
            this.Cb_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cb_2.Location = new System.Drawing.Point(176, 34);
            this.Cb_2.Name = "Cb_2";
            this.Cb_2.Size = new System.Drawing.Size(12, 11);
            this.Cb_2.TabIndex = 8;
            this.Cb_2.UseVisualStyleBackColor = true;
            // 
            // Cb_3
            // 
            this.Cb_3.AutoCheck = false;
            this.Cb_3.AutoSize = true;
            this.Cb_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cb_3.Location = new System.Drawing.Point(244, 34);
            this.Cb_3.Name = "Cb_3";
            this.Cb_3.Size = new System.Drawing.Size(12, 11);
            this.Cb_3.TabIndex = 7;
            this.Cb_3.UseVisualStyleBackColor = true;
            // 
            // Cb_4
            // 
            this.Cb_4.AutoCheck = false;
            this.Cb_4.AutoSize = true;
            this.Cb_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cb_4.Location = new System.Drawing.Point(316, 34);
            this.Cb_4.Name = "Cb_4";
            this.Cb_4.Size = new System.Drawing.Size(12, 11);
            this.Cb_4.TabIndex = 6;
            this.Cb_4.UseVisualStyleBackColor = true;
            // 
            // Cb_5
            // 
            this.Cb_5.AutoCheck = false;
            this.Cb_5.AutoSize = true;
            this.Cb_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cb_5.Location = new System.Drawing.Point(384, 34);
            this.Cb_5.Name = "Cb_5";
            this.Cb_5.Size = new System.Drawing.Size(12, 11);
            this.Cb_5.TabIndex = 5;
            this.Cb_5.UseVisualStyleBackColor = true;
            // 
            // BoxRoueG
            // 
            this.BoxRoueG.BackColor = System.Drawing.Color.Transparent;
            this.BoxRoueG.Image = global::ER4_SimuPontRoulant.Properties.Resources.Roue;
            this.BoxRoueG.Location = new System.Drawing.Point(305, 93);
            this.BoxRoueG.Name = "BoxRoueG";
            this.BoxRoueG.Size = new System.Drawing.Size(40, 40);
            this.BoxRoueG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoxRoueG.TabIndex = 2;
            this.BoxRoueG.TabStop = false;
            // 
            // BoxRoueD
            // 
            this.BoxRoueD.Image = global::ER4_SimuPontRoulant.Properties.Resources.Roue;
            this.BoxRoueD.Location = new System.Drawing.Point(259, 93);
            this.BoxRoueD.Name = "BoxRoueD";
            this.BoxRoueD.Size = new System.Drawing.Size(40, 40);
            this.BoxRoueD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoxRoueD.TabIndex = 4;
            this.BoxRoueD.TabStop = false;
            // 
            // BoxPince
            // 
            this.BoxPince.Image = global::ER4_SimuPontRoulant.Properties.Resources.pince;
            this.BoxPince.Location = new System.Drawing.Point(367, 70);
            this.BoxPince.Name = "BoxPince";
            this.BoxPince.Size = new System.Drawing.Size(29, 112);
            this.BoxPince.TabIndex = 3;
            this.BoxPince.TabStop = false;
            // 
            // BoxChariot
            // 
            this.BoxChariot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BoxChariot.Image = global::ER4_SimuPontRoulant.Properties.Resources.Chariot;
            this.BoxChariot.Location = new System.Drawing.Point(0, 70);
            this.BoxChariot.Name = "BoxChariot";
            this.BoxChariot.Size = new System.Drawing.Size(148, 95);
            this.BoxChariot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoxChariot.TabIndex = 1;
            this.BoxChariot.TabStop = false;
            // 
            // BoxPont
            // 
            this.BoxPont.Image = global::ER4_SimuPontRoulant.Properties.Resources.Pont;
            this.BoxPont.Location = new System.Drawing.Point(0, 0);
            this.BoxPont.Name = "BoxPont";
            this.BoxPont.Size = new System.Drawing.Size(561, 342);
            this.BoxPont.TabIndex = 0;
            this.BoxPont.TabStop = false;
            // 
            // OFD_Stu
            // 
            this.OFD_Stu.DefaultExt = "stu";
            this.OFD_Stu.FileName = "openFileDialog1";
            this.OFD_Stu.InitialDirectory = "P:\\";
            // 
            // PontRoulant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 666);
            this.Controls.Add(this.PanelPont);
            this.Name = "PontRoulant";
            this.Text = "Simulateur d\'automate pont roulant";
            this.PanelPont.ResumeLayout(false);
            this.PanelPont.PerformLayout();
            this.Gb_SelAutomate.ResumeLayout(false);
            this.Gb_SelAutomate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoxRoueG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxRoueD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxPince)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxChariot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxPont)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPont;
        private System.Windows.Forms.PictureBox BoxRoueD;
        private System.Windows.Forms.PictureBox BoxPince;
        private System.Windows.Forms.PictureBox BoxRoueG;
        private System.Windows.Forms.PictureBox BoxChariot;
        private System.Windows.Forms.PictureBox BoxPont;
        private System.Windows.Forms.CheckBox Cb_5;
        private System.Windows.Forms.CheckBox Cb_1;
        private System.Windows.Forms.CheckBox Cb_2;
        private System.Windows.Forms.CheckBox Cb_3;
        private System.Windows.Forms.CheckBox Cb_4;
        private System.Windows.Forms.TextBox Tb_Var;
        private System.Windows.Forms.Button Bt_SelectDirectory;
        private System.Windows.Forms.GroupBox Gb_SelAutomate;
        private System.Windows.Forms.Label Lb_EtatCo;
        private System.Windows.Forms.ComboBox Cbb_ChoixAutomate;
        private System.Windows.Forms.Button Bt_Deconnexion;
        private System.Windows.Forms.Button Bt_Connexion;
        private System.Windows.Forms.OpenFileDialog OFD_Stu;

    }
}

