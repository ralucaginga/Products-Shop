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
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using QRCoder;

namespace Proiect___POO
{
    public partial class Shop : Form
    {
        List<ProdAlimentar> produseAlim;
        List<ProdNealimentar> produseNealim;
        SingletonShop shop;
        Pen myPen;
        Image img, qrImg;
        Graphics g;
        Font f;
        String[] L = {"0001101", "0011001", "0010011", "0111101", "0100011", "0110001", "0101111", "0111011", "0110111", "0001011"};
        String[] G = {"0100111", "0110011", "0011011", "0100001", "0011101", "0111001", "0000101", "0010001", "0001001", "0010111"};
        String[] R = {"1110010", "1100110", "1101100", "1000010", "1011100", "1001110", "1010000", "1000100", "1001000", "1110100"};

        public Shop()
        {
            InitializeComponent();
        }

        private void alege_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produse.Items.Clear();
            if(alege.SelectedIndex==1)
            {
                produseAlim.Clear();
                FileStream fs = new FileStream("ProdAlim.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                for (; ; )
                {
                    String linie = sr.ReadLine();
                    if (linie == null) break;//daca s-a citit tot
                    String[] args = linie.Split(',');
                    if (args.Length == 7)
                    {
                        produseAlim.Add(new ProdAlimentar(args[0], args[1], Convert.ToDouble(args[2]), Convert.ToInt32(args[3]), Convert.ToInt32(args[4]), Convert.ToInt32(args[5]), Convert.ToInt64(args[6])));
                    }
                    else
                    {
                        produseAlim.Add(new ProdAlimentar(args[0], args[1], Convert.ToDouble(args[2]), Convert.ToInt32(args[3]), Convert.ToInt32(args[4]), shop.generareEAN_8(), shop.generareEAN_13()));
                    }
                }
                sr.Close();
                for (int i = 0; i < produseAlim.Count; i++)
                {
                    Produse.Items.Add(produseAlim.ElementAt(i).getDenumire());
                }
            }
            else if (alege.SelectedIndex == 2)
            {
                produseNealim.Clear();
                FileStream fs = new FileStream("ProdNealim.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                for (; ; )
                {
                    String linie = sr.ReadLine();
                    if (linie == null) break;//daca s-a citit tot
                    String[] args = linie.Split(',');
                    if (args.Length == 7)
                    {
                        produseNealim.Add(new ProdNealimentar(args[0], args[1], Convert.ToDouble(args[2]), Convert.ToInt32(args[3]), Convert.ToInt32(args[4]), Convert.ToInt32(args[5]), Convert.ToInt64(args[6])));
                    }
                    else
                    {
                        produseNealim.Add(new ProdNealimentar(args[0], args[1], Convert.ToDouble(args[2]), Convert.ToInt32(args[3]), Convert.ToInt32(args[4]), shop.generareEAN_8(), shop.generareEAN_13()));
                    }
                }
                sr.Close();
                for (int i = 0; i < produseNealim.Count; i++)
                {
                    Produse.Items.Add(produseNealim.ElementAt(i).getDenumire());
                }
            }
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            shop = SingletonShop.Instance;
            produseAlim = new List<ProdAlimentar>();
            produseNealim = new List<ProdNealimentar>();
            alege.Items.Add("-");
            alege.SelectedIndex = 0;
            alege.Items.Add("Produse alimentare");
            alege.Items.Add("Produse nealimentare");
            img = new Bitmap(scanCode.Width, scanCode.Height);
            g = Graphics.FromImage(img);
            myPen = new Pen(Brushes.Black, 2.0f);
            f = new Font("Times New Roman", 15, GraphicsUnit.Pixel);
            hideAll();
        }

        private void hideAll()
        {
            labelNume.Hide();
            labelCateg.Hide();
            labelPret.Hide();
            labelStoc.Hide();
            labelGarantie.Hide();
            labelCantitate.Hide();
            textCantitate.Hide();
            adaugaCos.Hide();
            btnEAN8.Hide();
            btnEAN13.Hide();
            btnQR.Hide();
            saveProductCode.Hide();
        }

        private void showAll()
        {
            labelNume.Show();
            labelCateg.Show();
            labelPret.Show();
            labelStoc.Show();
            labelGarantie.Show();
            labelCantitate.Show();
            textCantitate.Show();
            adaugaCos.Show();
            btnEAN8.Show();
            btnEAN13.Show();
            btnQR.Show();
            saveProductCode.Show();
        }

        private void Produse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(alege.SelectedIndex == 1)
            {
                showAll();
                labelNume.Text = "Nume produs: " + produseAlim.ElementAt(Produse.SelectedIndex).getDenumire();
                labelCateg.Text="Categorie produs: "+ produseAlim.ElementAt(Produse.SelectedIndex).getCategorie();
                labelPret.Text = "Pret produs: " + produseAlim.ElementAt(Produse.SelectedIndex).getPret();
                labelStoc.Text = "Stoc: " + produseAlim.ElementAt(Produse.SelectedIndex).getStoc();
                labelGarantie.Text = "Valabilitate produs: " + produseAlim.ElementAt(Produse.SelectedIndex).getValabilitate();
            }
            else if(alege.SelectedIndex==2)
            {
                showAll();
                labelNume.Text = "Nume produs: " + produseNealim.ElementAt(Produse.SelectedIndex).getDenumire();
                labelCateg.Text = "Categorie produs: " + produseNealim.ElementAt(Produse.SelectedIndex).getCategorie();
                labelPret.Text = "Pret produs: " + produseNealim.ElementAt(Produse.SelectedIndex).getPret();
                labelStoc.Text = "Stoc: " + produseNealim.ElementAt(Produse.SelectedIndex).getStoc();
                labelGarantie.Text = "Garantie produs: " + produseNealim.ElementAt(Produse.SelectedIndex).getGarantie();
            }
        }

