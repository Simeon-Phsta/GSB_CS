namespace App_GSB_cs
{
    partial class FormMedecins
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
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtBxPrenom = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbxVille = new System.Windows.Forms.ComboBox();
            this.txtBxTelephone = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.cbbxSpecialite = new System.Windows.Forms.ComboBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtBxNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.txtBxAdresse = new System.Windows.Forms.TextBox();
            this.lblSpecialite = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvAllMedics = new System.Windows.Forms.DataGridView();
            this.nomMedecin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomMedecin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speMedecin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeMedecin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpVille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseMedecin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedecin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvRapport = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDerniereVisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifVisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAllMedics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRapport)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(896, 240);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 23);
            this.btnSupprimer.TabIndex = 37;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click_1);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(896, 211);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(100, 23);
            this.btnModifier.TabIndex = 36;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // txtBxPrenom
            // 
            this.txtBxPrenom.Location = new System.Drawing.Point(110, 56);
            this.txtBxPrenom.Name = "txtBxPrenom";
            this.txtBxPrenom.Size = new System.Drawing.Size(148, 20);
            this.txtBxPrenom.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbxVille);
            this.groupBox1.Controls.Add(this.txtBxTelephone);
            this.groupBox1.Controls.Add(this.lblTelephone);
            this.groupBox1.Controls.Add(this.cbbxSpecialite);
            this.groupBox1.Controls.Add(this.lblNom);
            this.groupBox1.Controls.Add(this.txtBxNom);
            this.groupBox1.Controls.Add(this.lblPrenom);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.lblVille);
            this.groupBox1.Controls.Add(this.lblAdresse);
            this.groupBox1.Controls.Add(this.txtBxAdresse);
            this.groupBox1.Controls.Add(this.lblSpecialite);
            this.groupBox1.Controls.Add(this.txtBxPrenom);
            this.groupBox1.Location = new System.Drawing.Point(572, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 253);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajout Praticien";
            // 
            // cbbxVille
            // 
            this.cbbxVille.FormattingEnabled = true;
            this.cbbxVille.Location = new System.Drawing.Point(110, 92);
            this.cbbxVille.Name = "cbbxVille";
            this.cbbxVille.Size = new System.Drawing.Size(148, 21);
            this.cbbxVille.TabIndex = 22;
            // 
            // txtBxTelephone
            // 
            this.txtBxTelephone.Location = new System.Drawing.Point(110, 198);
            this.txtBxTelephone.Name = "txtBxTelephone";
            this.txtBxTelephone.Size = new System.Drawing.Size(148, 20);
            this.txtBxTelephone.TabIndex = 21;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(33, 201);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(58, 13);
            this.lblTelephone.TabIndex = 20;
            this.lblTelephone.Text = "Téléphone";
            // 
            // cbbxSpecialite
            // 
            this.cbbxSpecialite.FormattingEnabled = true;
            this.cbbxSpecialite.Location = new System.Drawing.Point(110, 165);
            this.cbbxSpecialite.Name = "cbbxSpecialite";
            this.cbbxSpecialite.Size = new System.Drawing.Size(148, 21);
            this.cbbxSpecialite.TabIndex = 19;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(33, 26);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Nom";
            // 
            // txtBxNom
            // 
            this.txtBxNom.Location = new System.Drawing.Point(110, 19);
            this.txtBxNom.Name = "txtBxNom";
            this.txtBxNom.Size = new System.Drawing.Size(148, 20);
            this.txtBxNom.TabIndex = 4;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(33, 63);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 6;
            this.lblPrenom.Text = "Prénom";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(76, 224);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 14;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(33, 101);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(26, 13);
            this.lblVille.TabIndex = 7;
            this.lblVille.Text = "Ville";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(33, 133);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblAdresse.TabIndex = 8;
            this.lblAdresse.Text = "Adresse";
            // 
            // txtBxAdresse
            // 
            this.txtBxAdresse.Location = new System.Drawing.Point(110, 130);
            this.txtBxAdresse.Name = "txtBxAdresse";
            this.txtBxAdresse.Size = new System.Drawing.Size(148, 20);
            this.txtBxAdresse.TabIndex = 12;
            // 
            // lblSpecialite
            // 
            this.lblSpecialite.AutoSize = true;
            this.lblSpecialite.Location = new System.Drawing.Point(33, 168);
            this.lblSpecialite.Name = "lblSpecialite";
            this.lblSpecialite.Size = new System.Drawing.Size(53, 13);
            this.lblSpecialite.TabIndex = 9;
            this.lblSpecialite.Text = "Spécialité";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 33;
            // 
            // dtgvAllMedics
            // 
            this.dtgvAllMedics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAllMedics.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomMedecin,
            this.prenomMedecin,
            this.speMedecin,
            this.villeMedecin,
            this.cpVille,
            this.adresseMedecin,
            this.telephone,
            this.idMedecin});
            this.dtgvAllMedics.Location = new System.Drawing.Point(12, 12);
            this.dtgvAllMedics.Name = "dtgvAllMedics";
            this.dtgvAllMedics.Size = new System.Drawing.Size(843, 150);
            this.dtgvAllMedics.TabIndex = 32;
            this.dtgvAllMedics.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAllMedics_CellContentClick);
            // 
            // nomMedecin
            // 
            this.nomMedecin.HeaderText = "Nom";
            this.nomMedecin.Name = "nomMedecin";
            // 
            // prenomMedecin
            // 
            this.prenomMedecin.HeaderText = "Prénom";
            this.prenomMedecin.Name = "prenomMedecin";
            // 
            // speMedecin
            // 
            this.speMedecin.HeaderText = "Spécialité";
            this.speMedecin.Name = "speMedecin";
            // 
            // villeMedecin
            // 
            this.villeMedecin.HeaderText = "Ville";
            this.villeMedecin.Name = "villeMedecin";
            // 
            // cpVille
            // 
            this.cpVille.HeaderText = "Code Postal";
            this.cpVille.Name = "cpVille";
            // 
            // adresseMedecin
            // 
            this.adresseMedecin.HeaderText = "Adresse";
            this.adresseMedecin.Name = "adresseMedecin";
            // 
            // telephone
            // 
            this.telephone.HeaderText = "Téléphone";
            this.telephone.Name = "telephone";
            // 
            // idMedecin
            // 
            this.idMedecin.HeaderText = "Id";
            this.idMedecin.Name = "idMedecin";
            this.idMedecin.Visible = false;
            // 
            // dtgvRapport
            // 
            this.dtgvRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRapport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.dateDerniereVisite,
            this.motifVisite});
            this.dtgvRapport.Location = new System.Drawing.Point(12, 168);
            this.dtgvRapport.Name = "dtgvRapport";
            this.dtgvRapport.Size = new System.Drawing.Size(554, 253);
            this.dtgvRapport.TabIndex = 34;
            this.dtgvRapport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRapport_CellClick);
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Id de la visite";
            this.clmId.Name = "clmId";
            this.clmId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dateDerniereVisite
            // 
            this.dateDerniereVisite.HeaderText = "Date de la derniere visite";
            this.dateDerniereVisite.Name = "dateDerniereVisite";
            this.dateDerniereVisite.Width = 175;
            // 
            // motifVisite
            // 
            this.motifVisite.HeaderText = "Motif de la Visite";
            this.motifVisite.Name = "motifVisite";
            this.motifVisite.Width = 175;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(896, 269);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Vider les champs";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormMedecins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 439);
            this.ControlBox = false;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvAllMedics);
            this.Controls.Add(this.dtgvRapport);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMedecins";
            this.Text = "Praticien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMedecins_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAllMedics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRapport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtBxPrenom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbxSpecialite;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtBxNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.TextBox txtBxAdresse;
        private System.Windows.Forms.Label lblSpecialite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvAllMedics;
        private System.Windows.Forms.DataGridView dtgvRapport;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtBxTelephone;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDerniereVisite;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifVisite;
        private System.Windows.Forms.ComboBox cbbxVille;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn speMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpVille;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecin;
    }
}