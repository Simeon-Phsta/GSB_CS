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
            this.gbMedecin = new System.Windows.Forms.GroupBox();
            this.txtBxIdMedecin = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtBxNom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
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
            this.gbRapport = new System.Windows.Forms.GroupBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cbbxMotif = new System.Windows.Forms.ComboBox();
            this.txtBxIdRapport = new System.Windows.Forms.TextBox();
            this.btnSupprimerRapport = new System.Windows.Forms.Button();
            this.btnModifierRapport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxRapport = new System.Windows.Forms.TextBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDerniereVisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifVisite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rapport_visite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBxPrenom = new System.Windows.Forms.TextBox();
            this.cbbxVille = new System.Windows.Forms.ComboBox();
            this.txtBxAdresse = new System.Windows.Forms.TextBox();
            this.cbbxSpecialite = new System.Windows.Forms.ComboBox();
            this.txtBxTelephone = new System.Windows.Forms.TextBox();
            this.btnAjouterMedecin = new System.Windows.Forms.Button();
            this.btnSupprimerMedecin = new System.Windows.Forms.Button();
            this.btnModifierMedecin = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbMedecin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAllMedics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRapport)).BeginInit();
            this.gbRapport.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMedecin
            // 
            this.gbMedecin.Controls.Add(this.btnClear);
            this.gbMedecin.Controls.Add(this.btnModifierMedecin);
            this.gbMedecin.Controls.Add(this.btnSupprimerMedecin);
            this.gbMedecin.Controls.Add(this.btnAjouterMedecin);
            this.gbMedecin.Controls.Add(this.txtBxTelephone);
            this.gbMedecin.Controls.Add(this.cbbxSpecialite);
            this.gbMedecin.Controls.Add(this.txtBxAdresse);
            this.gbMedecin.Controls.Add(this.cbbxVille);
            this.gbMedecin.Controls.Add(this.txtBxPrenom);
            this.gbMedecin.Controls.Add(this.txtBxIdMedecin);
            this.gbMedecin.Controls.Add(this.lblTelephone);
            this.gbMedecin.Controls.Add(this.lblNom);
            this.gbMedecin.Controls.Add(this.txtBxNom);
            this.gbMedecin.Controls.Add(this.lblPrenom);
            this.gbMedecin.Controls.Add(this.lblVille);
            this.gbMedecin.Controls.Add(this.lblAdresse);
            this.gbMedecin.Controls.Add(this.lblSpecialite);
            this.gbMedecin.Location = new System.Drawing.Point(910, 12);
            this.gbMedecin.Name = "gbMedecin";
            this.gbMedecin.Size = new System.Drawing.Size(283, 308);
            this.gbMedecin.TabIndex = 35;
            this.gbMedecin.TabStop = false;
            this.gbMedecin.Text = "Ajout Praticien";
            // 
            // txtBxIdMedecin
            // 
            this.txtBxIdMedecin.HideSelection = false;
            this.txtBxIdMedecin.Location = new System.Drawing.Point(110, 19);
            this.txtBxIdMedecin.Name = "txtBxIdMedecin";
            this.txtBxIdMedecin.ReadOnly = true;
            this.txtBxIdMedecin.Size = new System.Drawing.Size(148, 20);
            this.txtBxIdMedecin.TabIndex = 41;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(33, 227);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(58, 13);
            this.lblTelephone.TabIndex = 20;
            this.lblTelephone.Text = "Téléphone";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(33, 52);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 5;
            this.lblNom.Text = "Nom";
            // 
            // txtBxNom
            // 
            this.txtBxNom.Location = new System.Drawing.Point(110, 45);
            this.txtBxNom.Name = "txtBxNom";
            this.txtBxNom.Size = new System.Drawing.Size(148, 20);
            this.txtBxNom.TabIndex = 4;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(33, 89);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 6;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(37, 121);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(26, 13);
            this.lblVille.TabIndex = 7;
            this.lblVille.Text = "Ville";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(33, 159);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(45, 13);
            this.lblAdresse.TabIndex = 8;
            this.lblAdresse.Text = "Adresse";
            // 
            // lblSpecialite
            // 
            this.lblSpecialite.AutoSize = true;
            this.lblSpecialite.Location = new System.Drawing.Point(33, 194);
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
            this.dtgvAllMedics.Size = new System.Drawing.Size(843, 308);
            this.dtgvAllMedics.TabIndex = 32;
            this.dtgvAllMedics.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvAllMedics_CellContentDoubleClick);
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
            this.dtgvRapport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRapport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.dateDerniereVisite,
            this.motifVisite,
            this.rapport_visite});
            this.dtgvRapport.Location = new System.Drawing.Point(12, 341);
            this.dtgvRapport.Name = "dtgvRapport";
            this.dtgvRapport.Size = new System.Drawing.Size(843, 253);
            this.dtgvRapport.TabIndex = 34;
            this.dtgvRapport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRapport_CellClick);
            // 
            // gbRapport
            // 
            this.gbRapport.Controls.Add(this.dtp);
            this.gbRapport.Controls.Add(this.cbbxMotif);
            this.gbRapport.Controls.Add(this.txtBxIdRapport);
            this.gbRapport.Controls.Add(this.btnSupprimerRapport);
            this.gbRapport.Controls.Add(this.btnModifierRapport);
            this.gbRapport.Controls.Add(this.label2);
            this.gbRapport.Controls.Add(this.txtBxRapport);
            this.gbRapport.Controls.Add(this.lblMotif);
            this.gbRapport.Controls.Add(this.lblDate);
            this.gbRapport.Location = new System.Drawing.Point(910, 341);
            this.gbRapport.Name = "gbRapport";
            this.gbRapport.Size = new System.Drawing.Size(283, 253);
            this.gbRapport.TabIndex = 40;
            this.gbRapport.TabStop = false;
            this.gbRapport.Text = "Gestion des rapports";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(110, 63);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(167, 20);
            this.dtp.TabIndex = 41;
            // 
            // cbbxMotif
            // 
            this.cbbxMotif.FormattingEnabled = true;
            this.cbbxMotif.Location = new System.Drawing.Point(110, 95);
            this.cbbxMotif.Name = "cbbxMotif";
            this.cbbxMotif.Size = new System.Drawing.Size(167, 21);
            this.cbbxMotif.TabIndex = 40;
            // 
            // txtBxIdRapport
            // 
            this.txtBxIdRapport.HideSelection = false;
            this.txtBxIdRapport.Location = new System.Drawing.Point(110, 37);
            this.txtBxIdRapport.Name = "txtBxIdRapport";
            this.txtBxIdRapport.ReadOnly = true;
            this.txtBxIdRapport.Size = new System.Drawing.Size(167, 20);
            this.txtBxIdRapport.TabIndex = 8;
            // 
            // btnSupprimerRapport
            // 
            this.btnSupprimerRapport.Location = new System.Drawing.Point(158, 215);
            this.btnSupprimerRapport.Name = "btnSupprimerRapport";
            this.btnSupprimerRapport.Size = new System.Drawing.Size(100, 23);
            this.btnSupprimerRapport.TabIndex = 7;
            this.btnSupprimerRapport.Text = "Supprimer";
            this.btnSupprimerRapport.UseVisualStyleBackColor = true;
            this.btnSupprimerRapport.Click += new System.EventHandler(this.btnSupprimerRapport_Click);
            // 
            // btnModifierRapport
            // 
            this.btnModifierRapport.Location = new System.Drawing.Point(29, 215);
            this.btnModifierRapport.Name = "btnModifierRapport";
            this.btnModifierRapport.Size = new System.Drawing.Size(100, 23);
            this.btnModifierRapport.TabIndex = 6;
            this.btnModifierRapport.Text = "Modifier";
            this.btnModifierRapport.UseVisualStyleBackColor = true;
            this.btnModifierRapport.Click += new System.EventHandler(this.btnModifierRapport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rapport";
            // 
            // txtBxRapport
            // 
            this.txtBxRapport.Location = new System.Drawing.Point(110, 143);
            this.txtBxRapport.Name = "txtBxRapport";
            this.txtBxRapport.Size = new System.Drawing.Size(167, 20);
            this.txtBxRapport.TabIndex = 4;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(33, 98);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(30, 13);
            this.lblMotif.TabIndex = 3;
            this.lblMotif.Text = "Motif";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(33, 70);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Id de la visite";
            this.clmId.MinimumWidth = 10;
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
            // rapport_visite
            // 
            this.rapport_visite.HeaderText = "Rapport de la visite";
            this.rapport_visite.Name = "rapport_visite";
            this.rapport_visite.Width = 175;
            // 
            // txtBxPrenom
            // 
            this.txtBxPrenom.Location = new System.Drawing.Point(110, 82);
            this.txtBxPrenom.Name = "txtBxPrenom";
            this.txtBxPrenom.Size = new System.Drawing.Size(148, 20);
            this.txtBxPrenom.TabIndex = 42;
            // 
            // cbbxVille
            // 
            this.cbbxVille.FormattingEnabled = true;
            this.cbbxVille.Location = new System.Drawing.Point(110, 118);
            this.cbbxVille.Name = "cbbxVille";
            this.cbbxVille.Size = new System.Drawing.Size(148, 21);
            this.cbbxVille.TabIndex = 43;
            // 
            // txtBxAdresse
            // 
            this.txtBxAdresse.Location = new System.Drawing.Point(110, 152);
            this.txtBxAdresse.Name = "txtBxAdresse";
            this.txtBxAdresse.Size = new System.Drawing.Size(148, 20);
            this.txtBxAdresse.TabIndex = 44;
            // 
            // cbbxSpecialite
            // 
            this.cbbxSpecialite.FormattingEnabled = true;
            this.cbbxSpecialite.Location = new System.Drawing.Point(110, 186);
            this.cbbxSpecialite.Name = "cbbxSpecialite";
            this.cbbxSpecialite.Size = new System.Drawing.Size(148, 21);
            this.cbbxSpecialite.TabIndex = 45;
            // 
            // txtBxTelephone
            // 
            this.txtBxTelephone.Location = new System.Drawing.Point(110, 224);
            this.txtBxTelephone.Name = "txtBxTelephone";
            this.txtBxTelephone.Size = new System.Drawing.Size(148, 20);
            this.txtBxTelephone.TabIndex = 46;
            // 
            // btnAjouterMedecin
            // 
            this.btnAjouterMedecin.Location = new System.Drawing.Point(29, 250);
            this.btnAjouterMedecin.Name = "btnAjouterMedecin";
            this.btnAjouterMedecin.Size = new System.Drawing.Size(100, 23);
            this.btnAjouterMedecin.TabIndex = 47;
            this.btnAjouterMedecin.Text = "Ajouter";
            this.btnAjouterMedecin.UseVisualStyleBackColor = true;
            this.btnAjouterMedecin.Click += new System.EventHandler(this.btnAjouterMedecin_Click);
            // 
            // btnSupprimerMedecin
            // 
            this.btnSupprimerMedecin.Location = new System.Drawing.Point(158, 250);
            this.btnSupprimerMedecin.Name = "btnSupprimerMedecin";
            this.btnSupprimerMedecin.Size = new System.Drawing.Size(109, 23);
            this.btnSupprimerMedecin.TabIndex = 48;
            this.btnSupprimerMedecin.Text = "Supprimer";
            this.btnSupprimerMedecin.UseVisualStyleBackColor = true;
            this.btnSupprimerMedecin.Click += new System.EventHandler(this.btnSupprimerMedecin_Click);
            // 
            // btnModifierMedecin
            // 
            this.btnModifierMedecin.Location = new System.Drawing.Point(29, 279);
            this.btnModifierMedecin.Name = "btnModifierMedecin";
            this.btnModifierMedecin.Size = new System.Drawing.Size(100, 23);
            this.btnModifierMedecin.TabIndex = 49;
            this.btnModifierMedecin.Text = "Modifier";
            this.btnModifierMedecin.UseVisualStyleBackColor = true;
            this.btnModifierMedecin.Click += new System.EventHandler(this.btnModifierMedecin_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(158, 279);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 23);
            this.btnClear.TabIndex = 50;
            this.btnClear.Text = "Vider les champs";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // FormMedecins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 628);
            this.ControlBox = false;
            this.Controls.Add(this.gbRapport);
            this.Controls.Add(this.gbMedecin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvAllMedics);
            this.Controls.Add(this.dtgvRapport);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMedecins";
            this.Text = "Praticien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMedecins_Load);
            this.gbMedecin.ResumeLayout(false);
            this.gbMedecin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAllMedics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRapport)).EndInit();
            this.gbRapport.ResumeLayout(false);
            this.gbRapport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbMedecin;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtBxNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblSpecialite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvAllMedics;
        private System.Windows.Forms.DataGridView dtgvRapport;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.GroupBox gbRapport;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnSupprimerRapport;
        private System.Windows.Forms.Button btnModifierRapport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxRapport;
        private System.Windows.Forms.TextBox txtBxIdRapport;
        private System.Windows.Forms.ComboBox cbbxMotif;
        private System.Windows.Forms.TextBox txtBxIdMedecin;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn speMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpVille;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDerniereVisite;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifVisite;
        private System.Windows.Forms.DataGridViewTextBoxColumn rapport_visite;
        private System.Windows.Forms.ComboBox cbbxSpecialite;
        private System.Windows.Forms.TextBox txtBxAdresse;
        private System.Windows.Forms.ComboBox cbbxVille;
        private System.Windows.Forms.TextBox txtBxPrenom;
        private System.Windows.Forms.TextBox txtBxTelephone;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnModifierMedecin;
        private System.Windows.Forms.Button btnSupprimerMedecin;
        private System.Windows.Forms.Button btnAjouterMedecin;
    }
}