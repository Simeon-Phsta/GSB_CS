using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using pass;

namespace Manager
{
    public class Manager
    {
        static public MySqlConnection conenct()
        {
            return Passerelle.GetDBConnection("localhost", 3306, "ppe_gsb_cs", "root", "");
        }

        #region Selects

        #region Medicaments
            static public List<string[]> SelectMedicaments()
            {
                string sql = "Select nomCommercial,id from `medicament`";
                return Passerelle.Query(Manager.conenct(), sql);
            }
            static public List<string[]> SelectAllNomFam()
            {
                string sql = "Select libelle from famille";
                return Passerelle.Query(Manager.conenct(), sql);
            }
            static public List<string[]> SelectMedicamentsFromFamille(string nomfam)
            {
                string sql = "Select medicament.id ,nomCommercial from medicament inner join famille on medicament.idFamille = famille.id where famille.libelle ='" + nomfam + "'";
                return Passerelle.Query(Manager.conenct(), sql);
            }
            static public List<string[]> SelectMedicamentsStartingWith(string startnommedoc)
            {
                string sql = "Select nomCommercial,id from medicament where nomCommercial LIKE '%" + startnommedoc + "%'";
                return Passerelle.Query(Manager.conenct(), sql);
            }
            static public List<string[]> SelectMedicamentsFromIdMedoc(string idmedoc)
            {
                string sql = "Select medicament.nomCommercial,famille.libelle,composition ,effets , contreindication from medicament inner join famille on medicament.idFamille = famille.id where medicament.id ='" + idmedoc + "'";
                return Passerelle.Query(Manager.conenct(), sql);
            }
            static public List<string[]> SelectAllFromMedoc()
            {
                string sql = "Select id,nomCommercial,idFamille,composition ,effets , contreindication from medicament";
                return Passerelle.Query(Manager.conenct(), sql);
            }
            static public int SelectidFamFromNom(string nom)
            {
            string sql = "Select id from famille where libelle = '" + nom + "'";
            var temp = Passerelle.Query(Manager.conenct(), sql);
            string ext = "";
            int oute = 0;
            if (temp != null)
            {
                ext = temp[0][0]; 
                oute = Convert.ToInt32(ext);
                return oute;
            }
            else { return oute; }
            }
            
            static public int GetMaxIDMed()
            {
                string sql = "Select Max(id) from medicament";
                return Convert.ToInt32(Passerelle.Query(Manager.conenct(), sql)[0][0]);
            }
            static public int GetMaxIDFam()
            {
                string sql = "Select Max(id) from famille";
                return Convert.ToInt32(Passerelle.Query(Manager.conenct(), sql)[0][0]);
            }

            //id médicament
            static public List<string[]> SelectIDmedicament(string nomCommercial)
            {
                string sql = "SELECT id FROM medicament WHERE nomCommercial = '" + nomCommercial + "'";
                return Passerelle.Query(Manager.conenct(), sql);
            }
        #endregion
        #region Medecins

        //affichage de la liste des medecins
        static public List<string[]>  SelectMedecins()
        {
            string sql = "SELECT medecin.nom as nom, medecin.prenom as prenom, " +
                "specialiste.libelle as specialite , villes_france_free.ville_nom_reel as ville, " +
                "villes_france_free.ville_code_postal, medecin.adresse, medecin.telephone," +
                " medecin.id FROM medecin INNER JOIN specialiste " +
                "ON medecin.idSpecialiste = specialiste.id " +
                "LEFT JOIN villes_france_free ON medecin.idVille = villes_france_free.ville_id ORDER BY medecin.nom";
            return Passerelle.Query(Manager.conenct(), sql);
        }

        //affichage d'un medecin précis pour le formulaire de modification
        static public List<string[]> SelectMedecin(int unId)
        {
            string sql = "SELECT medecin.nom as nom, medecin.prenom as prenom, " +
                "specialiste.libelle as specialite , villes_france_free.ville_nom_reel as ville, " +
                "villes_france_free.ville_code_postal, medecin.adresse, medecin.telephone, " +
                "medecin.id FROM medecin INNER JOIN specialiste " +
                "ON medecin.idSpecialiste = specialiste.id " +
                "LEFT JOIN villes_france_free ON medecin.idVille = villes_france_free.ville_id " +
                "WHERE medecin.id = '" + unId + "' ORDER BY medecin.nom ";
            return Passerelle.Query(Manager.conenct(), sql);
        }