        private void Shop_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs;
            StreamWriter sw;
            if (produseAlim.Count > 0)
            {
                fs = new FileStream("ProdAlim.txt", FileMode.Open);
                sw = new StreamWriter(fs);
                foreach (ProdAlimentar produs in produseAlim)
                {
                    sw.WriteLine(produs.getDenumire() + "," + produs.getCategorie() + "," + produs.getPret() + "," + produs.getStoc() + "," + produs.getValabilitate() + "," + produs.getEAN8() + "," + produs.getEAN13());
                }
                sw.Flush();
                sw.Close();
            }
            if (produseNealim.Count > 0)
            {
                fs = new FileStream("ProdNealim.txt", FileMode.Open);
                sw = new StreamWriter(fs);
                foreach (ProdNealimentar produs in produseNealim)
                {
                    sw.WriteLine(produs.getDenumire() + "," + produs.getCategorie() + "," + produs.getPret() + "," + produs.getStoc() + "," + produs.getGarantie() + "," + produs.getEAN8() + "," + produs.getEAN13());
                }
                sw.Flush();
                sw.Close();
            }
            int openForms = Application.OpenForms.Count;
            for (int i = 0; i < openForms; i++)
            {
                if (!Application.OpenForms.Equals(this))
                {
                    Application.OpenForms[i].Close();
                }
            }
        }

        private void adaugaCos_Click(object sender, EventArgs e)
        {
            int cant = 0;
            try
            {
                cant = Int32.Parse(textCantitate.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Introduceti cantitate valida", "Eroare");
                return;
            }
            if (alege.SelectedIndex == 1)
            {
                if (produseAlim.ElementAt(Produse.SelectedIndex).getStoc() < cant)
                {
                    MessageBox.Show("Stoc insuficient", "Eroare");
                }
                else
                {
                    produseAlim.ElementAt(Produse.SelectedIndex).getItem(cant);
                    shop.addProdAlim(produseAlim.ElementAt(Produse.SelectedIndex), cant);
                    MessageBox.Show("Produs adaugat!");
                }
            }
            else if(alege.SelectedIndex == 2)
            {
                if (produseNealim.ElementAt(Produse.SelectedIndex).getStoc() < cant)
                {
                    MessageBox.Show("Stoc insuficient", "Eroare");
                }
                else
                {
                    produseNealim.ElementAt(Produse.SelectedIndex).getItem(cant);
                    shop.addProdNealim(produseNealim.ElementAt(Produse.SelectedIndex), cant);
                    MessageBox.Show("Produs adaugat!");
                }
            }
        }

        private void schimbareClient_Click(object sender, EventArgs e)
        {
            new AlegeClient().Show();
        }

        private void finalizareComanda_Click(object sender, EventArgs e)
        {
            shop.comanda();
        }

        private void Informatii_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Ginga Raluca-Andreea\n Facultatea de Matematica\n Grupa: MI523");
        }

