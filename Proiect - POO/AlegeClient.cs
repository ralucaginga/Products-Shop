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
    public partial class AlegeClient : Form
    {
        IList<Client> clienti;

        public AlegeClient()
        {
            InitializeComponent();
        }

        private void AdaugaClient_Click(object sender, EventArgs e)
        {
            new CreareClient().ShowDialog();
            this.Controls.Clear();
            this.InitializeComponent();
            this.AlegeClient_Load_1(sender, e);
        }

        private void AlegeClient_Load_1(object sender, EventArgs e)
        {
            clienti = new List<Client>();
            listClient.Items.Add("-");
            listClient.SelectedIndex = 0;
            FileStream fs = new FileStream("Clienti.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string nume, prenume, adresa, email, telefon, banca, cont, clientID;
            while (!sr.EndOfStream)
            {
                nume = sr.ReadLine();
                prenume = sr.ReadLine();
                adresa = sr.ReadLine();
                email = sr.ReadLine();
                telefon = sr.ReadLine();
                banca = sr.ReadLine();
                cont = sr.ReadLine();
                clientID = sr.ReadLine();
                sr.ReadLine();
                clienti.Add(new Client(nume, prenume, adresa, email, telefon, banca, cont, clientID));
                listClient.Items.Add(nume + " " + prenume);
            }
            sr.Close();
        }

        private void listClient_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            int index = this.listClient.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                SingletonShop shop = SingletonShop.Instance;
                if(!shop.shopOpen())
                    new Shop().Show();
                shop.setClient(clienti.ElementAt(index - 1));
                this.Hide();
            }
        }
    }
}
