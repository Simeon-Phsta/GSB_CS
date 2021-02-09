namespace App_GSB_cs
{
    partial class FormMere
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.visiteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilanVisiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.praticiensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicamentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerToutesLesVilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visiteursToolStripMenuItem,
            this.bilanVisiteToolStripMenuItem,
            this.praticiensToolStripMenuItem,
            this.medicamentsToolStripMenuItem,
            this.chargerToutesLesVilesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(875, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // visiteursToolStripMenuItem
            // 
            this.visiteursToolStripMenuItem.Name = "visiteursToolStripMenuItem";
            this.visiteursToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.visiteursToolStripMenuItem.Text = "Visiteurs";
            this.visiteursToolStripMenuItem.Click += new System.EventHandler(this.visiteursToolStripMenuItem_Click);
            // 
            // bilanVisiteToolStripMenuItem
            // 
            this.bilanVisiteToolStripMenuItem.Name = "bilanVisiteToolStripMenuItem";
            this.bilanVisiteToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.bilanVisiteToolStripMenuItem.Text = "Bilan Visite";
            this.bilanVisiteToolStripMenuItem.Click += new System.EventHandler(this.bilanVisiteToolStripMenuItem_Click);
            // 
            // praticiensToolStripMenuItem
            // 
            this.praticiensToolStripMenuItem.Name = "praticiensToolStripMenuItem";
            this.praticiensToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.praticiensToolStripMenuItem.Text = "Praticiens";
            this.praticiensToolStripMenuItem.Click += new System.EventHandler(this.praticiensToolStripMenuItem_Click);
            // 
            // medicamentsToolStripMenuItem
            // 
            this.medicamentsToolStripMenuItem.Name = "medicamentsToolStripMenuItem";
            this.medicamentsToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.medicamentsToolStripMenuItem.Text = "Medicaments";
            this.medicamentsToolStripMenuItem.Click += new System.EventHandler(this.medicamentsToolStripMenuItem_Click);
            // 
            // chargerToutesLesVilesToolStripMenuItem
            // 
            this.chargerToutesLesVilesToolStripMenuItem.Name = "chargerToutesLesVilesToolStripMenuItem";
            this.chargerToutesLesVilesToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.chargerToutesLesVilesToolStripMenuItem.Text = "Charger toutes les viles";
            this.chargerToutesLesVilesToolStripMenuItem.Click += new System.EventHandler(this.chargerToutesLesVilesToolStripMenuItem_Click);
            // 
            // FormMere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::App_GSB_cs.Properties.Resources.gsb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(875, 449);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMere";
            this.Text = "Application GSB";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMere_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem medicamentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem praticiensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visiteursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilanVisiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerToutesLesVilesToolStripMenuItem;
    }
}



