using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect___POO
{
    class ProdNealimentar : Produs
    {
        int garantie;
        
        public ProdNealimentar(string denumire, string categorie, double pret, int stoc, int garantie, int EAN_8, long EAN_13) : base(denumire, categorie, pret, stoc, EAN_8, EAN_13)
        {
            this.garantie = garantie;
        }

        public int getGarantie()
        {
            return garantie;
        }
    }
}