        static public List<string[]> SelectIdRapportsPourMedecin(int idMedecin) 
        {
            string sql = "SELECT rapport.id FROM rapport WHERE idMedecin = " + idMedecin + "";
            return Passerelle.Query(Manager.conenct(), sql);
        }

        static public List<string[]> SelectRapports(int idMedecin)
        {
            string sql = "SELECT rapport.id, date, motif, bilan " +
                "FROM rapport INNER JOIN medecin ON medecin.id = rapport.idMedecin  " +
                "WHERE rapport.idMedecin = '" + idMedecin + "'";
            return Passerelle.Query(Manager.conenct(), sql);
        }

        //Récupération des spécialités pour le cbboxSpecialite
        static public List<string[]> SelectSpecialites()
        {
            string sql = "SELECT libelle FROM specialiste";
            return Passerelle.Query(Manager.conenct(), sql);
        }

        //Select de l'id d'un medecin par son nom et prenom
        static public List<string[]> SelectIDpraticien(string nom, string prenom)
        {
            string sql = "SELECT id FROM medecin WHERE nom = '" + nom + "' AND prenom = '" + prenom + "'";
            return Passerelle.Query(Manager.conenct(), sql);
        }

        //Récupération des villes pour le cbboxVille
        static public List<string[]> SelectVilles()
        {
            string sql = "SELECT ville_nom_reel, ville_code_postal FROM villes_france_free";
            return Passerelle.Query(Manager.conenct(), sql);
        }

        //affichage de la liste des praticiens
        static public List<string[]> SelectPraticiens()
        {
            string sql = "SELECT nom, prenom, ville_nom_reel AS ville FROM medecin INNER JOIN villes_france_free ON medecin.idVille = villes_france_free.ville_id";
            return Passerelle.Query(Manager.conenct(), sql);
        }

        //Récupération de l'idVille pour l'Insert d'un nouveau médecin
        static public List<string[]> SelectIdVille(string nomVille, string cpVille)
        {
            string sql = "SELECT ville_id FROM villes_france_free WHERE ville_nom_reel  = '" + nomVille + "' AND ville_code_postal = '" + cpVille + "'" ;
            return Passerelle.Query(Manager.conenct(), sql);
        }

        //Récupération de l'idSpecialite pour l'Insert d'un nouveau médecin
        static public List<string[]> SelectIdSpecialiste(string libelleSpecialitse)
        {
            string sql = "SELECT id FROM specialiste WHERE libelle  = '" + libelleSpecialitse + "'";
            return Passerelle.Query(Manager.conenct(), sql);
        }

        #endregion
        #region Rapports / Bilan

        // Affichage de la liste des rapoorts pour le médecin sélectionné
        static public List<string[]> SelectRapport(int idRapport)
        {
            string sql = "SELECT rapport.id, date, motif, bilan FROM rapport INNER JOIN medecin ON medecin.id = rapport.idMedecin  WHERE rapport.id = '" + idRapport + "'";
            return Passerelle.Query(Manager.conenct(), sql);
        }
        
        //Affichage du "pop up" contenant la bilan d'un rapport selectionner avec son id
        static public List<string[]> SelectBilanRapport(int idRapport)
        {
            string sql = "SELECT bilan FROM rapport WHERE id ='" + idRapport + "'";
            return Passerelle.Query(Manager.conenct(), sql);
        }

        //séléctionner le dernier id des rapports
        static public List<string[]> SelectMaxIdBilan()
        {
            string sql = "SELECT MAX(id) FROM rapport";
            return Passerelle.Query(Manager.conenct(), sql);
        }

