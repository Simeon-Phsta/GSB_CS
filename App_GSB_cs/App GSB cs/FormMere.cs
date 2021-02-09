using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manager;
namespace App_GSB_cs
{
    public partial class FormMere : Form
    {
        /// <summary>
        /// Initialisation des formulaires
        /// </summary>
        FormVisiteur frmvis = new FormVisiteur();
        FormMedicaments frmmedoc = new FormMedicaments();
        FormMedecins frmmedic = new FormMedecins();
        FormBilanVisite frombilvis = new FormBilanVisite();

       //Définition des formulaires filles
        public FormMere()
        {
            Villes.villes = Manager.Manager.SelectVillesVisiteurs();
            InitializeComponent();
            frombilvis.MdiParent = this;
            frmvis.MdiParent = this;
            frmmedoc.MdiParent = this;
            frmmedic.MdiParent = this;
        }

        //affiche du formulaire visiteur
        private void visiteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadforms();
            frmvis.Show(); 
            frmmedoc.Hide();
            frmmedic.Hide();
            frombilvis.Hide();
        }

        //affiche du formulaire médicaments
        private void medicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadforms();
            frmvis.Hide();
            frmmedoc.Show();
            frombilvis.Hide();
            frmmedic.Hide();
        }

        //affiche du formulaire praticiens
        private void praticiensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadforms();
            frmvis.Hide();
            frmmedoc.Hide();
            frombilvis.Hide();
            frmmedic.Show();
        }

        //Raffraichissment des formulaires
        public void loadforms()
        {
            frmvis = new FormVisiteur();
            frmmedoc = new FormMedicaments();
            frmmedic = new FormMedecins();
            frombilvis = new FormBilanVisite();
            frombilvis.MdiParent = this;
            frmvis.MdiParent = this;
            frmmedoc.MdiParent = this;
            frmmedic.MdiParent = this;
        }

        //affiche du formulaire bilan visite
        private void bilanVisiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadforms();
            frmvis.Hide();
            frmmedoc.Hide();
            frmmedic.Hide();
            frombilvis.Show();
            frombilvis.Focus();

        }

        //Chargement des villes
        private void chargerToutesLesVilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Villes.villes = Manager.Manager.SelectVilles();
            MessageBox.Show("Toutes les villes sont chargées.");
        }

        //Double vérification de la fermeture de l'application
        private void FormMere_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult temp = MessageBox.Show("Voulez vous quitter l'application ?", "Quitter", MessageBoxButtons.YesNo);
            if (temp == DialogResult.Yes) { e.Cancel = false; }
            else { e.Cancel = true; }
        }
    }
}