        void deseanazaEAN8()
        {
            float x = 35, y = 35;
            Produs prod;
            g.Clear(Color.White);
            if(alege.SelectedIndex == 1)
            {
                prod = produseAlim.ElementAt(Produse.SelectedIndex);
            }
            else
            {
                prod = produseNealim.ElementAt(Produse.SelectedIndex);
            }
            String[] EAN8 = new String[8];
            int n = prod.getEAN8();
            int i = 7;
            while(n!=0)
            {
                if(i>3)
                {
                    EAN8[i] = R[n % 10];
                }
                else
                {
                    EAN8[i] = L[n % 10];
                }
                i--;
                n /= 10;
            }
            g.DrawLine(myPen, x, y, x, y + 100);
            x += 2 * myPen.Width;
            g.DrawLine(myPen, x, y, x, y + 100);
            x += myPen.Width;
            foreach (String code in EAN8)
            {
                for (int j = 0; j < code.Length; j++)
                {
                    if (code.ElementAt(j) == '1')
                    {
                        g.DrawLine(myPen, x, y, x, y + 100 - f.Height/2);
                        x += myPen.Width;
                    }
                    else x += myPen.Width;
                }
            }
            g.DrawLine(myPen, x, y, x, y + 100);
            x += 2 * myPen.Width;
            g.DrawLine(myPen, x, y, x, y + 100);
            scanCode.Refresh();
        }