        //Select un rapport en fonction de son idMedecin et idVisiteur
        static public List<string[]> SelectIDbilan(int idP, int idV)
        {
            string sql = "SELECT id FROM rapport WHERE idMedecin = " + idP + " AND idVisiteur = " + idV;
            return Passerelle.Query(Manager.conenct(), sql);
        }

        //select de tous les motifs
        static public List<string[]> SelectMotif()
        {
            string sql = "SELECT motif FROM rapport";
            return Passerelle.Query(Manager.conenct(), sql);
        }

        #endregion
        #region Visiteurs
        //séléctionner le dernier id
        static public List<string[]> SelectMaxIdVisiteur()
        {
            string sql = "SELECT MAX(id) FROM visiteur";
            return Passerelle.Query(Manager.conenct(), sql);
        }
        //afficher la liste des villes
        static public List<string[]> SelectVillesVisiteurs()
        {
            string sql = "SELECT ville_nom_reel as ville, ville_code_postal FROM villes_france_free ORDER BY ville ASC LIMIT 10";
            return Passerelle.Query(Manager.conenct(), sql);
        }

        //récupérer l'id max pour en incrémenter un new lors de la crétion du nouveau visiteur
        static public List<string[]> SelectIdVisiteur()
        {
            string sql = "SELECT MAX(id) FROM visiteur";
            return Passerelle.Query(Manager.conenct(), sql);
        }

        //Select l'id d'un visiteur par rapport à son nom et prenom
        static public List<string[]> SelectIDvisiteur(string nom, string prenom)
        {
            string sql = "SELECT id FROM visiteur WHERE nom ='" + nom + "' AND prenom = '" + prenom + "'";
            return Passerelle.Query(Manager.conenct(), sql);
        }

        //récuérer id de la ville
        static public List<string[]> SelectIdVille(string idVille)
        {
            string sql = "SELECT ville_id FROM villes_france_free WHERE ville_nom_reel = '" + idVille + "' LIMIT 10";
            return Passerelle.Query(Manager.conenct(), sql);
        }

        //afficher la liste des visiteurs pour le datagridview dans FormModifierVisiteurs
        static public List<string[]> SelectVisiteurS()
        {
            string sql = "SELECT id, nom, prenom, adresse, idVille, dateEmbauche FROM visiteur";
            return Passerelle.Query(Manager.conenct(), sql);
        }

        //affichage de la liste des visiteurs
        static public List<string[]> SelectVisiteurs()
        {
            string sql = "SELECT nom, prenom FROM visiteur";
            return Passerelle.Query(Manager.conenct(), sql);
        }

        //afficher le nom de la ville avec son code postal dans FormModifierVisiteur
        static public List<string[]> SelectVilleCDP(string villeID)
        {
            string sql = "SELECT ville_nom_reel, ville_code_postal FROM villes_france_free WHERE ville_id =" + villeID;
            return Passerelle.Query(Manager.conenct(), sql);
        }
        #endregion

        #endregion

        #region Insert Update Delete
        #region Medicaments

        static public void DeleteMedoc(string str)
        {
            string sql = "delete from medicament where id = '" + str + "'";
            Passerelle.InsertUpdateDel(Manager.conenct(), sql);
        }
        static public void ModifMedoc(string idmedoc, string newnom, string nomfam, string compo, string effets, string contreindic)
        {

            compo = compo.Replace("'", " ");
            compo = compo.Replace('"', ' ');

            effets = effets.Replace("'", " ");
            effets = effets.Replace('"', ' ');

            contreindic = contreindic.Replace("'", " ");
            contreindic = contreindic.Replace('"', ' ');

            int idfam = SelectidFamFromNom(nomfam);
            string sql = "Update medicament set nomCommercial = '" + newnom + "',idFamille =" + idfam + ",composition = '" + compo + "',effets = '" + effets + "',contreIndication = '" + contreindic + "' where id = '" + idmedoc + "'";
            Passerelle.InsertUpdateDel(Manager.conenct(), sql);
        }
        static public void DeleteFam(string str)
        {
            string sql = "Select medicament.id from medicament inner join famille on medicament.idFamille = famille.id where famille.libelle = '"+str+"'";
            try
            {
                string temp = Passerelle.Query(Manager.conenct(), sql)[0][0];
                int tempe = Convert.ToInt32(temp);
                MessageBox.Show("Famille non vide");
            }
            catch
            {
                sql = "delete from famille where libelle = '" + str + "'";
                Passerelle.InsertUpdateDel(Manager.conenct(), sql);
            }
        }

