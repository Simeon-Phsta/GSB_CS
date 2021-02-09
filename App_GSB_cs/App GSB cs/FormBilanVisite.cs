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
    public partial class FormBilanVisite : Form
    {
        public FormBilanVisite()
        {
            InitializeComponent();
        }

        #region FormBilanVisite_Load()
        private void FormBilanVisite_Load(object sender, EventArgs e)
        {
            //on cache le CR des échantillons donnés
            //car les échantillons ne sont pas obligatoire
            bv_txb1Quantite.Hide();
            bv_txb2Quantite.Hide();
            bv_txb3Quantite.Hide();
            bv_txb4Quantite.Hide();
            bv_cbx1NomEchantillon.Hide();
            bv_cbx2NomEchantillon.Hide();
            bv_cbx3NomEchantillon.Hide();
            bv_cbx4NomEchantillon.Hide();
            label10.Hide();
            label9.Hide();
            groupBox4.Hide();

            //liste déroulante nom praticiens
            bv_cbxNomMed.Items.Clear();
            foreach (string[] med in Manager.Manager.SelectPraticiens())
            {
                bv_cbxNomMed.Items.Add(med[0] + " " + med[1] + " - " + med[2]);
            }

            //liste déroulante nom visiteurs
            bv_cbxNomVis.Items.Clear();
            foreach (string[] vis in Manager.Manager.SelectVisiteurs())
            {
                bv_cbxNomVis.Items.Add(vis[0] + " " + vis[1]);
            }

            //liste déroulante échantillons
            bv_cbx1NomEchantillon.Items.Clear(); //1
            foreach (string[] ech in Manager.Manager.SelectMedicaments())
            {
                bv_cbx1NomEchantillon.Items.Add(ech[0]);
            }

            bv_cbx2NomEchantillon.Items.Clear(); //2
            foreach (string[] ech in Manager.Manager.SelectMedicaments())
            {
                bv_cbx2NomEchantillon.Items.Add(ech[0]);
            }

            bv_cbx3NomEchantillon.Items.Clear(); //3
            foreach (string[] ech in Manager.Manager.SelectMedicaments())
            {
                bv_cbx3NomEchantillon.Items.Add(ech[0]);
            }

            bv_cbx4NomEchantillon.Items.Clear(); //4
            foreach (string[] ech in Manager.Manager.SelectMedicaments())
            {
                bv_cbx4NomEchantillon.Items.Add(ech[0]);
            }

            //liste déroulante motifs visite
            // bv_cbxMotifVis.Items.Clear();
            //foreach(string[] motif in Manager.Manager.SelectMotifs())
            // {
            //     bv_cbxMotifVis.Items.Add(motif[0]);
            // }
        }
        #endregion

        #region radio bouton échantillon
        //affichage du CR des échantillons donnés
        //car le secrétaire a coché oui
        private void bv_rbtnEchantillons_CheckedChanged_1(object sender, EventArgs e)
        {
            bv_txb1Quantite.Show();
            bv_txb2Quantite.Show();
            bv_txb3Quantite.Show();
            bv_txb4Quantite.Show();
            bv_cbx1NomEchantillon.Show();
            bv_cbx2NomEchantillon.Show();
            bv_cbx3NomEchantillon.Show();
            bv_cbx4NomEchantillon.Show();
            label10.Show();
            label9.Show();
            groupBox4.Show();
        }
        #endregion

        #region bouton annuler
        //bouton annuler qui vide toutes les infos
        private void bv_btnAnnuler_Click_1(object sender, EventArgs e)
        {
            clear();

            MessageBox.Show("Saisie annulée.", "Information");
        }
        #endregion

        #region procédure clear()
        public void clear()
        {
            bv_cbxNomMed.Text = "";
            bv_cbxNomVis.Text = "";
            bv_cbxMotifVis.Text = "";
            bv_txbImpact.Clear();
            bv_txb1Quantite.Clear();
            bv_txb2Quantite.Clear();
            bv_txb3Quantite.Clear();
            bv_txb4Quantite.Clear();
            bv_cbx1NomEchantillon.Text = "";
            bv_cbx2NomEchantillon.Text = "";
            bv_cbx3NomEchantillon.Text = "";
            bv_cbx4NomEchantillon.Text = "";
        }
        #endregion

        #region bouton ajouter un nouveau médecin
        //Ajout d'un nouveau praticien
        private void bv_btnAjoutMed_Click_1(object sender, EventArgs e)
        {
            //on instancie un formMedecin
            FormMedecins formM = new FormMedecins();
            formM.Show(); //on appelle le form inctancié
        }
        #endregion

        #region bouton valider bilan
        private void bv_btnValider_Click(object sender, EventArgs e)
        {
            //date du jour
            DateTime now = DateTime.Now;
            //conversion de la date du formulaire
            string uneDate = Convert.ToDateTime(bv_dtpDateVis.Text).ToShortDateString();
            uneDate = uneDate.Replace('/', '-');
            uneDate = uneDate[6].ToString() + uneDate[7].ToString() + uneDate[8].ToString() + uneDate[9].ToString() + uneDate[2].ToString() + uneDate[3].ToString() + uneDate[4].ToString() + uneDate[2].ToString() + uneDate[0].ToString() + uneDate[1].ToString();


            //on regarde si le formulaire est remplie
            if (bv_cbxNomMed.Text == "" && bv_cbxNomVis.Text == "" && bv_cbxMotifVis.Text == "" && bv_txbImpact.Text == "")
            {
                //on affiche un message à l'utilisateur
                MessageBox.Show("Le formulaire est vide !", "ATTENTION");
            }
            else
            { 
                //on regarde que le praticien et le visiteur ont été sélectionnés
                if (bv_cbxNomMed.Text == "" || bv_cbxNomVis.Text == "")
                {
                    //on affiche un message à l'utilisateur
                    MessageBox.Show("Choississez un praticien et un visiteur !", "ATTENTION");
                }
                else
                {
                    //on regarde si la date n'est pas supérieur à celle d'aujourd'hui
                    if (now < Convert.ToDateTime(uneDate))
                    {
                        //on affiche un message à l'utilisateur
                        MessageBox.Show("La date ne peut pas être supérieur à celle d'aujourd'hui !", "ATTENTION");
                    }
                    else
                    {
                        //on regarde si l'impact est le motif sont vide
                        if (bv_txbImpact.Text == "" || bv_cbxMotifVis.Text == "")
                        {
                            //on affiche un message à l'utilisateur
                            MessageBox.Show("Indiquez le motif de la visite et l'impact qu'a eu la visite !", "ATTENTION");
                        }
                        else
                        {
                            //si tout se passe bien
                            //try
                            //{
                                string praticien = bv_cbxNomMed.Text; //on récupère le nom du praticien
                                praticien = praticien.Substring(0, praticien.IndexOf('-') - 1); //on sépare nom prenom du praticen avec sa région
                                string[] temp1 = praticien.Split(' '); //on sépare le nom et le prénom
                                string nomPraticien = temp1[0]; //nom praticien
                                string prenomPraticien = temp1[1]; //prenom praticien

                                string visiteur = bv_cbxNomVis.Text; //on récupère le nom du visiteur
                                string[] temp2 = visiteur.Split(' '); // on sépare le nom et le prenom
                                string nomVisiteur = temp2[0]; //nom visiteur
                                string prenomVisiteur = temp2[1]; //prenom visiteur

                                string date = bv_dtpDateVis.Text; //date visite

                                string motif = bv_cbxMotifVis.Text; // motif

                                string impact = bv_txbImpact.Text; //impact de la visite

                                //on recupere id du praticien
                                List<string[]> idP = new List<string[]>();
                                idP = Manager.Manager.SelectIDpraticien(nomPraticien, prenomPraticien);

                                //on recupere id du visiteur
                                List<string[]> idV = new List<string[]>();
                                idV = Manager.Manager.SelectIDvisiteur(nomVisiteur, prenomVisiteur);

                                Manager.Manager.AddBilanVisite(idP[0][0], idV[0][0], date, motif, impact); //on ajoute le bilan dans la table rapport

                                //on affiche un message pour l'utilisateur
                                MessageBox.Show("Le bilan a bien été ajouté.", "Avertissement");

                                //on regarde si des échantillons ont été offerts

                                //on convertit en int les id du praticien et du visiteur
                                int idp = Convert.ToInt16(idP[0][0]);
                                int idv = Convert.ToInt16(idV[0][0]);

                                //on vérifie si les combo et textbox sont vides ou non
                                if (bv_cbx1NomEchantillon.Text != "" && bv_txb1Quantite.Text != "")
                                {
                                    string nomE1 = bv_cbx1NomEchantillon.Text;
                                    int qE1 = Convert.ToInt16(bv_txb1Quantite.Text);

                                    //on récupère l'id du médicament
                                    int idM = Convert.ToInt16(Manager.Manager.SelectIDmedicament(nomE1)[0][0]);

                                    //on récupère l'id du rapport

                                    int idR = Convert.ToInt16(Manager.Manager.SelectIDbilan(idp, idv)[0][0]);

                                    //on ajoute l'échantillon dans la table offrir
                                    Manager.Manager.AddOffre(idM, idR, qE1);
                                }

                                if (bv_cbx2NomEchantillon.Text != "" && bv_txb2Quantite.Text != "")
                                {
                                    string nomE1 = bv_cbx2NomEchantillon.Text;
                                    int qE1 = Convert.ToInt16(bv_txb2Quantite.Text);

                                    //on récupère l'id du médicament
                                    int idM = Convert.ToInt16(Manager.Manager.SelectIDmedicament(nomE1)[0][0]);

                                    //on récupère l'id du rapport
                                    int idR = Convert.ToInt16(Manager.Manager.SelectIDbilan(idp, idv)[0][0]);

                                    //on ajoute l'échantillon dans la table offrir
                                    Manager.Manager.AddOffre(idM, idR, qE1);
                                }

                                if (bv_cbx3NomEchantillon.Text != "" && bv_txb3Quantite.Text != "")
                                {
                                    string nomE1 = bv_cbx3NomEchantillon.Text;
                                    int qE1 = Convert.ToInt16(bv_txb3Quantite.Text);

                                    //on récupère l'id du médicament
                                    int idM = Convert.ToInt16(Manager.Manager.SelectIDmedicament(nomE1)[0][0]);

                                    //on récupère l'id du rapport
                                    int idR = Convert.ToInt16(Manager.Manager.SelectIDbilan(idp, idv)[0][0]);

                                    //on ajoute l'échantillon dans la table offrir
                                    Manager.Manager.AddOffre(idM, idR, qE1);
                                }

                                if (bv_cbx4NomEchantillon.Text != "" && bv_txb4Quantite.Text != "")
                                {
                                    string nomE1 = bv_cbx4NomEchantillon.Text;
                                    int qE1 = Convert.ToInt16(bv_txb4Quantite.Text);

                                    //on récupère l'id du médicament
                                    int idM = Convert.ToInt16(Manager.Manager.SelectIDmedicament(nomE1)[0][0]);

                                    //on récupère l'id du rapport
                                    int idR = Convert.ToInt16(Manager.Manager.SelectIDbilan(idp, idv)[0][0]);

                                    //on ajoute l'échantillon dans la table offrir
                                    Manager.Manager.AddOffre(idM, idR, qE1);
                                }

                                //on nettoie le formulaire
                                clear();

                            //}
                            //catch
                            //{
                            //    MessageBox.Show("Erreur ! ", "Attention");
                            //}
                        }
                    }
                }
            }          
        }
        #endregion
    }
}
