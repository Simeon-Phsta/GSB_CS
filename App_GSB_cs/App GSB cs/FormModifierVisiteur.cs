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
    public partial class FormModifierVisiteur : Form
    {
        public FormModifierVisiteur()
        {
            InitializeComponent();
        }

        #region FormModifierVisiteur_Load()
        //on affiche la liste des visiteurs dans le datagrid
        private void FormModifierVisiteur_Load(object sender, EventArgs e)
        {
            load(); //on charge le datagrid

            //on cache le texbox qui sert à stocker l'id du visiteur pour faire des modification ou suppression 
            mv_txb_idVisiteur.Hide();

            //Afficher contenu dans la comboBox Ville
            mv_cbxVille.Items.Clear();
            foreach (string[] ville in Villes.villes)
            {
                mv_cbxVille.Items.Add(ville[0] + " " + ville[1]);
            }
        }
        #endregion

        #region procédure load()
        //fonction pour remettre à jour la datagrid
        private void load()
        {
            mv_dgw.Rows.Clear();

            foreach (string[] v in Manager.Manager.SelectVisiteurS())
            {
                mv_dgw.Rows.Add(v);
            }
        }
        #endregion

        #region bouton supprimer
        private void mv_btnSupprimer_Click(object sender, EventArgs e) //pour supprimer un visiteur
        {
            string nom = mv_txbNomVis.Text; //Nom récupéré
            string prenom = mv_txbPrenomVis.Text; //Prénom récupéré
            int id = Convert.ToInt16(mv_txb_idVisiteur.Text); //id récupéré
            //Appelle de la fonction pour supprimer
            Manager.Manager.DeleteVisiteur(id, nom, prenom);
            //Affichage d'un message
            MessageBox.Show("Le visiteur a bien été supprimé.", "Information");
            clear(); //on nettoie le form

        }
        #endregion 

        #region bouton modifier
        private void mv_btnModifier_Click_1(object sender, EventArgs e) //pour modifier un visteur
        {
            string ville = mv_cbxVille.Text;
            string[] temp = ville.Split(' ');
            string nomVille = temp[0]; //VILLE RECUPEREE
            string CP = temp[1]; //CP RECUPERE
            string nom = mv_txbNomVis.Text; //NOM RECUPERE
            string prenom = mv_txbPrenomVis.Text; //PRENOM RECUPERE
            string adresse = mv_txbAdresse.Text;
            string date = mv_tbxDate.Text;
            string[] tempD = date.Split(' ');
            string laDate = tempD[0];//DATE RECUPEREE
            int id = Convert.ToInt16(mv_txb_idVisiteur.Text); //ID RECUPERE

            //Appelle de la fonction pour modifier
            Manager.Manager.UpdateVisteur(nom, prenom, adresse, laDate, Manager.Manager.SelectIdVille(nomVille)[0][0], CP, id);

            //Affichage d'un message
            MessageBox.Show("Le visiteur a bien été modifié.", "Information");

            clear(); //on nettoie le form

        }
        #endregion

        #region procédure clear()
        private void clear() //On vide toutes les infos + maj dtg
        {
            mv_txbNomVis.Clear();
            mv_txbPrenomVis.Clear();
            mv_txbAdresse.Clear();
            mv_cbxVille.Text = "";
            mv_txb_idVisiteur.Clear();
            mv_tbxDate.Clear();
            //Mise à jour du datagrid
            load();
        }
        #endregion

        #region sélectionner tableau en double clic
        private void mv_dgw_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mv_txb_idVisiteur.Text = mv_dgw.Rows[e.RowIndex].Cells[0].Value.ToString();//on récupère id
            mv_txbNomVis.Text = mv_dgw.Rows[e.RowIndex].Cells[1].Value.ToString();//on récupère le nom
            mv_txbPrenomVis.Text = mv_dgw.Rows[e.RowIndex].Cells[2].Value.ToString();//on récèpre le prénom
            string date = mv_dgw.Rows[e.RowIndex].Cells[5].Value.ToString();//on récupère la date
            string[] laDate = date.Split(' '); //on enlève le 00:00:00 à la fin
            mv_tbxDate.Text = Convert.ToString(laDate[0]);
            mv_txbAdresse.Text = mv_dgw.Rows[e.RowIndex].Cells[3].Value.ToString();//on récuèpre l'adresse

            List<string[]> ville = new List<string[]>(); //on change l'id de la ville pour avoir "NomVille CodePostal"
            ville = Manager.Manager.SelectVilleCDP(mv_dgw.Rows[e.RowIndex].Cells[4].Value.ToString()); //on récupère la ville avec son cdp
            mv_cbxVille.Text = ville[0][0] + " " + ville[0][1];
        }
        #endregion
    }
}