        static public void InsertMedoc(string NomMedoc, string nomfamille, string Compo, string Effets, string Contreindic)
        {
            Compo = Compo.Replace("'", " ");
            Compo = Compo.Replace('"', ' ');

            Effets = Effets.Replace("'", " ");
            Effets = Effets.Replace('"', ' ');

            Contreindic = Contreindic.Replace("'", " ");
            Contreindic = Contreindic.Replace('"', ' ');

            string sql = "Insert into medicament(id,nomCommercial,idFamille,composition,effets,contreindication) ";
            if (SelectidFamFromNom(nomfamille) == 0) { Passerelle.InsertUpdateDel(Manager.conenct(), "Insert Into famille(id,libelle) Values(" + (GetMaxIDFam() + 1) + ",'" + nomfamille + "')"); }
            sql += "Values(" + (GetMaxIDMed() + 1) + ",'" + NomMedoc + "','" + SelectidFamFromNom(nomfamille) + "',";
            sql += "'" + Compo + "','" + Effets + "','" + Contreindic + "')";
            Passerelle.InsertUpdateDel(Manager.conenct(), sql);
        }
        #endregion
        #region Echantillons (offrir)
        //ajouter les échantillons dans offrir
        static public void AddOffre(int idMedicament, int idRapport, int quantite)
        {
            string sql = "INSERT INTO offrir (idMedicament, idRapport, quantite) VALUES (" + idMedicament + ", " + idRapport + ", " + quantite + ")";
            Passerelle.InsertUpdateDel(Manager.conenct(), sql);
        }
        #endregion
        #region Medecins

        //Suppression d'un medecin avec son nom et prenom dans le formulaire
        static public void DeleteMedecin(int unId)
        {
            string sql = "delete from medecin where medecin.id = '" + unId + "'";
            Passerelle.InsertUpdateDel(Manager.conenct(), sql);
        }

        //Modification d'un medecin avec son nom et son prenom
        static public void ModifMedecin(string newNom, string newPrenom, string newAdresse, string newVille , string newTelephone, string newIdSpecialiste, int unId)
        {

            newPrenom = newPrenom.Replace("'", " ");
            newPrenom = newPrenom.Replace('"', ' ');

            newNom = newNom.Replace("'", " ");
            newNom = newNom.Replace('"', ' ');

            newAdresse = newAdresse.Replace("'", " ");
            newAdresse = newAdresse.Replace('"', ' ');

            newVille = newVille.Replace("'", " ");
            newVille = newVille.Replace('"', ' ');

            newTelephone = newTelephone.Replace("'", " ");
            newTelephone = newTelephone.Replace('"', ' ');

            string sql = "UPDATE medecin SET nom = '" + newNom + "' ,prenom = '" + newPrenom + "' ,adresse = '" + newAdresse + "' ,idVille = '" + newVille + "' ,telephone = '" + newTelephone + "' ,idSpecialiste = '" + newIdSpecialiste + "'  where id = " + unId ;
            Passerelle.InsertUpdateDel(Manager.conenct(), sql);
        }

        //Ajout d'un medecin
        static public void InsertMedecin( string newNom, string newPrenom, string newAdresse, string newVille, string newTelephone, string newIdSpecialiste)
        {

            newPrenom = newPrenom.Replace("'", " ");
            newPrenom = newPrenom.Replace('"', ' ');

            newNom = newNom.Replace("'", " ");
            newNom = newNom.Replace('"', ' ');

            newAdresse = newAdresse.Replace("'", " ");
            newAdresse = newAdresse.Replace('"', ' ');

            newVille = newVille.Replace("'", " ");
            newVille = newVille.Replace('"', ' ');

            newTelephone = newTelephone.Replace("'", " ");
            newTelephone = newTelephone.Replace('"', ' ');

            string sql = "INSERT INTO medecin ( nom, prenom, adresse, idVille, telephone, idSpecialiste) VALUES ('" + newNom + "', '" + newPrenom + "', '" + newAdresse + "', '" + newVille + "', '" + newTelephone + "', '" + newIdSpecialiste + "')";
            Passerelle.InsertUpdateDel(Manager.conenct(), sql);
        }

