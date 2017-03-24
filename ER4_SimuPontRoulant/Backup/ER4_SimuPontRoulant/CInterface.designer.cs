namespace prjt
{
    partial class CInterface
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
            this.ModeManu = new System.Windows.Forms.RadioButton();
            this.ModeAuto = new System.Windows.Forms.RadioButton();
            this.Gauche = new System.Windows.Forms.Button();
            this.Haut = new System.Windows.Forms.Button();
            this.Bas = new System.Windows.Forms.Button();
            this.Droite = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.ArretUrgence = new System.Windows.Forms.Button();
            this.Aucun_mode = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Monitor = new System.Windows.Forms.TextBox();
            this.DepartCycle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModeManu
            // 
            this.ModeManu.AutoSize = true;
            this.ModeManu.Location = new System.Drawing.Point(403, 134);
            this.ModeManu.Name = "ModeManu";
            this.ModeManu.Size = new System.Drawing.Size(90, 17);
            this.ModeManu.TabIndex = 0;
            this.ModeManu.Text = "Mode Manuel";
            this.ModeManu.UseVisualStyleBackColor = true;
            this.ModeManu.Click += new System.EventHandler(this.On_Click_Radio_Button);
            // 
            // ModeAuto
            // 
            this.ModeAuto.AutoSize = true;
            this.ModeAuto.Location = new System.Drawing.Point(229, 134);
            this.ModeAuto.Name = "ModeAuto";
            this.ModeAuto.Size = new System.Drawing.Size(77, 17);
            this.ModeAuto.TabIndex = 1;
            this.ModeAuto.Text = "Mode Auto";
            this.ModeAuto.UseVisualStyleBackColor = true;
            this.ModeAuto.Click += new System.EventHandler(this.On_Click_Radio_Button);
            // 
            // Gauche
            // 
            this.Gauche.BackColor = System.Drawing.SystemColors.ControlText;
            this.Gauche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gauche.ForeColor = System.Drawing.SystemColors.Control;
            this.Gauche.Location = new System.Drawing.Point(125, 36);
            this.Gauche.Name = "Gauche";
            this.Gauche.Size = new System.Drawing.Size(98, 51);
            this.Gauche.TabIndex = 2;
            this.Gauche.Text = "Gauche";
            this.Gauche.UseVisualStyleBackColor = false;
            this.Gauche.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.Gauche.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // Haut
            // 
            this.Haut.BackColor = System.Drawing.SystemColors.ControlText;
            this.Haut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Haut.ForeColor = System.Drawing.SystemColors.Control;
            this.Haut.Location = new System.Drawing.Point(125, 119);
            this.Haut.Name = "Haut";
            this.Haut.Size = new System.Drawing.Size(98, 46);
            this.Haut.TabIndex = 3;
            this.Haut.Text = "Haut";
            this.Haut.UseVisualStyleBackColor = false;
            this.Haut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.Haut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // Bas
            // 
            this.Bas.BackColor = System.Drawing.SystemColors.ControlText;
            this.Bas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bas.ForeColor = System.Drawing.SystemColors.Control;
            this.Bas.Location = new System.Drawing.Point(499, 119);
            this.Bas.Name = "Bas";
            this.Bas.Size = new System.Drawing.Size(95, 46);
            this.Bas.TabIndex = 4;
            this.Bas.Text = "Bas";
            this.Bas.UseVisualStyleBackColor = false;
            this.Bas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.Bas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // Droite
            // 
            this.Droite.BackColor = System.Drawing.SystemColors.ControlText;
            this.Droite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Droite.ForeColor = System.Drawing.SystemColors.Control;
            this.Droite.Location = new System.Drawing.Point(499, 36);
            this.Droite.Name = "Droite";
            this.Droite.Size = new System.Drawing.Size(95, 51);
            this.Droite.TabIndex = 5;
            this.Droite.Text = "Droite";
            this.Droite.UseVisualStyleBackColor = false;
            this.Droite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.Droite.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.ControlText;
            this.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reset.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Reset.Location = new System.Drawing.Point(312, 36);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(96, 51);
            this.Reset.TabIndex = 6;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            this.Reset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // ArretUrgence
            // 
            this.ArretUrgence.BackColor = System.Drawing.Color.Red;
            this.ArretUrgence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArretUrgence.ForeColor = System.Drawing.SystemColors.Control;
            this.ArretUrgence.Location = new System.Drawing.Point(25, 119);
            this.ArretUrgence.Name = "ArretUrgence";
            this.ArretUrgence.Size = new System.Drawing.Size(94, 46);
            this.ArretUrgence.TabIndex = 8;
            this.ArretUrgence.Text = "Arret Urgence";
            this.ArretUrgence.UseVisualStyleBackColor = false;
            this.ArretUrgence.Click += new System.EventHandler(this.OnClick_ArretUrgence);
            // 
            // Aucun_mode
            // 
            this.Aucun_mode.AutoSize = true;
            this.Aucun_mode.Checked = true;
            this.Aucun_mode.Location = new System.Drawing.Point(312, 134);
            this.Aucun_mode.Name = "Aucun_mode";
            this.Aucun_mode.Size = new System.Drawing.Size(85, 17);
            this.Aucun_mode.TabIndex = 9;
            this.Aucun_mode.TabStop = true;
            this.Aucun_mode.Text = "Aucun mode";
            this.Aucun_mode.UseVisualStyleBackColor = true;
            this.Aucun_mode.CheckedChanged += new System.EventHandler(this.On_Click_Radio_Button);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(DepartCycle);
            this.panel1.Controls.Add(this.Bas);
            this.panel1.Controls.Add(this.Aucun_mode);
            this.panel1.Controls.Add(this.ModeManu);
            this.panel1.Controls.Add(this.ModeAuto);
            this.panel1.Controls.Add(this.Gauche);
            this.panel1.Controls.Add(this.ArretUrgence);
            this.panel1.Controls.Add(this.Haut);
            this.panel1.Controls.Add(this.Reset);
            this.panel1.Controls.Add(this.Droite);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(620, 210);
            this.panel1.TabIndex = 10;
            // 
            // DepartCycle
            // 
            DepartCycle.BackColor = System.Drawing.SystemColors.ControlText;
            DepartCycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            DepartCycle.ForeColor = System.Drawing.SystemColors.Control;
            DepartCycle.Location = new System.Drawing.Point(25, 36);
            DepartCycle.Name = "DepartCycle";
            DepartCycle.Size = new System.Drawing.Size(94, 51);
            DepartCycle.TabIndex = 7;
            DepartCycle.Text = "Depart Cycle";
            DepartCycle.UseVisualStyleBackColor = false;
            DepartCycle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mouse_Down);
            DepartCycle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mouse_Up);
            // 
            // Monitor
            // 
            this.Monitor.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Monitor.Location = new System.Drawing.Point(636, 10);
            this.Monitor.Multiline = true;
            this.Monitor.Name = "Monitor";
            this.Monitor.ReadOnly = true;
            this.Monitor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Monitor.Size = new System.Drawing.Size(344, 210);
            this.Monitor.TabIndex = 11;
            // 
            // CInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(992, 232);
            this.ControlBox = false;
            this.Controls.Add(this.Monitor);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CInterface";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ModeManu;
        private System.Windows.Forms.RadioButton ModeAuto;
        private System.Windows.Forms.Button Gauche;
        private System.Windows.Forms.Button Haut;
        private System.Windows.Forms.Button Bas;
        private System.Windows.Forms.Button Droite;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button ArretUrgence;
        private System.Windows.Forms.RadioButton Aucun_mode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Monitor;
        private System.Windows.Forms.Button DepartCycle;
    }
}

