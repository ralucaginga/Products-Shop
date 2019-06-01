using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect___POO
{
    class Produs
    {
        int EAN_8;
        long EAN_13;
        string denumire, categorie;
        double pret;
        int stoc;

        protected Produs(string denumire, string categorie, double pret, int stoc, int EAN_8, long EAN_13)
        {
            this.denumire = denumire;
            this.categorie = categorie;
            this.pret = pret;
            this.stoc = stoc;
            this.EAN_8 = EAN_8;
            this.EAN_13 = EAN_13;
        }

        public string getDenumire()
        {
            return denumire;
        }

        public string getCategorie()
        {
            return categorie;
        }

        public double getPret()
        {
            return pret;
        }

        public int getStoc()
        {
            return stoc;
        }

        public int getEAN8()
        {
            return EAN_8;
        }

        public long getEAN13()
        {
            return EAN_13;
        }

        public void getItem(int cant) // scade stocul
        {
            stoc -= cant;
        }
    }
}
