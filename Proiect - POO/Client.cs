using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect___POO
{
    class Client
    {
        string nume, prenume, adresa, email, telefon;
        string banca;
        string cont, clientID;

        public Client(string nume, string prenume, string adresa, string email, string telefon, string banca, string cont)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.adresa = adresa;
            this.email = email;
            this.telefon = telefon;
            this.banca = banca;
            this.cont = cont;
            generareID();
        }

        public Client(string nume, string prenume, string adresa, string email, string telefon, string banca, string cont, string clientID)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.adresa = adresa;
            this.email = email;
            this.telefon = telefon;
            this.banca = banca;
            this.cont = cont;
            this.clientID = clientID;
        }

        void generareID()
        {
            SingletonNrRandom rand = SingletonNrRandom.Instance;
            for (int i = 0; i < 5; i++)
                clientID += rand.getRandom();
            clientID += nume[0].ToString() + prenume[0].ToString();
        }

        public string getNume()
        {
            return nume;
        }

        public string getPrenume()
        {
            return prenume;
        }

        public string getAdresa()
        {
            return adresa;
        }

        public string getEmail()
        {
            return email;
        }

        public string getTelefon()
        {
            return telefon;
        }

        public string getBanca()
        {
            return banca;
        }

        public string getCont()
        {
            return cont;
        }

        public string getID()
        {
            return clientID;
        }
    }
}
