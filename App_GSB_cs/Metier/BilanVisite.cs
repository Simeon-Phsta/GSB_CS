using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier
{
    class BilanVisite
    {
        private int id;
        private string motifVisite;
        private DateTime dateVisite;
        private string impact;
        private int quantite;

        public BilanVisite(int id, string motif, DateTime date, string impact, int quantite)
        {
            this.id = id;
            motifVisite = motif;
            dateVisite = date;
            this.impact = impact;
            this.quantite = quantite;
        }

        public string MotifVisite { get => motifVisite; }

    }
}
