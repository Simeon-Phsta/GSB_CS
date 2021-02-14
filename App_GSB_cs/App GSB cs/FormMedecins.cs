using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pass;
using Medecins;
namespace App_GSB_cs
{
    // dans le code j'ai appelé praticiens, médecins ! 


    public partial class FormMedecins : Form
    {


        #region Initialisation
        //Initialisation des variables pour le formulaire
        public List<medecin> ListeMedecins = new List<medecin>();
        public int lastIdMedecin;




        //Chargement du formulaire
        public FormMedecins()
        {

            InitializeComponent();

        }
        //Chargement des données 
        private void FormMedecins_Load(object sender, EventArgs e)
        {
            reload();
        }

        #endregion


        #region Déclaration des fonctions
        //Définition de la fonction reload() qui permet de vider les champs et de remettre les données pour les composants
        public void reload()
        {
            //vide le datagridview des médecins
            dtgvAllMedics.Rows.Clear();

            //Recharge le datagriedview des medecins
            foreach (string[] l in Manager.Manager.SelectMedecins())
            {
                dtgvAllMedics.Rows.Add(l);
            }


            //vide la cbbox des villes
            cbbxVille.Items.Clear();

            //Recharge la cbbox villes
            foreach (string[] l in Villes.villes)
            {
                cbbxVille.Items.Add(l[0] + " - " + l[1]);
            }


            //idem que pour les villes, ici pour les spécialistes
            cbbxSpecialite.Items.Clear();

            foreach (string[] l in Manager.Manager.SelectSpecialites())
            {
                cbbxSpecialite.Items.Add(l[0]);
            }

            //vide la cbbox des motifs de rapports
            cbbxMotif.Items.Clear();

            //Recharge la cbbox motifs
            foreach (string[] l in Manager.Manager.SelectMotif())
            {
                cbbxMotif.Items.Add(l[0]);
            }

            //Vide les champs des txtboxs
            clearChampsMedecin();
            clearChampsRapport();
        }

        //Definition de la fonction qui vide les champs des txtboxs. 
        public void clearChampsMedecin()
        {
            txtBxNom.Text = "";
            txtBxPrenom.Text = "";
            txtBxAdresse.Text = "";
            txtBxTelephone.Text = "";
            txtBxIdMedecin.Text = "";
            cbbxSpecialite.SelectedIndex = 0;
            cbbxVille.SelectedIndex = 0;


        }

        //Vide les champs des textbox de rapport
        public void clearChampsRapport()
        {
            //Vide le dtgv des rapports
            dtgvRapport.Rows.Clear();
            cbbxMotif.SelectedIndex = 0;
            txtBxIdRapport.Text = "";
            //dtp.Value;
            txtBxRapport.Text = "";
        }
        #endregion


        #region Evènements            

        #region Zone Medecin

        #region Selection Medecin
        //Lors du double clic de l'utilisateur sur une cellule du dtdv Medecins
        private void dtgvAllMedics_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clearChampsRapport();


            List<string[]> result = new List<string[]>();
            //On prends les informations de la ligne seléctionnée dans les cbbox et cbtxt
            result = Manager.Manager.SelectMedecin(Convert.ToInt32(dtgvAllMedics.Rows[e.RowIndex].Cells[7].Value));
            txtBxIdMedecin.Text = result[0][7];
            txtBxNom.Text = result[0][0];
            txtBxPrenom.Text = result[0][1];
            cbbxVille.Text = result[0][3] + " - " + result[0][4];
            txtBxAdresse.Text = result[0][5];
            txtBxTelephone.Text = result[0][6];
            cbbxSpecialite.Text = result[0][2];


            //On essaye de prendre les rapports liés au medecin sélectionné

                List<string[]> temp = Manager.Manager.SelectRapports(Convert.ToInt32(result[0][7]));
                if (temp != null)
                {
                    foreach (string[] l in temp)
                    {
                        if (l != null)
                        {
                            dtgvRapport.Rows.Add(l);
                        }
                    }
                }
        }
        #endregion

