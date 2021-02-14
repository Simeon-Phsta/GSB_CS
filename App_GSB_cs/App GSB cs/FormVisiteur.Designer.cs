namespace App_GSB_cs
{
    partial class FormVisiteur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.v_btnModifier = new System.Windows.Forms.Button();
            this.v_btnAnnuler = new System.Windows.Forms.Button();
            this.v_btnValider = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.v_dtpEmbauche = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.v_txbNomVis = new System.Windows.Forms.TextBox();
            this.v_cbxVille = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.v_txbPrenomVis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.v_txbAdresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.v_txbCp = new System.Windows.Forms.TextBox();
            this.v_txbLogin = new System.Windows.Forms.TextBox();
            this.v_txbMdp = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.v_btnModifier);
            this.groupBox1.Controls.Add(this.v_btnAnnuler);
            this.groupBox1.Controls.Add(this.v_btnValider);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(22, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(742, 363);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CREATION D\'UN COMPTE VISITEUR";
            // 
            // v_btnModifier
            // 
            this.v_btnModifier.Location = new System.Drawing.Point(447, 317);
            this.v_btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.v_btnModifier.Name = "v_btnModifier";
            this.v_btnModifier.Size = new System.Drawing.Size(246, 28);
            this.v_btnModifier.TabIndex = 24;
            this.v_btnModifier.Text = "Modifier / Supprimer";
            this.v_btnModifier.UseVisualStyleBackColor = true;
            this.v_btnModifier.Click += new System.EventHandler(this.v_btnModifier_Click);
            // 
            // v_btnAnnuler
            // 
            this.v_btnAnnuler.Location = new System.Drawing.Point(592, 263);
            this.v_btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.v_btnAnnuler.Name = "v_btnAnnuler";
            this.v_btnAnnuler.Size = new System.Drawing.Size(100, 28);
            this.v_btnAnnuler.TabIndex = 21;
            this.v_btnAnnuler.Text = "Annuler";
            this.v_btnAnnuler.UseVisualStyleBackColor = true;
            this.v_btnAnnuler.Click += new System.EventHandler(this.v_btnAnnuler_Click_1);
            // 
            // v_btnValider
            // 
            this.v_btnValider.Location = new System.Drawing.Point(446, 263);
            this.v_btnValider.Margin = new System.Windows.Forms.Padding(2);
            this.v_btnValider.Name = "v_btnValider";
            this.v_btnValider.Size = new System.Drawing.Size(100, 28);
            this.v_btnValider.TabIndex = 20;
            this.v_btnValider.Text = "Valider";
            this.v_btnValider.UseVisualStyleBackColor = true;
            this.v_btnValider.Click += new System.EventHandler(this.v_btnValider_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.v_dtpEmbauche);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(21, 253);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(366, 92);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Embauche";
            // 
            // v_dtpEmbauche
            // 
            this.v_dtpEmbauche.Location = new System.Drawing.Point(146, 40);
            this.v_dtpEmbauche.Margin = new System.Windows.Forms.Padding(2);
            this.v_dtpEmbauche.Name = "v_dtpEmbauche";
            this.v_dtpEmbauche.Size = new System.Drawing.Size(205, 20);
            this.v_dtpEmbauche.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date d\'embauche :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.v_txbMdp);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.v_txbLogin);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(410, 28);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(314, 167);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Login et mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Login :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mot de passe :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.v_txbNomVis);
            this.groupBox2.Controls.Add(this.v_cbxVille);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.v_txbPrenomVis);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.v_txbAdresse);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(21, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(366, 207);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informations du visiteur";
            // 
            // v_txbNomVis
            // 
            this.v_txbNomVis.Location = new System.Drawing.Point(146, 46);
            this.v_txbNomVis.Margin = new System.Windows.Forms.Padding(2);
            this.v_txbNomVis.Name = "v_txbNomVis";
            this.v_txbNomVis.Size = new System.Drawing.Size(205, 20);
            this.v_txbNomVis.TabIndex = 8;
            // 
            // v_cbxVille
            // 
            this.v_cbxVille.FormattingEnabled = true;
            this.v_cbxVille.Location = new System.Drawing.Point(146, 151);
            this.v_cbxVille.Margin = new System.Windows.Forms.Padding(2);
            this.v_cbxVille.Name = "v_cbxVille";
            this.v_cbxVille.Size = new System.Drawing.Size(205, 21);
            this.v_cbxVille.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du visiteur :";
            // 
            // v_txbPrenomVis
            // 
            this.v_txbPrenomVis.Location = new System.Drawing.Point(146, 80);
            this.v_txbPrenomVis.Margin = new System.Windows.Forms.Padding(2);
            this.v_txbPrenomVis.Name = "v_txbPrenomVis";
            this.v_txbPrenomVis.Size = new System.Drawing.Size(205, 20);
            this.v_txbPrenomVis.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 157);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ville : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prénom du visiteur :";
            // 
            // v_txbAdresse
            // 
            this.v_txbAdresse.Location = new System.Drawing.Point(146, 116);
            this.v_txbAdresse.Margin = new System.Windows.Forms.Padding(2);
            this.v_txbAdresse.Name = "v_txbAdresse";
            this.v_txbAdresse.Size = new System.Drawing.Size(205, 20);
            this.v_txbAdresse.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adresse :";
            // 
            // v_txbCp
            // 
            this.v_txbCp.Location = new System.Drawing.Point(164, 192);
            this.v_txbCp.Margin = new System.Windows.Forms.Padding(2);
            this.v_txbCp.Name = "v_txbCp";
            this.v_txbCp.Size = new System.Drawing.Size(205, 20);
            this.v_txbCp.TabIndex = 19;
            // 
            // v_txbLogin
            // 
            this.v_txbLogin.Location = new System.Drawing.Point(97, 52);
            this.v_txbLogin.Margin = new System.Windows.Forms.Padding(2);
            this.v_txbLogin.Name = "v_txbLogin";
            this.v_txbLogin.Size = new System.Drawing.Size(205, 20);
            this.v_txbLogin.TabIndex = 13;
            // 
            // v_txbMdp
            // 
            this.v_txbMdp.Location = new System.Drawing.Point(97, 96);
            this.v_txbMdp.Margin = new System.Windows.Forms.Padding(2);
            this.v_txbMdp.Name = "v_txbMdp";
            this.v_txbMdp.Size = new System.Drawing.Size(205, 20);
            this.v_txbMdp.TabIndex = 14;
            // 
            // FormVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 438);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.v_txbCp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVisiteur";
            this.Text = "Visiteurs";
            this.Load += new System.EventHandler(this.FormVisiteur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button v_btnAnnuler;
        private System.Windows.Forms.Button v_btnValider;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker v_dtpEmbauche;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox v_txbNomVis;
        private System.Windows.Forms.ComboBox v_cbxVille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox v_txbPrenomVis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox v_txbAdresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox v_txbCp;
        private System.Windows.Forms.Button v_btnModifier;
        private System.Windows.Forms.TextBox v_txbMdp;
        private System.Windows.Forms.TextBox v_txbLogin;
    }
}