        #endregion
        #region Rapports / Bilan

        //ajouter un bilan
        static public void AddBilanVisite(string praticien, string visiteur, string date, string motif, string impact)
        {
            date = Convert.ToDateTime(date).ToShortDateString();
            date = date.Replace('/', '-');
            date = date[6].ToString() + date[7].ToString() + date[8].ToString() + date[9].ToString() + date[2].ToString() + date[3].ToString() + date[4].ToString() + date[2].ToString() + date[0].ToString() + date[1].ToString();

            praticien = praticien.Replace("'", " ");
            praticien = praticien.Replace('"', ' ');

            visiteur = visiteur.Replace("'", " ");
            visiteur = visiteur.Replace('"', ' ');

            motif = motif.Replace("'", " ");
            motif = motif.Replace('"', ' ');

            impact = impact.Replace("'", " ");
            impact = impact.Replace('"', ' ');

            int id = Convert.ToInt16(Manager.SelectMaxIdBilan()[0][0]);
            int unId = id + 1;

            string sql = "INSERT INTO rapport (id, date, motif, bilan, idMedecin, idVisiteur) VALUES (" + unId + ",'" + date + "', '" + motif + "', '" + impact + "', '" + praticien + "', '" + visiteur + "')";
            Passerelle.InsertUpdateDel(Manager.conenct(), sql);

        }

        //Modification d'un rapport 
        static public void UpdateRapport(int id, string uneDate, string unMotif, string unBilan)
        {
            uneDate = Convert.ToDateTime(uneDate).ToShortDateString();
            uneDate = uneDate.Replace('/', '-');
            uneDate = uneDate[6].ToString() + uneDate[7].ToString() + uneDate[8].ToString() + uneDate[9].ToString() + uneDate[2].ToString() + uneDate[3].ToString() + uneDate[4].ToString() + uneDate[2].ToString() + uneDate[0].ToString() + uneDate[1].ToString();
            uneDate = uneDate.Replace("'", " ");
            uneDate = uneDate.Replace('"', ' ');

            string sql = "UPDATE rapport SET rapport.motif = '" + unMotif + "' , rapport.bilan = '" + unBilan + "', rapport.date = '" + uneDate + "'  WHERE rapport.id = " + id ;
            Passerelle.InsertUpdateDel(Manager.conenct(), sql);
        }

        //Suppression d'un rapport avec son id et des ses échantillons associés
        static public void DeleteRapport(int unId)
        {
            string sql = "DELETE FROM offrir WHERE offrir.idRapport = '" + unId + "'";
            Passerelle.InsertUpdateDel(Manager.conenct(), sql);
            string supp = "DELETE FROM rapport WHERE rapport.id = '" + unId + "'";
            Passerelle.InsertUpdateDel(Manager.conenct(), supp);
        }

