using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proiect___POO
{
    public partial class CreareClient : Form
    {
        public CreareClient()
        {
            InitializeComponent(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Creare Client
            Client client;
            string nume, prenume, adresa, email, telefon, banca, cont;
            nume = textNume.Text;
            prenume = textPrenume.Text;
            adresa = textAdresa.Text;
            email = textEmail.Text;
            telefon = textTelefon.Text;
            banca = textBanca.Text;
            cont = textCont.Text;
            client = new Client(nume, prenume, adresa, email, telefon, banca, cont);

            FileStream fs = new FileStream("Clienti.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(client.getNume());
            sw.WriteLine(client.getPrenume());
            sw.WriteLine(client.getAdresa());
            sw.WriteLine(client.getEmail());
            sw.WriteLine(client.getTelefon());
            sw.WriteLine(client.getBanca());
            sw.WriteLine(client.getCont());
            sw.WriteLine(client.getID());
            sw.WriteLine("");
            sw.Flush();
            sw.Close();
            MessageBox.Show("Clientul a fost adaugat cu succes!");
            this.Close();
        }
    }
}
