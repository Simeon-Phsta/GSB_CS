using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medecins
{
    public class medecin
    {
        private int id;
        private string nom, prenom, specialite, adresse, ville, motifDerniereVisite, telephone;
        private DateTime dateDerniereVisite;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Specialite { get => specialite; set => specialite = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Ville { get => ville; set => ville = value; }
        public string MotifDerniereVisite { get => motifDerniereVisite; set => motifDerniereVisite = value; }
        public DateTime DateDerniereVisite { get => dateDerniereVisite; set => dateDerniereVisite = value; }
        public int Id { get => id; set => id = value; }
        public string Nom1 { get => nom; set => nom = value; }
        public string Prenom1 { get => prenom; set => prenom = value; }
        public string Specialite1 { get => specialite; set => specialite = value; }
        public string Adresse1 { get => adresse; set => adresse = value; }
        public string Ville1 { get => ville; set => ville = value; }
        public string MotifDerniereVisite1 { get => motifDerniereVisite; set => motifDerniereVisite = value; }
        public string Telephone { get => telephone; set => telephone = value; }

        public medecin(int unId, string unNom, string unPrenom, string uneSpecialite, string uneVille, string uneAdresse, string unTelephone)
        {
            id = unId;
            nom = unNom;
            prenom = unPrenom;
            specialite = uneSpecialite;
            adresse = uneSpecialite;
            ville = uneVille;
            adresse = uneAdresse;
            telephone = unTelephone;
           
        }
    }

}
