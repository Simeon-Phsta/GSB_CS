namespace App_GSB_cs
{
    partial class FormModifierVisiteur
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
            this.mv_txb_idVisiteur = new System.Windows.Forms.TextBox();
            this.mv_tbxDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mv_txbNomVis = new System.Windows.Forms.TextBox();
            this.mv_cbxVille = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mv_txbPrenomVis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mv_txbAdresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mv_dgw = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mv_btnSupprimer = new System.Windows.Forms.Button();
            this.mv_btnModifier = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mv_dgw)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mv_txb_idVisiteur);
            this.groupBox1.Controls.Add(this.mv_tbxDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.mv_txbNomVis);
            this.groupBox1.Controls.Add(this.mv_cbxVille);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mv_txbPrenomVis);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mv_txbAdresse);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mv_dgw);
            this.groupBox1.Controls.Add(this.mv_btnSupprimer);
            this.groupBox1.Controls.Add(this.mv_btnModifier);
            this.groupBox1.Location = new System.Drawing.Point(11, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(886, 366);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MODIFICATION OU SUPPRESSION D\'UN COMPTE VISITEUR";
            // 
            // mv_txb_idVisiteur
            // 
            this.mv_txb_idVisiteur.Location = new System.Drawing.Point(649, 332);
            this.mv_txb_idVisiteur.Margin = new System.Windows.Forms.Padding(2);
            this.mv_txb_idVisiteur.Name = "mv_txb_idVisiteur";
            this.mv_txb_idVisiteur.Size = new System.Drawing.Size(76, 20);
            this.mv_txb_idVisiteur.TabIndex = 35;
            // 
            // mv_tbxDate
            // 
            this.mv_tbxDate.Location = new System.Drawing.Point(142, 316);
            this.mv_tbxDate.Margin = new System.Windows.Forms.Padding(2);
            this.mv_tbxDate.Name = "mv_tbxDate";
            this.mv_tbxDate.Size = new System.Drawing.Size(205, 20);
            this.mv_tbxDate.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 320);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Date d\'embauche :";
            // 
            // mv_txbNomVis
            // 
            this.mv_txbNomVis.Location = new System.Drawing.Point(142, 174);
            this.mv_txbNomVis.Margin = new System.Windows.Forms.Padding(2);
            this.mv_txbNomVis.Name = "mv_txbNomVis";
            this.mv_txbNomVis.Size = new System.Drawing.Size(205, 20);
            this.mv_txbNomVis.TabIndex = 29;
            // 
            // mv_cbxVille
            // 
            this.mv_cbxVille.FormattingEnabled = true;
            this.mv_cbxVille.Location = new System.Drawing.Point(142, 280);
            this.mv_cbxVille.Margin = new System.Windows.Forms.Padding(2);
            this.mv_cbxVille.Name = "mv_cbxVille";
            this.mv_cbxVille.Size = new System.Drawing.Size(205, 21);
            this.mv_cbxVille.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nom du visiteur :";
            // 
            // mv_txbPrenomVis
            // 
            this.mv_txbPrenomVis.Location = new System.Drawing.Point(142, 209);
            this.mv_txbPrenomVis.Margin = new System.Windows.Forms.Padding(2);
            this.mv_txbPrenomVis.Name = "mv_txbPrenomVis";
            this.mv_txbPrenomVis.Size = new System.Drawing.Size(205, 20);
            this.mv_txbPrenomVis.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 286);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Ville : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Prénom du visiteur :";
            // 
            // mv_txbAdresse
            // 
            this.mv_txbAdresse.Location = new System.Drawing.Point(142, 245);
            this.mv_txbAdresse.Margin = new System.Windows.Forms.Padding(2);
            this.mv_txbAdresse.Name = "mv_txbAdresse";
            this.mv_txbAdresse.Size = new System.Drawing.Size(205, 20);
            this.mv_txbAdresse.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Adresse :";
            // 
            // mv_dgw
            // 
            this.mv_dgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mv_dgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6});
            this.mv_dgw.Location = new System.Drawing.Point(0, 31);
            this.mv_dgw.Margin = new System.Windows.Forms.Padding(2);
            this.mv_dgw.Name = "mv_dgw";
            this.mv_dgw.RowHeadersWidth = 51;
            this.mv_dgw.RowTemplate.Height = 24;
            this.mv_dgw.Size = new System.Drawing.Size(804, 122);
            this.mv_dgw.TabIndex = 23;
            this.mv_dgw.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mv_dgw_CellDoubleClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Id";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nom";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prénom";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Adresse";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID Ville";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Date d\'Embauche";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // mv_btnSupprimer
            // 
            this.mv_btnSupprimer.Location = new System.Drawing.Point(584, 240);
            this.mv_btnSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.mv_btnSupprimer.Name = "mv_btnSupprimer";
            this.mv_btnSupprimer.Size = new System.Drawing.Size(100, 28);
            this.mv_btnSupprimer.TabIndex = 21;
            this.mv_btnSupprimer.Text = "Supprimer";
            this.mv_btnSupprimer.UseVisualStyleBackColor = true;
            this.mv_btnSupprimer.Click += new System.EventHandler(this.mv_btnSupprimer_Click);
            // 
            // mv_btnModifier
            // 
            this.mv_btnModifier.Location = new System.Drawing.Point(438, 240);
            this.mv_btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.mv_btnModifier.Name = "mv_btnModifier";
            this.mv_btnModifier.Size = new System.Drawing.Size(100, 28);
            this.mv_btnModifier.TabIndex = 20;
            this.mv_btnModifier.Text = "Modifier";
            this.mv_btnModifier.UseVisualStyleBackColor = true;
            this.mv_btnModifier.Click += new System.EventHandler(this.mv_btnModifier_Click_1);
            // 
            // FormModifierVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 470);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormModifierVisiteur";
            this.Text = "Modifier Visiteur";
            this.Load += new System.EventHandler(this.FormModifierVisiteur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mv_dgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox mv_txbNomVis;
        private System.Windows.Forms.ComboBox mv_cbxVille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mv_txbPrenomVis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mv_txbAdresse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView mv_dgw;
        private System.Windows.Forms.Button mv_btnSupprimer;
        private System.Windows.Forms.Button mv_btnModifier;
        private System.Windows.Forms.TextBox mv_tbxDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox mv_txb_idVisiteur;
    }
}