        //Suppression des rapports et des échantillions en fonction d'un praticiens
        static public void DeleteRapports(int unId)
        {
            string sql = "DELETE FROM offrir WHERE offrir.idRapport = '" + unId + "'";
            Passerelle.InsertUpdateDel(Manager.conenct(), sql);
            string supp = "DELETE FROM rapport WHERE rapport.id = '" + unId + "'";
            Passerelle.InsertUpdateDel(Manager.conenct(), supp);
        }
        #endregion
        #region Visiteurs
        //ajout d'un visiteur
        static public void InsertVisiteur(string unNom, string unPrenom, string uneAdresse, string unIdVille, string unLogin, string unMdp, string uneDate, string cp)
        {
            uneDate = Convert.ToDateTime(uneDate).ToShortDateString();
            uneDate = uneDate.Replace('/', '-');
            uneDate = uneDate[6].ToString() + uneDate[7].ToString() + uneDate[8].ToString() + uneDate[9].ToString() + uneDate[2].ToString() + uneDate[3].ToString() + uneDate[4].ToString() + uneDate[2].ToString() + uneDate[0].ToString() + uneDate[1].ToString();

            unPrenom = unPrenom.Replace("'", " ");
            unPrenom = unPrenom.Replace('"', ' ');

            unNom = unNom.Replace("'", " ");
            unNom = unNom.Replace('"', ' ');

            uneAdresse = uneAdresse.Replace("'", " ");
            uneAdresse = uneAdresse.Replace('"', ' ');

            unIdVille = unIdVille.Replace("'", " ");
            unIdVille = unIdVille.Replace('"', ' ');

            uneDate = uneDate.Replace("'", " ");
            uneDate = uneDate.Replace('"', ' ');

            unLogin = unLogin.Replace("'", " ");
            unLogin = unLogin.Replace('"', ' ');

            unMdp = unMdp.Replace("'", " ");
            unMdp = unMdp.Replace('"', ' ');

            cp = cp.Replace("'", " ");
            cp = cp.Replace('"', ' ');

            int id = Convert.ToInt16(Manager.SelectMaxIdVisiteur()[0][0]);
            int unId = id + 1;

            string sql = "INSERT INTO visiteur (id, nom, prenom, login, mdp, adresse, dateEmbauche, idVille, cdp) VALUES (" + unId + ",'" + unNom + "', '" + unPrenom + "', '" + unLogin + "', '" + unMdp + "', '" + uneAdresse + "', '" + uneDate + "', '" + unIdVille + "', '" + cp + "')";
            Passerelle.InsertUpdateDel(Manager.conenct(), sql);
        }

        //modification utilisateur
        static public void UpdateVisteur(string unNom, string unPrenom, string uneAdresse, string uneDate, string unIdVille, string unCp, int id)
        {
            unPrenom = unPrenom.Replace("'", " ");
            unPrenom = unPrenom.Replace('"', ' ');

            unNom = unNom.Replace("'", " ");
            unNom = unNom.Replace('"', ' ');

            uneAdresse = uneAdresse.Replace("'", " ");
            uneAdresse = uneAdresse.Replace('"', ' ');

            unIdVille = unIdVille.Replace("'", " ");
            unIdVille = unIdVille.Replace('"', ' ');

            unCp = unCp.Replace("'", " ");
            unCp = unCp.Replace('"', ' ');

            uneDate = uneDate.Replace('/', '-');
            uneDate = uneDate[6].ToString() + uneDate[7].ToString() + uneDate[8].ToString() + uneDate[9].ToString() + uneDate[2].ToString() + uneDate[3].ToString() + uneDate[4].ToString() + uneDate[2].ToString() + uneDate[0].ToString() + uneDate[1].ToString();

            uneDate = uneDate.Replace("'", " ");
            uneDate = uneDate.Replace('"', ' ');

            string sql = "UPDATE visiteur SET nom = '" + unNom + "', prenom ='" + unPrenom + "', adresse ='" + uneAdresse + "', dateEmbauche = '" + uneDate + "', idVille = '" + unIdVille + "', cdp ='" + unCp + "' WHERE id =" + id;
            Passerelle.InsertUpdateDel(Manager.conenct(), sql);
        }

        //suppression d'un visiteur
        static public void DeleteVisiteur(int unId, string unNom, string unPrenom)
        {
            //pour supprimer un visiteur, il faut d'abord supprime les rapports où le visiteur était en charge
            string req = "DELETE FROM rapport WHERE idVisiteur = " + unId;
            Passerelle.InsertUpdateDel(Manager.conenct(), req);
            string sql = "DELETE FROM visiteur WHERE nom ='" + unNom + "' AND prenom ='" + unPrenom + "'";
            Passerelle.InsertUpdateDel(Manager.conenct(), sql);
        }
        #endregion
        #endregion


    }
}
