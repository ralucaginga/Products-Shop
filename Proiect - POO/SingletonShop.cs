using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proiect___POO
{
    class SingletonShop
    {
        private static SingletonShop uniqueInstance;
        private Client client;
        private List<ProdAlimentar> produseAlim;
        private List<int> cantAlim;
        private List<ProdNealimentar> produseNealim;
        private List<int> cantNealim;
        private bool clientChosen = false;

        private SingletonShop()
        {
            produseAlim = new List<ProdAlimentar>();
            cantAlim = new List<int>();
            produseNealim = new List<ProdNealimentar>();
            cantNealim = new List<int>();
        }

        public static SingletonShop Instance
        {
            get
            {
                if (uniqueInstance == null)
                {
                    uniqueInstance = new SingletonShop();
                }
                return uniqueInstance;
            }
        }

        public int generareEAN_8()
        {
            SingletonNrRandom rnd = SingletonNrRandom.Instance;
            int[] EAN_8 = new int[9];
            int code = 0;
            int sp8 = 0, si8 = 0, s8 = 0;
            for (int i = 1; i < 9; i++)
            {
                EAN_8[i] = rnd.getRandom();
                if (i % 2 == 0)
                    sp8 += EAN_8[i];
                else si8 += EAN_8[i];
            }
            if (EAN_8[1] == 0)
            {
                while (EAN_8[1] == 0)
                {
                    EAN_8[1] = rnd.getRandom();
                }
                si8 += EAN_8[1];
            }
            s8 = 3 * si8 + sp8;
            if (s8 % 10 == 0)
                EAN_8[8] = 0;
            else EAN_8[8] = 10 - s8 % 10;
            for (int i = 1; i < 9; i++)
            {
                code = code * 10 + EAN_8[i];
            }
            return code;
        }

        public long generareEAN_13()
        {
            SingletonNrRandom rnd = SingletonNrRandom.Instance;
            int[] EAN_13 = new int[14];
            long code = 0;

            int sp13 = 0, si13 = 0, s13 = 0;
            for (int i = 1; i < 14; i++)
            {
                EAN_13[i] = rnd.getRandom();
                if (i % 2 == 0)
                    sp13 += EAN_13[i];
                else si13 += EAN_13[i];
            }
            if (EAN_13[1] == 0)
            {
                while (EAN_13[1] == 0)
                {
                    EAN_13[1] = rnd.getRandom();
                }
                si13 += EAN_13[1];
            }
            s13 = si13 + 3 * sp13;
            if (s13 % 10 == 0)
                EAN_13[13] = 0;
            else EAN_13[13] = 10 - s13 % 10;
            for (int i = 1; i < 14; i++)
            {
                code = code * 10 + EAN_13[i];
            }
            return code;
        }

        public void comanda()
        {
            if(produseAlim.Count==0 && produseNealim.Count==0)
            {
                MessageBox.Show("Nu au fost produse adaugate! Adaugati produs/e!");
            }
            else
            {
                FileStream fs = new FileStream("comanda.txt", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(getClientID());
                for(int i = 0; i < produseAlim.Count; i++)
                {
                    sw.WriteLine(produseAlim.ElementAt(i).getEAN8() + "/" + cantAlim.ElementAt(i));
                }
                for(int i = 0; i < produseNealim.Count; i++)
                {
                    sw.WriteLine(produseNealim.ElementAt(i).getEAN8() + "/" + cantNealim.ElementAt(i));
                }
                sw.Flush();
                sw.Close();
                new Factura().Show();
            }
        }

        public bool shopOpen()
        {
            return clientChosen;
        }

        public void setClient(Client c)
        {
            clientChosen = true;
            client = c;
        }

        public void addProdAlim(ProdAlimentar prod, int cant)
        {
            produseAlim.Add(prod);
            cantAlim.Add(cant);
        }

        public void addProdNealim(ProdNealimentar prod, int cant)
        {
            produseNealim.Add(prod);
            cantNealim.Add(cant);
        }

        public string getClientID()
        {
            return client.getID();
        }

        public Client getClient()
        {
            return client;
        }

        public List<ProdAlimentar> getProdAlimentare()
        {
            return produseAlim;
        }

        public List<ProdNealimentar> getProdNealimentare()
        {
            return produseNealim;
        }

        public List<int> getCantAlim()
        {
            return cantAlim;
        }

        public List<int> getCantNealim()
        {
            return cantNealim;
        }
    }
}
