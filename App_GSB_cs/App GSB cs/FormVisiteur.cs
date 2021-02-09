using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_GSB_cs
{
    public partial class FormVisiteur : Form
    {
        public FormVisiteur()
        {
            InitializeComponent();
        }

        #region procédure clear()
        private void clear()
        {
            v_txbNomVis.Clear();
            v_txbPrenomVis.Clear();
            v_txbAdresse.Clear();
            v_cbxVille.Text = "";
            v_dtpEmbauche.Refresh();
            v_txbLogin.Clear();
            v_txbMdp.Clear();
        }
        #endregion

        #region FormVisiteur_Load()
        private void FormVisiteur_Load(object sender, EventArgs e)
        {
            //Afficher contenu dans la comboBox Ville
            v_cbxVille.Items.Clear();
            foreach (string[] ville in Villes.villes)
            {
                v_cbxVille.Items.Add(ville[0] + " " + ville[1]);
            }
        }
        #endregion

        #region bouton annuler
        //bouton annuler qui vide toutes les infos
        private void v_btnAnnuler_Click_1(object sender, EventArgs e)
        {
            clear();

            MessageBox.Show("Saisie annulée.", "Information");
        }
        #endregion

        #region bouton valider
        //Valider le formulaire
        private void v_btnValider_Click_1(object sender, EventArgs e)
        {
            try
            {
                string ville = v_cbxVille.Text; //on récupère la ville
                string[] temp = ville.Split(' '); //on sépare ville et cp
                string nomVille = temp[0]; //VILLE RECUPEREE
                string CP = temp[1]; //CP RECUPERE
                string nom = v_txbNomVis.Text; //NOM RECUPERER
                string prenom = v_txbPrenomVis.Text; //PRENOM RECUPERER
                string adresse = v_txbAdresse.Text; //ADRESSE RECUPEREE
                string date = v_dtpEmbauche.Text; //DATE RECUPEREE
                string login = v_txbLogin.Text; //LOGIN RECUPERE
                string mdp = v_txbMdp.Text; //MDP RECUPERE
                string V = Manager.Manager.SelectIdVille(nomVille)[0][0]; // ID ville recupéré

                //Appel de la fonction pour ajouter l'utilisateur
                Manager.Manager.InsertVisiteur(nom, prenom, adresse, V, login, mdp, date, CP);

                //Affichage d'un message
                MessageBox.Show("Le visiteur a bien été ajouté.", "Information");

                //mise à 0 du form
                clear();
            }
            catch
            {
                MessageBox.Show("TOUS LES CHAMPS DOIVENT ETRE RENSEIGNES.", "ATTENTION");
            }
        }
        #endregion
        
        #region bouton modifier
        private void v_btnModifier_Click(object sender, EventArgs e)
        {
            //appel du formulaire pour mofier ou supprimer un visiteur
            FormModifierVisiteur frmMV = new FormModifierVisiteur(); //on instancie le form
            frmMV.Show();
        }
        #endregion
    }
}
