using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicaments
{
    public class medicaments{
        private int id;
        private string nomCommercial;
        private int idFam;
        private string composition;
        private string effets;
        private string contreindic;

        public medicaments(int id, string nomCommercial, int idFam, string composition, string effets, string contreindic)
        {
            this.id = id;
            this.nomCommercial = nomCommercial;
            this.idFam = idFam;
            this.composition = composition;
            this.effets = effets;
            this.contreindic = contreindic;
        }

        public int Id { get => id; }
        public string NomCommercial { get => nomCommercial; }
    }

}
