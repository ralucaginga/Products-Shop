using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect___POO
{
    public partial class Factura : Form
    {
        SingletonShop shop;
        private Client client;
        private List<ProdAlimentar> produseAlim;
        private List<int> cantAlim;
        private List<ProdNealimentar> produseNealim;
        private List<int> cantNealim;
        Image img;
        Graphics g;
        Font fLogo, fHeader, fText;

        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            shop = SingletonShop.Instance;
            client = shop.getClient();
            produseAlim = shop.getProdAlimentare();
            cantAlim = shop.getCantAlim();
            produseNealim = shop.getProdNealimentare();
            cantNealim = shop.getCantNealim();
            img = new Bitmap(pictureFactura.Width, pictureFactura.Height);
            g = Graphics.FromImage(img);
            fLogo = new Font("Times New Roman", 20, FontStyle.Bold);
            fHeader = new Font("Times New Roman", 12, FontStyle.Bold);
            fText = new Font("Times New Roman", 10);
            deseneaza();
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter += "jpeg file (*.jpeg)|*.jpeg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(img);
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
            }
        }

        private void imprimare_Click(object sender, EventArgs e)
        {
            imprima();
        }

        void imprima()
        {
            if (pd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                print.Print();
            }
        }

        private void print_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0);
        }

        private void print_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            MessageBox.Show("Imprimare terminata.", "Imprimare");
        }

        void deseneaza()
        {
            double total = 0, tva = 0;
            float x = 30, y = 30;
            int tableWidth = (pictureFactura.Width - 60 - 35) / 2 - 50;
            g.Clear(Color.White);
            //Logo
            g.DrawString("RoMart", fLogo, Brushes.Black, x, y);
            y = 80;

            //Furnizor
            g.DrawString("Furnizor", fHeader, Brushes.Black, x, y);
            y += fHeader.Height;
            g.DrawString("RoMart SRL", fHeader, Brushes.Black, x, y);
            y += fHeader.Height;

            g.DrawRectangle(new Pen(Brushes.Gray), x, y, 50, fText.Height);
            g.DrawString("Adresa", fText, Brushes.Black, x, y);
            g.DrawRectangle(new Pen(Brushes.Gray), x + 50, y, tableWidth, fText.Height);
            g.DrawString("Aleea Teiului", fText, Brushes.Black, x + 50, y);
            y += fText.Height;

            g.DrawRectangle(new Pen(Brushes.Gray), x, y, 50, fText.Height);
            g.DrawString("Email", fText, Brushes.Black, x, y);
            g.DrawRectangle(new Pen(Brushes.Gray), x + 50, y, tableWidth, fText.Height);
            g.DrawString("romart@srl.ro", fText, Brushes.Black, x + 50, y);
            y += fText.Height;

            g.DrawRectangle(new Pen(Brushes.Gray), x, y, 50, fText.Height);
            g.DrawString("Telefon", fText, Brushes.Black, x, y);
            g.DrawRectangle(new Pen(Brushes.Gray), x + 50, y, tableWidth, fText.Height);
            g.DrawString("0232 200 382", fText, Brushes.Black, x + 50, y);
            y += fText.Height;

            g.DrawRectangle(new Pen(Brushes.Gray), x, y, 50, fText.Height);
            g.DrawString("Banca", fText, Brushes.Black, x, y);
            g.DrawRectangle(new Pen(Brushes.Gray), x + 50, y, tableWidth, fText.Height);
            g.DrawString("ING", fText, Brushes.Black, x + 50, y);
            y += fText.Height;

            g.DrawRectangle(new Pen(Brushes.Gray), x, y, 50, fText.Height);
            g.DrawString("Cont", fText, Brushes.Black, x, y);
            g.DrawRectangle(new Pen(Brushes.Gray), x + 50, y, tableWidth, fText.Height);
            g.DrawString("RO53UWWV9569245981245264", fText, Brushes.Black, x + 50, y);

            //Client
            x = tableWidth + 30 + 50 + 35;
            y = 80;
            g.DrawString("Client", fHeader, Brushes.Black, x, y);
            y += fHeader.Height;
            g.DrawString(client.getNume() + " " + client.getPrenume(), fHeader, Brushes.Black, x, y);
            y += fHeader.Height;

            g.DrawRectangle(new Pen(Brushes.Gray), x, y, 50, fText.Height);
            g.DrawString("Adresa", fText, Brushes.Black, x, y);
            g.DrawRectangle(new Pen(Brushes.Gray), x + 50, y, tableWidth, fText.Height);
            g.DrawString(client.getAdresa(), fText, Brushes.Black, x + 50, y);
            y += fText.Height;

            g.DrawRectangle(new Pen(Brushes.Gray), x, y, 50, fText.Height);
            g.DrawString("Email", fText, Brushes.Black, x, y);
            g.DrawRectangle(new Pen(Brushes.Gray), x + 50, y, tableWidth, fText.Height);
            g.DrawString(client.getEmail(), fText, Brushes.Black, x + 50, y);
            y += fText.Height;

            g.DrawRectangle(new Pen(Brushes.Gray), x, y, 50, fText.Height);
            g.DrawString("Telefon", fText, Brushes.Black, x, y);
            g.DrawRectangle(new Pen(Brushes.Gray), x + 50, y, tableWidth, fText.Height);
            g.DrawString(client.getTelefon(), fText, Brushes.Black, x + 50, y);
            y += fText.Height;

            g.DrawRectangle(new Pen(Brushes.Gray), x, y, 50, fText.Height);
            g.DrawString("Banca", fText, Brushes.Black, x, y);
            g.DrawRectangle(new Pen(Brushes.Gray), x + 50, y, tableWidth, fText.Height);
            g.DrawString(client.getBanca(), fText, Brushes.Black, x + 50, y);
            y += fText.Height;

            g.DrawRectangle(new Pen(Brushes.Gray), x, y, 50, fText.Height);
            g.DrawString("Cont", fText, Brushes.Black, x, y);
            g.DrawRectangle(new Pen(Brushes.Gray), x + 50, y, tableWidth, fText.Height);
            g.DrawString(client.getCont(), fText, Brushes.Black, x + 50, y);

            //Factura din data de ...
            x = 30;
            y += 50;

            g.FillRectangle(Brushes.LightGray, x, y, pictureFactura.Width - 60, fText.Height);
            g.DrawString("Factura generată pe data de " + DateTime.Now.ToString("dd/MM/yyy hh:mm:ss"), fText, Brushes.Black, x, y);
            g.DrawString("Cotă TVA: 19%", fText, Brushes.Black, pictureFactura.Width - 130, y);

            //Header tabel produse
            x = 30;
            y += 50;
            float headerWidth = (pictureFactura.Width - 260) / 5;

            g.FillRectangle(Brushes.LightGray, x, y, 200, fText.Height);
            g.DrawRectangle(new Pen(Brushes.Black), x, y, 200, fText.Height);
            g.DrawString("Denumire produs", fText, Brushes.Black, x, y);
            x += 200;
            g.FillRectangle(Brushes.LightGray, x, y, headerWidth, fText.Height);
            g.DrawRectangle(new Pen(Brushes.Black), x, y, headerWidth, fText.Height);
            g.DrawString("U.M.", fText, Brushes.Black, x, y);
            x += headerWidth;
            g.FillRectangle(Brushes.LightGray, x, y, headerWidth, fText.Height);
            g.DrawRectangle(new Pen(Brushes.Black), x, y, headerWidth, fText.Height);
            g.DrawString("Cant.", fText, Brushes.Black, x, y);
            x += headerWidth;
            g.FillRectangle(Brushes.LightGray, x, y, headerWidth, fText.Height);
            g.DrawRectangle(new Pen(Brushes.Black), x, y, headerWidth, fText.Height);
            g.DrawString("Pret unitar", fText, Brushes.Black, x, y);
            x += headerWidth;
            g.FillRectangle(Brushes.LightGray, x, y, headerWidth, fText.Height);
            g.DrawRectangle(new Pen(Brushes.Black), x, y, headerWidth, fText.Height);
            g.DrawString("TVA", fText, Brushes.Black, x, y);
            x += headerWidth;
            g.FillRectangle(Brushes.LightGray, x, y, headerWidth, fText.Height);
            g.DrawRectangle(new Pen(Brushes.Black), x, y, headerWidth, fText.Height);
            g.DrawString("Total", fText, Brushes.Black, x, y);

            //Adaugam produsele alimentare
            for (int i = 0; i < produseAlim.Count; i++)
            {
                ProdAlimentar prod = produseAlim.ElementAt(i);
                int cant = cantAlim.ElementAt(i);
                double valTVA = cant * prod.getPret() * 0.19;
                total += cant * prod.getPret() + valTVA;
                tva += valTVA;
                x = 30;
                y += fText.Height;
                g.DrawRectangle(new Pen(Brushes.Black), x, y, 200, fText.Height);
                g.DrawString(prod.getDenumire(), fText, Brushes.Black, x, y);
                x += 200;
                g.DrawRectangle(new Pen(Brushes.Black), x, y, headerWidth, fText.Height);
                g.DrawString("buc.", fText, Brushes.Black, x, y);
                x += headerWidth;
                g.DrawRectangle(new Pen(Brushes.Black), x, y, headerWidth, fText.Height);
                g.DrawString(cant.ToString(), fText, Brushes.Black, x, y);
                x += headerWidth;
                g.DrawRectangle(new Pen(Brushes.Black), x, y, headerWidth, fText.Height);
                g.DrawString(prod.getPret().ToString(), fText, Brushes.Black, x, y);
                x += headerWidth;
                g.DrawRectangle(new Pen(Brushes.Black), x, y, headerWidth, fText.Height);
                g.DrawString(valTVA.ToString(), fText, Brushes.Black, x, y);
                x += headerWidth;
                g.DrawRectangle(new Pen(Brushes.Black), x, y, headerWidth, fText.Height);
                g.DrawString((cant * prod.getPret() + valTVA).ToString(), fText, Brushes.Black, x, y);
            }

            //Adaugam produsele nealimentare
            for (int i = 0; i < produseNealim.Count; i++)
            {
                ProdNealimentar prod = produseNealim.ElementAt(i);
                int cant = cantNealim.ElementAt(i);
                double valTVA = cant * prod.getPret() * 0.19;
                total += cant * prod.getPret() + valTVA;
                tva += valTVA;
                x = 30;
                y += fText.Height;
                g.DrawRectangle(new Pen(Brushes.Black), x, y, 200, fText.Height);
                g.DrawString(prod.getDenumire(), fText, Brushes.Black, x, y);
                x += 200;
                g.DrawRectangle(new Pen(Brushes.Black), x, y, headerWidth, fText.Height);
                g.DrawString("buc.", fText, Brushes.Black, x, y);
                x += headerWidth;
                g.DrawRectangle(new Pen(Brushes.Black), x, y, headerWidth, fText.Height);
                g.DrawString(cant.ToString(), fText, Brushes.Black, x, y);
                x += headerWidth;
                g.DrawRectangle(new Pen(Brushes.Black), x, y, headerWidth, fText.Height);
                g.DrawString(prod.getPret().ToString(), fText, Brushes.Black, x, y);
                x += headerWidth;
                g.DrawRectangle(new Pen(Brushes.Black), x, y, headerWidth, fText.Height);
                g.DrawString(valTVA.ToString(), fText, Brushes.Black, x, y);
                x += headerWidth;
                g.DrawRectangle(new Pen(Brushes.Black), x, y, headerWidth, fText.Height);
                g.DrawString((cant * prod.getPret() + valTVA).ToString(), fText, Brushes.Black, x, y);
            }

            //Total, tva, total cu tva
            x = pictureFactura.Width - 230;
            y += 50;

            g.FillRectangle(Brushes.LightGray, x, y, 100, fText.Height);
            g.DrawRectangle(new Pen(Brushes.Black), x, y, 100, fText.Height);
            g.DrawString("Pret fara TVA", fText, Brushes.Black, x, y);
            x += 100;
            g.FillRectangle(Brushes.LightGray, x, y, 100, fText.Height);
            g.DrawRectangle(new Pen(Brushes.Black), x, y, 100, fText.Height);
            g.DrawString((total - tva).ToString(), fText, Brushes.Black, x, y);        
            x -= 100;
            y += fText.Height;
            g.FillRectangle(Brushes.LightGray, x, y, 100, fText.Height);
            g.DrawRectangle(new Pen(Brushes.Black), x, y, 100, fText.Height);
            g.DrawString("Valoare TVA", fText, Brushes.Black, x, y);
            x += 100;
            g.FillRectangle(Brushes.LightGray, x, y, 100, fText.Height);
            g.DrawRectangle(new Pen(Brushes.Black), x, y, 100, fText.Height);
            g.DrawString(tva.ToString(), fText, Brushes.Black, x, y);
            x -= 100;
            y += fText.Height;
            g.FillRectangle(Brushes.LightGray, x, y, 100, fText.Height);
            g.DrawRectangle(new Pen(Brushes.Black), x, y, 100, fText.Height);
            g.DrawString("Pret cu TVA", fText, Brushes.Black, x, y);
            x += 100;
            g.FillRectangle(Brushes.LightGray, x, y, 100, fText.Height);
            g.DrawRectangle(new Pen(Brushes.Black), x, y, 100, fText.Height);
            g.DrawString(total.ToString(), fText, Brushes.Black, x, y);

            pictureFactura.Refresh();
        }

        private void pictureFactura_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0);
        }
    }
}
