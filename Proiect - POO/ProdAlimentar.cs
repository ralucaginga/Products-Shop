using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect___POO
{
    class ProdAlimentar : Produs
    {
        int valabilitate;

        public ProdAlimentar(string denumire, string categorie, double pret, int stoc, int valabilitate, int EAN_8, long EAN_13) : base(denumire, categorie, pret, stoc, EAN_8, EAN_13)
        {
            this.valabilitate = valabilitate;
        }

        public int getValabilitate()
        {
            return valabilitate;
        }
    }
}