        void deseanazaEAN13()
        {
            float x = 35, y = 35;
            Produs prod;
            g.Clear(Color.White);
            if (alege.SelectedIndex == 1)
            {
                prod = produseAlim.ElementAt(Produse.SelectedIndex);
            }
            else
            {
                prod = produseNealim.ElementAt(Produse.SelectedIndex);
            }
            String[] EAN13 = new String[13];
            long n = prod.getEAN13();
            int i = 12;
            switch (n / 1000000000000)
            {
                case 0:
                    while (n != 0)
                    {
                        if (i > 6)
                        {
                            EAN13[i] = R[n % 10];
                        }
                        else
                        {
                            EAN13[i] = L[n % 10];
                        }
                        i--;
                        n /= 10;
                    }
                    break;
                case 1:
                    while (n != 0)
                    {
                        if (i > 6)
                        {
                            EAN13[i] = R[n % 10];
                        }
                        else
                        {
                            if (i < 2)
                            {
                                EAN13[i] = L[n % 10];
                            }
                            else if (i < 4)
                            {
                                EAN13[i] = G[n % 10];
                            }
                            else if(i < 5)
                            {
                                EAN13[i] = L[n % 10];
                            }
                            else
                            {
                                EAN13[i] = G[n % 10];
                            }
                        }
                        i--;
                        n /= 10;
                    }
                    break;
                case 2:
                    while (n != 0)
                    {
                        if (i > 6)
                        {
                            EAN13[i] = R[n % 10];
                        }
                        else
                        {
                            if (i < 2)
                            {
                                EAN13[i] = L[n % 10];
                            }
                            else if (i < 5)
                            {
                                EAN13[i] = G[n % 10];
                            }
                            else if (i < 6)
                            {
                                EAN13[i] = L[n % 10];
                            }
                            else
                            {
                                EAN13[i] = G[n % 10];
                            }
                        }
                        i--;
                        n /= 10;
                    }
                    break;
                case 3:
                    while (n != 0)
                    {
                        if (i > 6)
                        {
                            EAN13[i] = R[n % 10];
                        }
                        else
                        {
                            if (i < 2)
                            {
                                EAN13[i] = L[n % 10];
                            }
                            else if (i < 6)
                            {
                                EAN13[i] = G[n % 10];
                            }
                            else
                            {
                                EAN13[i] = L[n % 10];
                            }
                        }
                        i--;
                        n /= 10;
                    }
                    break;
                case 4:
                    while (n != 0)
                    {
                        if (i > 6)
                        {
                            EAN13[i] = R[n % 10];
                        }
                        else
                        {
                            if (i < 1)
                            {
                                EAN13[i] = L[n % 10];
                            }
                            else if (i < 2)
                            {
                                EAN13[i] = G[n % 10];
                            }
                            else if (i < 4)
                            {
                                EAN13[i] = L[n % 10];
                            }
                            else
                            {
                                EAN13[i] = G[n % 10];
                            }
                        }
                        i--;
                        n /= 10;
                    }
                    break;
                case 5:
                    while (n != 0)
                    {
                        if (i > 6)
                        {
                            EAN13[i] = R[n % 10];
                        }
                        else
                        {
                            if (i < 1)
                            {
                                EAN13[i] = L[n % 10];
                            }
                            else if (i < 3)
                            {
                                EAN13[i] = G[n % 10];
                            }
                            else if (i < 5)
                            {
                                EAN13[i] = L[n % 10];
                            }
                            else
                            {
                                EAN13[i] = G[n % 10];
                            }
                        }
                        i--;
                        n /= 10;
                    }
                    break;
                case 6:
                    while (n != 0)
                    {
                        if (i > 6)
                        {
                            EAN13[i] = R[n % 10];
                        }
                        else
                        {
                            if (i < 1)
                            {
                                EAN13[i] = L[n % 10];
                            }
                            else if (i < 4)
                            {
                                EAN13[i] = G[n % 10];
                            }
                            else
                            {
                                EAN13[i] = L[n % 10];
                            }
                        }
                        i--;
                        n /= 10;
                    }
                    break;
                case 7:
                    while (n != 0)
                    {
                        if (i > 6)
                        {
                            EAN13[i] = R[n % 10];
                        }
                        else
                        {
                            if (i < 1)
                            {
                                EAN13[i] = L[n % 10];
                            }
                            else if (i < 2)
                            {
                                EAN13[i] = G[n % 10];
                            }
                            else if (i < 3)
                            {
                                EAN13[i] = L[n % 10];
                            }
                            else if (i < 4) 
                            {
                                EAN13[i] = G[n % 10];
                            }
                            else if (i < 5)
                            {
                                EAN13[i] = L[n % 10];
                            }
                            else
                            {
                                EAN13[i] = G[n % 100];
                            }
                        }
                        i--;
                        n /= 10;
                    }
                    break;
                case 8:
                    while (n != 0)
                    {
                        if (i > 6)
                        {
                            EAN13[i] = R[n % 10];
                        }
                        else
                        {
                            if (i < 1)
                            {
                                EAN13[i] = L[n % 10];
                            }
                            else if (i < 2)
                            {
                                EAN13[i] = G[n % 10];
                            }
                            else if (i < 3)
                            {
                                EAN13[i] = L[n % 10];
                            }
                            else if (i < 5) 
                            {
                                EAN13[i] = G[n % 10];
                            }
                            else
                            {
                                EAN13[i] = L[n % 10];
                            }
                        }
                        i--;
                        n /= 10;
                    }
                    break;
                case 9:
                    while (n != 0)
                    {
                        if (i > 6)
                        {
                            EAN13[i] = R[n % 10];
                        }
                        else
                        {
                            if (i < 1)
                            {
                                EAN13[i] = L[n % 10];
                            }
                            else if (i < 3)
                            {
                                EAN13[i] = G[n % 10];
                            }
                            else if (i < 4)
                            {
                                EAN13[i] = L[n % 10];
                            }
                            else if (i < 5) 
                            {
                                EAN13[i] = G[n % 10];
                            }
                            else
                            {
                                EAN13[i] = L[n % 10];
                            }
                        }
                        i--;
                        n /= 10;
                    }
                    break;

            }
            g.DrawLine(myPen, x, y, x, y + 100);
            x += 2 * myPen.Width;
            g.DrawLine(myPen, x, y, x, y + 100);
            x += myPen.Width;
            foreach (String code in EAN13)
            {
                for (int j = 0; j < code.Length; j++)
                {
                    if (code.ElementAt(j) == '1')
                    {
                        g.DrawLine(myPen, x, y, x, y + 100 - f.Height / 2);
                        x += myPen.Width;
                    }
                    else x += myPen.Width;
                }
            }
            g.DrawLine(myPen, x, y, x, y + 100);
            x += 2 * myPen.Width;
            g.DrawLine(myPen, x, y, x, y + 100);
            scanCode.Refresh();
        }

        void deseneazaQR() //folosind pachetul QRCoder
        {
            g.Clear(Color.White);
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(labelNume.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            qrImg = code.GetGraphic(5);
            qrImg = resizeImage(qrImg, 150, 150);
            g.DrawImage(qrImg, 0, 0);
            scanCode.Refresh();
        }

        private void btnEAN8_Click(object sender, EventArgs e)
        {
            deseanazaEAN8();
        }

        private void btnEAN13_Click(object sender, EventArgs e)
        {
            deseanazaEAN13();
        }
        

        private void scanCode_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0);
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            deseneazaQR();
        }

        private void saveProductCode_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter += "jpeg file (*.jpeg)|*.jpeg";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(img);
                bmp.Save(dialog.FileName, ImageFormat.Jpeg);
            }
        }

        public static Bitmap resizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
