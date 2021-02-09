﻿using System;
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

            //Recharge la cbbox
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
            
            //Vide les champs des txtboxs
            clearchamps();
        }

        //Definition de la fonction qui vide les champs des txtboxs. 
        public void clearchamps()
        {
            txtBxNom.Text = "";
            txtBxPrenom.Text = "";
            txtBxAdresse.Text = "";
            txtBxTelephone.Text = "";
            cbbxSpecialite.SelectedIndex = 0;
            cbbxVille.SelectedIndex = 0;

        }
        #endregion


        #region Evènements            

        #region Selection Medecin
        //Lors du clic de l'utilisateur sur une cellule du dtdv Medecins
        private void dtgvAllMedics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string[]> result = new List<string[]>();
            //On essaye de prendre les informations de la ligne seléctionnée dans les cbbox et cbtxt
            try
            {
                result = Manager.Manager.SelectMedecin(dtgvAllMedics.SelectedCells[0].Value.ToString(), dtgvAllMedics.SelectedCells[1].Value.ToString());
                txtBxNom.Text = result[0][0];
                txtBxPrenom.Text = result[0][1];
                cbbxVille.Text = result[0][3] + " - " + result[0][4];
                txtBxAdresse.Text = result[0][5];
                txtBxTelephone.Text = result[0][6];
                cbbxSpecialite.Text = result[0][2];
                lastIdMedecin = Convert.ToInt32(result[0][7]);

            }
            //Sinon on affiche une erreur
            catch 
            {
                MessageBox.Show("Cliquez sur la case vide en début de ligne pour sélectionner un praticien", "Erreur");
            }

            //On clean le dtgv des rapports 
            dtgvRapport.Rows.Clear();
            //On essaye de prendre les rapports liés au medecin sélectionné
            try
            {
                List<string[]> temp = Manager.Manager.SelectRapports(txtBxNom.Text, txtBxPrenom.Text);
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
            //Sinon on affiche l'erreur
            catch(Exception err)
            {
                MessageBox.Show(err.Message); 
            }         
        }
        #endregion

        #region Selection du rapport
        //Lors du clique de l'utilisateur sur une cellule d'un rapport dans le dtgv
        private void dtgvRapport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {       
                //On affiche un message box avec le libelle du rapport
                foreach (string[] l in Manager.Manager.SelectBilanRapport(dtgvRapport.SelectedCells[0].Value.ToString()))
                {
                    MessageBox.Show(l[0]);
                }
            }
            catch 
            {
                MessageBox.Show("Cliquez sur la première case vide en début de ligne", "erreur");
            }
            
            
        }
        #endregion

        #region Bouton Clear
        //Au clique sur le btn clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            //On vide les champs (cf à la fonction vu en haut)
            clearchamps();
        }
        #endregion

        #region Bouton Supprimer Medecin
        //Au clique sur le btn supprimer
        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            //Tentative de suppression du medecin selectionner après vérification 
            try
            {
                DialogResult temp = MessageBox.Show("Voulez vous supprimer le praticien  ?", "Quitter", MessageBoxButtons.YesNo);
                if (temp == DialogResult.Yes)
                {
                    
                    Manager.Manager.DeleteMedecin(txtBxNom.Text, txtBxPrenom.Text);
                    //Rechargement des données
                    reload();
                }
            }
            catch
            {
                MessageBox.Show("Vous ne pouvez pas supprimer un medecin qui a des rapports", "Erreur");
            }
            
            
        }
        #endregion

        #region Bouton Ajouter Medecin
        //Au clique du btn Ajouter
        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            //On prends les données des différents cbbox et cbtxt
            string[] temp = cbbxVille.Text.Split('-');
            string cp = temp[1].Substring(1);
            string ville = temp[0];
            ville = ville.Substring(0, ville.Length-1);
            //On envoie la requête 
            Manager.Manager.InsertMedecin(txtBxNom.Text, txtBxPrenom.Text, txtBxAdresse.Text, Manager.Manager.SelectIdVille(ville,cp)[0][0], txtBxTelephone.Text, Manager.Manager.SelectIdSpecialiste(cbbxSpecialite.Text)[0][0]);
            //On recharge le tout
            reload();
        }
        #endregion

        #region Bonton Modifier Medecin
        //Au clique du btn Modifier
        private void btnModifier_Click(object sender, EventArgs e)
        {
            //On prends les données des différents cbbox et cbtxt puis on envoie la requête
            string[] temp = cbbxVille.Text.Split('-');
            string cp = temp[1].Substring(1);
            string ville = temp[0];
            ville = ville.Substring(0, ville.Length - 1);
            Manager.Manager.ModifMedecin(txtBxNom.Text, txtBxPrenom.Text, txtBxAdresse.Text, Manager.Manager.SelectIdVille(ville, cp)[0][0], txtBxTelephone.Text, Manager.Manager.SelectIdSpecialiste(cbbxSpecialite.Text)[0][0], lastIdMedecin);
            //On recharge le tout 
            reload();
        }
        #endregion

        #endregion
    }
}