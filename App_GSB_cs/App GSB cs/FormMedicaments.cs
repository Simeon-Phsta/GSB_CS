using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Medicaments;

namespace App_GSB_cs
{
    public partial class FormMedicaments : Form
    {
        #region outdated
        //Initialisation de la liste des médicaments pour future utilisation ( annullée mais gardé car inutile a supprimmer ) 
        public List<medicaments> ListeMedocs = new List<medicaments>();
        #endregion
        public FormMedicaments()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMedicaments_Load(object sender, EventArgs e)
        {
            //Appel de la function reload qui recharge les données
            reload();
        }
        #region Boutons ajouter supprimmer et modifier

        /// <summary>
        /// Actions au click sur le bouton Ajouter Medicament
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdMed_Click(object sender, EventArgs e)
        {
            //appel de la fonction publique du manager pour ajouter un medicament
            Manager.Manager.InsertMedoc(txtNomMedoc.Text, txtnomfamille.Text, rtCompo.Text, rtEffets.Text, rtContreindic.Text);
            //appel de la fonction Reload
            reload();
        }

        /// <summary>
        /// Actions au click sur le bouton Supprimmer medicament
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelMed_Click(object sender, EventArgs e)
        {
            //appel de la fonction publique du manager pour Supprimmer un medicament
            Manager.Manager.DeleteMedoc(DtgvAllMedocs.Rows[DtgvAllMedocs.SelectedCells[0].RowIndex].Cells[1].Value.ToString());
            //appel de la fonction Reload
            reload();
        }

        /// <summary>
        /// Actions au click sur le bouton Modifier medicament
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ModMed_Click(object sender, EventArgs e)
        {
            //Recuperation de l'id du médicament stocké dans une colone invisible du Dtgv a coté du nom du mécicament
            int idmede = Convert.ToInt32(DtgvAllMedocs.Rows[DtgvAllMedocs.SelectedCells[0].RowIndex].Cells[1].Value.ToString());
            //appel de la fonction publique du manager pour Modifier un medicament
            Manager.Manager.ModifMedoc(idmede.ToString(), txtNomMedoc.Text ,txtnomfamille.Text, rtCompo.Text, rtEffets.Text, rtContreindic.Text);
            reload();
        }

        #endregion
        #region Fonctions du programme

        /// <summary>
        /// Fonction Reload qui permet de recharer toutes les données a partir de la base de données
        /// </summary>
        public void reload()
        {
            //Supression des données actuelles
            DtgvAllMedocs.Rows.Clear();
            //recuperation et ajout des données dans le Dtgv
            foreach (string[] l in Manager.Manager.SelectMedicaments())
            {
                DtgvAllMedocs.Rows.Add(l[0], l[1]);
            }
            //Supression des données actuelles
            CbFamMedocs.Items.Clear();
            CbFamMedocs.Items.Add("Toutes");
            //recuperation et ajout des familles dans la combobox
            foreach (string[] l in Manager.Manager.SelectAllNomFam())
            {
                CbFamMedocs.Items.Add(l[0]);
            }
            CbFamMedocs.SelectedIndex = 0;
            //Supression des données actuelles
            ListeMedocs.Clear();
            //recuperation et ajout des familles dans la liste maintenant outdated
            foreach (string[] line in Manager.Manager.SelectAllFromMedoc())
            {
                ListeMedocs.Add(new medicaments(Convert.ToInt32(line[0]), line[1], Convert.ToInt32(line[2]), line[3], line[4], line[5]));
            }
            //Appel de la fonction ClearChamps
            clearchamps();
            TxtSrcMed.Text = "";
            //ajustement d'un récalcitrant

        }

        /// <summary>
        /// Fonction ClearCHamps remplacant le text de tous les champs par du vide
        /// </summary>
        public void clearchamps()
        {
            txtnomfamille.Text = "";
            txtNomMedoc.Text = "";
            rtCompo.Text = "";
            rtEffets.Text = "";
            rtContreindic.Text = "";
            TxtSrcMed.Text = "";
        }

        /// <summary>
        /// Fonction ClearCHamps remplacant le text de tous les champs par du vide sauf la barre de recherche
        /// </summary>
        public void clearchampsexrs()
        {
            txtnomfamille.Text = "";
            txtNomMedoc.Text = "";
            rtCompo.Text = "";
            rtEffets.Text = "";
            rtContreindic.Text = "";
        }

        #endregion
        #region Composants autres

        /// <summary>
        /// Actions au click sur une des cellules de la liste de médicaments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DtgvAllMedocs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            #region Mise a jour des TextBox avec les informations du médicament selectionné
            List<string[]> result = new List<string[]>();
            try
            {
                var t = (DtgvAllMedocs.Rows[DtgvAllMedocs.SelectedCells[0].RowIndex].Cells[1].Value);
                if (t == null) { return; }
                result = Manager.Manager.SelectMedicamentsFromIdMedoc(t.ToString());
                if (result == null) { return; }
                txtNomMedoc.Text = result[0][0];
                txtnomfamille.Text = result[0][1];
                rtCompo.Text = result[0][2];
                rtEffets.Text = result[0][3];
                rtContreindic.Text = result[0][4];
            }
            catch (Exception er)
            {//"La réf" est le début d'une erreur qui est déclanchée quand on clique dans la ligne vide en bas qui étais présente lors des tests
                if (er.Message.StartsWith("La réf")) { } else { MessageBox.Show(er.Message); }
            }
            #endregion
        }

        /// <summary>
        /// Actions au click du bouton Vider les champs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearCh_Click(object sender, EventArgs e)
        {//Appel de la fonction ClearChamps
            clearchamps();
        }

        /// <summary>
        /// Bouton de suppression d'une famille quand elle est vide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btdelfam_Click(object sender, EventArgs e)
        {
            Manager.Manager.DeleteFam(CbFamMedocs.Text);
            reload();
        }

        /// <summary>
        /// Recherche des médicaments grace a un champ texte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var temp = CbFamMedocs.SelectedIndex;
            if (TxtSrcMed.Text != "")
            {
                CbFamMedocs.Text = "Toutes";
                TxtSrcMed.Select(TxtSrcMed.Text.Length, TxtSrcMed.Text.Length);
                //Recupération des médicaments dont le nom commence par XX
                List<string[]> Liste = Manager.Manager.SelectMedicamentsStartingWith(TxtSrcMed.Text);
                DtgvAllMedocs.Rows.Clear();
                if (Liste == null)
                {
                    return;
                }
                //Remplissage du Dtgv en conséquence
                foreach (string[] l in Liste)
                {
                    DtgvAllMedocs.Rows.Add(l[0], l[1]);
                }
            }
            else
            { reload(); CbFamMedocs.SelectedIndex = temp; }
        }

        /// <summary>
        /// Recherche des médicaments par famille
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CbFamMedocs_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearchamps();
            //Recuperation des médicaments d'une famille spécifique
            if (CbFamMedocs.Text != "Toutes")
            {
                DtgvAllMedocs.Rows.Clear();
                foreach (string[] temp in Manager.Manager.SelectMedicamentsFromFamille(CbFamMedocs.Text))
                {
                    DtgvAllMedocs.Rows.Add(temp[1], temp[0]);
                }

            }
            else
            {//recupération de tous les médicaments
                DtgvAllMedocs.Rows.Clear();
                foreach (string[] temp in Manager.Manager.SelectAllFromMedoc())
                {
                    DtgvAllMedocs.Rows.Add(temp[1], temp[0]);
                }

            }
            
        }
        #endregion
    }
}