        #region Bouton Clear
        //Au clique sur le btn clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            //On vide les champs (cf aux fonctions vu en haut)
            clearChampsMedecin();
            clearChampsRapport();
            MessageBox.Show("Vous avez vidé les champs.");
        }
        #endregion

        #region Bouton Supprimer Medecin
        //Au clique sur le btn supprimer
        private void btnSupprimerMedecin_Click(object sender, EventArgs e)
        {
            
            //Tentative de suppression du medecin et de ses rapports selectionner après vérification 
            //try
            //{

                DialogResult temp = MessageBox.Show("Voulez vous supprimer le praticien ? \r Cela supprime les rapports qui lui sont " +
                    "associés ! (", "Attention", MessageBoxButtons.YesNo);
                if (temp == DialogResult.Yes)
                {
                    List<string[]> resultats = Manager.Manager.SelectIdRapportsPourMedecin(Convert.ToInt32(txtBxIdMedecin.Text));

                    foreach( string[] resultat in resultats)
                    {
                    Manager.Manager.DeleteRapport(Convert.ToInt32(resultat[0]));
                    }

                    Manager.Manager.DeleteMedecin(Convert.ToInt32(txtBxIdMedecin.Text));
                    //Rechargement des données
                    reload();
                        MessageBox.Show("Vous avez supprimé le ou la praticien(ne).", "Suppression");
                }
            //}
            //catch
            //{
            //    MessageBox.Show("Vous n'avez pas pu supprimé le ou la praticien(ne). Contactez l'administrateur.", "Erreur");
            //}
        }
        #endregion

        #region Bouton Ajouter Medecin
        //Au clique du btn Ajouter
        private void btnAjouterMedecin_Click(object sender, EventArgs e)
        {
            //On prends les données des différents cbbox et cbtxt
            string[] temp = cbbxVille.Text.Split('-');
            string cp = temp[1].Substring(1);
            string ville = temp[0];
            ville = ville.Substring(0, ville.Length - 1);
            //On envoie la requête 
            Manager.Manager.InsertMedecin(txtBxNom.Text, txtBxPrenom.Text, txtBxAdresse.Text, Manager.Manager.SelectIdVille(ville, cp)[0][0], txtBxTelephone.Text, Manager.Manager.SelectIdSpecialiste(cbbxSpecialite.Text)[0][0]);
            //On recharge le tout
            reload();
            MessageBox.Show("Vous avez ajouté un ou une praticien(ne).");
        }
        #endregion

        #region Bonton Modifier Medecin
        //Au clique du btn Modifier
        private void btnModifierMedecin_Click(object sender, EventArgs e)
        {
            //On prends les données des différents cbbox et cbtxt puis on envoie la requête
            string[] temp = cbbxVille.Text.Split('-');
            string cp = temp[1].Substring(1);
            string ville = temp[0];
            ville = ville.Substring(0, ville.Length - 1);
            Manager.Manager.ModifMedecin(txtBxNom.Text, txtBxPrenom.Text, txtBxAdresse.Text, Manager.Manager.SelectIdVille(ville, cp)[0][0], txtBxTelephone.Text, Manager.Manager.SelectIdSpecialiste(cbbxSpecialite.Text)[0][0], Convert.ToInt32(txtBxIdMedecin.Text));
            //On recharge le tout 
            reload();
            MessageBox.Show("Vous avez modifié le ou la praticien(ne)");
        }
        #endregion

        #endregion

        #region Zone Rapport
        #region Selection du rapport
        //Lors du clique de l'utilisateur sur une cellule d'un rapport dans le dtgv
        private void dtgvRapport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string[]> result = new List<string[]>();
            
            // Si la cellule est vide, on affiche le message d'erreur
            if (dtgvRapport.Rows[e.RowIndex].Cells[0].Value == null)
            {
                MessageBox.Show("La ligne est vide.", "Impossible");
            }
            else
            {

                //On affiche un message box avec le libelle du rapport et on donne les données aux cbbox
                result = Manager.Manager.SelectBilanRapport(Convert.ToInt32(dtgvRapport.Rows[e.RowIndex].Cells[0].Value)); 
                MessageBox.Show(result[0][0]);
                   
                try
                {
                    result = Manager.Manager.SelectRapport(Convert.ToInt32(dtgvRapport.Rows[e.RowIndex].Cells[0].Value.ToString()));
                    txtBxIdRapport.Text = result[0][0];//id
                    dtp.Value = Convert.ToDateTime( result[0][1]);//Date
                    cbbxMotif.Text = result[0][2];//motif
                    txtBxRapport.Text = result[0][3];//bilan

                }
                //Sinon on affiche une erreur
                catch
                {
                    MessageBox.Show("Cliquez sur la case vide en début de ligne pour sélectionner un praticien", "Erreur");
                }
            }




        }
        #endregion

        #region Bouton Modifier Rapport
        //Au clique sur le bouton Modifier de la section rapport
        private void btnModifierRapport_Click(object sender, EventArgs e)
        {
            //Vérification d'un id de disponible
            if (txtBxIdRapport.Text == null)
            {
                MessageBox.Show("Vous ne pouvez pas créer de rapport ici.\rVous devez vous rendre dans la partie Bilan visite.");
            }
            //Si c'est bon, on prends les données dans l'interface.
            else
            {
                Manager.Manager.UpdateRapport(Convert.ToInt32(txtBxIdRapport.Text), dtp.Text, cbbxMotif.Text, txtBxRapport.Text);
                //On recharge le tout 
                reload();
                MessageBox.Show("Vous avez modifié le rapport.");
            }
            
        }
        #endregion

        #region Bouton Supprimer Rapport
        //Au clique du bouton supprimer dans la zone rapport
        private void btnSupprimerRapport_Click(object sender, EventArgs e)
        {
            //Après confirmation de l'utilisateur, on supprime le rapport
            DialogResult temp = MessageBox.Show("Voulez vous supprimer ce rapport  ?", "Attention", MessageBoxButtons.YesNo);
            if (temp == DialogResult.Yes)
            {

                Manager.Manager.DeleteRapport(Convert.ToInt32(txtBxIdRapport.Text));
                //Rechargement des données
                reload();
                MessageBox.Show("Vous avez supprimé le rapport et ses échantillions.");
            }
        }





        #endregion

        #endregion

        #endregion

       
    }
}
