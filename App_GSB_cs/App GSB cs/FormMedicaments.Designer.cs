namespace App_GSB_cs
{
    partial class FormMedicaments
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
            this.DtgvAllMedocs = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbFamMedocs = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AdMed = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.rtCompo = new System.Windows.Forms.RichTextBox();
            this.rtEffets = new System.Windows.Forms.RichTextBox();
            this.DelMed = new System.Windows.Forms.Button();
            this.rtContreindic = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ModMed = new System.Windows.Forms.Button();
            this.txtnomfamille = new System.Windows.Forms.TextBox();
            this.txtNomMedoc = new System.Windows.Forms.TextBox();
            this.ClearCh = new System.Windows.Forms.Button();
            this.btdelfam = new System.Windows.Forms.Button();
            this.TxtSrcMed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DtgvAllMedocs)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgvAllMedocs
            // 
            this.DtgvAllMedocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgvAllMedocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.id});
            this.DtgvAllMedocs.Location = new System.Drawing.Point(9, 69);
            this.DtgvAllMedocs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtgvAllMedocs.Name = "DtgvAllMedocs";
            this.DtgvAllMedocs.ReadOnly = true;
            this.DtgvAllMedocs.RowHeadersWidth = 51;
            this.DtgvAllMedocs.RowTemplate.Height = 24;
            this.DtgvAllMedocs.Size = new System.Drawing.Size(308, 370);
            this.DtgvAllMedocs.TabIndex = 0;
            this.DtgvAllMedocs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvAllMedocs_CellClick);
            // 
            // Nom
            // 
            this.Nom.HeaderText = "nom";
            this.Nom.MinimumWidth = 6;
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            this.Nom.Width = 350;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // CbFamMedocs
            // 
            this.CbFamMedocs.FormattingEnabled = true;
            this.CbFamMedocs.Location = new System.Drawing.Point(54, 23);
            this.CbFamMedocs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbFamMedocs.Name = "CbFamMedocs";
            this.CbFamMedocs.Size = new System.Drawing.Size(209, 21);
            this.CbFamMedocs.TabIndex = 2;
            this.CbFamMedocs.SelectedIndexChanged += new System.EventHandler(this.CbFamMedocs_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tous les médicaments  de la famille :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 123);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom Medicament";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nom Famille";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Composition";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ajouter Médicament";
            // 
            // AdMed
            // 
            this.AdMed.Location = new System.Drawing.Point(321, 367);
            this.AdMed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdMed.Name = "AdMed";
            this.AdMed.Size = new System.Drawing.Size(159, 19);
            this.AdMed.TabIndex = 15;
            this.AdMed.Text = "Ajouter Medicament";
            this.AdMed.UseVisualStyleBackColor = true;
            this.AdMed.Click += new System.EventHandler(this.AdMed_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(552, 184);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Effets";
            // 
            // rtCompo
            // 
            this.rtCompo.Location = new System.Drawing.Point(321, 200);
            this.rtCompo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtCompo.Name = "rtCompo";
            this.rtCompo.Size = new System.Drawing.Size(160, 145);
            this.rtCompo.TabIndex = 22;
            this.rtCompo.Text = "";
            // 
            // rtEffets
            // 
            this.rtEffets.Location = new System.Drawing.Point(484, 200);
            this.rtEffets.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtEffets.Name = "rtEffets";
            this.rtEffets.Size = new System.Drawing.Size(177, 145);
            this.rtEffets.TabIndex = 23;
            this.rtEffets.Text = "";
            // 
            // DelMed
            // 
            this.DelMed.Location = new System.Drawing.Point(665, 367);
            this.DelMed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DelMed.Name = "DelMed";
            this.DelMed.Size = new System.Drawing.Size(164, 19);
            this.DelMed.TabIndex = 24;
            this.DelMed.Text = "SupprimerMedicament";
            this.DelMed.UseVisualStyleBackColor = true;
            this.DelMed.Click += new System.EventHandler(this.DelMed_Click);
            // 
            // rtContreindic
            // 
            this.rtContreindic.Location = new System.Drawing.Point(665, 200);
            this.rtContreindic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rtContreindic.Name = "rtContreindic";
            this.rtContreindic.Size = new System.Drawing.Size(164, 145);
            this.rtContreindic.TabIndex = 25;
            this.rtContreindic.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(705, 184);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "ContreIndication";
            // 
            // ModMed
            // 
            this.ModMed.Location = new System.Drawing.Point(488, 367);
            this.ModMed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ModMed.Name = "ModMed";
            this.ModMed.Size = new System.Drawing.Size(173, 19);
            this.ModMed.TabIndex = 27;
            this.ModMed.Text = "Modifier Medicament";
            this.ModMed.UseVisualStyleBackColor = true;
            this.ModMed.Click += new System.EventHandler(this.ModMed_Click);
            // 
            // txtnomfamille
            // 
            this.txtnomfamille.Location = new System.Drawing.Point(419, 154);
            this.txtnomfamille.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtnomfamille.Name = "txtnomfamille";
            this.txtnomfamille.Size = new System.Drawing.Size(410, 20);
            this.txtnomfamille.TabIndex = 28;
            // 
            // txtNomMedoc
            // 
            this.txtNomMedoc.Location = new System.Drawing.Point(419, 120);
            this.txtNomMedoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNomMedoc.Name = "txtNomMedoc";
            this.txtNomMedoc.Size = new System.Drawing.Size(410, 20);
            this.txtNomMedoc.TabIndex = 29;
            // 
            // ClearCh
            // 
            this.ClearCh.Location = new System.Drawing.Point(665, 80);
            this.ClearCh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ClearCh.Name = "ClearCh";
            this.ClearCh.Size = new System.Drawing.Size(164, 19);
            this.ClearCh.TabIndex = 30;
            this.ClearCh.Text = "Vider les champs";
            this.ClearCh.UseVisualStyleBackColor = true;
            this.ClearCh.Click += new System.EventHandler(this.ClearCh_Click);
            // 
            // btdelfam
            // 
            this.btdelfam.Location = new System.Drawing.Point(665, 23);
            this.btdelfam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btdelfam.Name = "btdelfam";
            this.btdelfam.Size = new System.Drawing.Size(164, 19);
            this.btdelfam.TabIndex = 31;
            this.btdelfam.Text = "Supprimmer famille";
            this.btdelfam.UseVisualStyleBackColor = true;
            this.btdelfam.Click += new System.EventHandler(this.btdelfam_Click);
            // 
            // TxtSrcMed
            // 
            this.TxtSrcMed.Location = new System.Drawing.Point(484, 23);
            this.TxtSrcMed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtSrcMed.Name = "TxtSrcMed";
            this.TxtSrcMed.Size = new System.Drawing.Size(177, 20);
            this.TxtSrcMed.TabIndex = 32;
            this.TxtSrcMed.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(319, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Chercher medicament par nom";
            // 
            // FormMedicaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 449);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtSrcMed);
            this.Controls.Add(this.btdelfam);
            this.Controls.Add(this.ClearCh);
            this.Controls.Add(this.txtNomMedoc);
            this.Controls.Add(this.txtnomfamille);
            this.Controls.Add(this.ModMed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtContreindic);
            this.Controls.Add(this.DelMed);
            this.Controls.Add(this.rtEffets);
            this.Controls.Add(this.rtCompo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AdMed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbFamMedocs);
            this.Controls.Add(this.DtgvAllMedocs);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMedicaments";
            this.ShowIcon = false;
            this.Text = "Médicaments";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMedicaments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgvAllMedocs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgvAllMedocs;
        private System.Windows.Forms.ComboBox CbFamMedocs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AdMed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtCompo;
        private System.Windows.Forms.RichTextBox rtEffets;
        private System.Windows.Forms.Button DelMed;
        private System.Windows.Forms.RichTextBox rtContreindic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ModMed;
        private System.Windows.Forms.TextBox txtnomfamille;
        private System.Windows.Forms.TextBox txtNomMedoc;
        private System.Windows.Forms.Button ClearCh;
        private System.Windows.Forms.Button btdelfam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.TextBox TxtSrcMed;
        private System.Windows.Forms.Label label7;
    }
}