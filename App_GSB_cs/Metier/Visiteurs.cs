using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visiteur
{
    class Visiteurs
    {
        private int id;
        private string nomVisiteur;
        private string prenomVisiteur;
        private string adresse;
        private int cp;
        private string ville;
        private DateTime dateEmbauche;
        private string login;
        private string mdp;

        public Visiteurs(int id, string nom, string prenom, string adresse, int cp, string ville, DateTime date, string login, string mdp)
        {
            this.id = id;
            nomVisiteur = nom;
            prenomVisiteur = prenom;
            this.adresse = adresse;
            this.cp = cp;
            this.ville = ville;
            dateEmbauche = date;
            this.login = login;
            this.mdp = mdp;
        }

        public int Id { get => id; }
        public string NomVisiteur { get => nomVisiteur; }
        public string PrenomVisiteur
        {
            get => prenomVisiteur;
        }
    }
    
}
