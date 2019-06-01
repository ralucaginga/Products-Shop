namespace Proiect___POO
{
    partial class Shop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shop));
            this.labelGarantie = new System.Windows.Forms.Label();
            this.adaugaCos = new System.Windows.Forms.Button();
            this.textCantitate = new System.Windows.Forms.TextBox();
            this.labelCantitate = new System.Windows.Forms.Label();
            this.labelStoc = new System.Windows.Forms.Label();
            this.labelPret = new System.Windows.Forms.Label();
            this.labelCateg = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.alege = new System.Windows.Forms.ComboBox();
            this.Produse = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.schimbareClient = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.finalizareComanda = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Informatii = new System.Windows.Forms.ToolStripButton();
            this.btnEAN8 = new System.Windows.Forms.Button();
            this.btnEAN13 = new System.Windows.Forms.Button();
            this.scanCode = new System.Windows.Forms.PictureBox();
            this.btnQR = new System.Windows.Forms.Button();
            this.saveProductCode = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scanCode)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGarantie
            // 
            this.labelGarantie.Location = new System.Drawing.Point(581, 234);
            this.labelGarantie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGarantie.Name = "labelGarantie";
            this.labelGarantie.Size = new System.Drawing.Size(473, 43);
            this.labelGarantie.TabIndex = 32;
            this.labelGarantie.Text = "Valabilitate:";
            this.labelGarantie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // adaugaCos
            // 
            this.adaugaCos.Location = new System.Drawing.Point(868, 269);
            this.adaugaCos.Margin = new System.Windows.Forms.Padding(4);
            this.adaugaCos.Name = "adaugaCos";
            this.adaugaCos.Size = new System.Drawing.Size(156, 47);
            this.adaugaCos.TabIndex = 31;
            this.adaugaCos.Text = "Adauga in cos";
            this.adaugaCos.UseVisualStyleBackColor = true;
            this.adaugaCos.Click += new System.EventHandler(this.adaugaCos_Click);
            // 
            // textCantitate
            // 
            this.textCantitate.Location = new System.Drawing.Point(681, 281);
            this.textCantitate.Margin = new System.Windows.Forms.Padding(4);
            this.textCantitate.Name = "textCantitate";
            this.textCantitate.Size = new System.Drawing.Size(132, 22);
            this.textCantitate.TabIndex = 30;
            // 
            // labelCantitate
            // 
            this.labelCantitate.Location = new System.Drawing.Point(581, 277);
            this.labelCantitate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCantitate.Name = "labelCantitate";
            this.labelCantitate.Size = new System.Drawing.Size(92, 28);
            this.labelCantitate.TabIndex = 29;
            this.labelCantitate.Text = "Cantitate:";
            this.labelCantitate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStoc
            // 
            this.labelStoc.Location = new System.Drawing.Point(581, 195);
            this.labelStoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStoc.Name = "labelStoc";
            this.labelStoc.Size = new System.Drawing.Size(473, 39);
            this.labelStoc.TabIndex = 28;
            this.labelStoc.Text = "Stoc:";
            this.labelStoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPret
            // 
            this.labelPret.Location = new System.Drawing.Point(581, 166);
            this.labelPret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPret.Name = "labelPret";
            this.labelPret.Size = new System.Drawing.Size(473, 29);
            this.labelPret.TabIndex = 27;
            this.labelPret.Text = "Pret:";
            this.labelPret.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCateg
            // 
            this.labelCateg.Location = new System.Drawing.Point(581, 127);
            this.labelCateg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCateg.Name = "labelCateg";
            this.labelCateg.Size = new System.Drawing.Size(473, 26);
            this.labelCateg.TabIndex = 26;
            this.labelCateg.Text = "Categorie:";
            this.labelCateg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNume
            // 
            this.labelNume.Location = new System.Drawing.Point(581, 85);
            this.labelNume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(473, 26);
            this.labelNume.TabIndex = 23;
            this.labelNume.Text = "Nume Produs:";
            this.labelNume.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // alege
            // 
            this.alege.FormattingEnabled = true;
            this.alege.Location = new System.Drawing.Point(31, 85);
            this.alege.Name = "alege";
            this.alege.Size = new System.Drawing.Size(524, 24);
            this.alege.TabIndex = 22;
            this.alege.SelectedIndexChanged += new System.EventHandler(this.alege_SelectedIndexChanged);
            // 
            // Produse
            // 
            this.Produse.FormattingEnabled = true;
            this.Produse.ItemHeight = 16;
            this.Produse.Location = new System.Drawing.Point(30, 127);
            this.Produse.Name = "Produse";
            this.Produse.Size = new System.Drawing.Size(525, 548);
            this.Produse.TabIndex = 21;
            this.Produse.SelectedIndexChanged += new System.EventHandler(this.Produse_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schimbareClient,
            this.toolStripSeparator1,
            this.finalizareComanda,
            this.toolStripSeparator2,
            this.Informatii});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1231, 71);
            this.toolStrip1.TabIndex = 33;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // schimbareClient
            // 
            this.schimbareClient.AutoSize = false;
            this.schimbareClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.schimbareClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.schimbareClient.DoubleClickEnabled = true;
            this.schimbareClient.Image = ((System.Drawing.Image)(resources.GetObject("schimbareClient.Image")));
            this.schimbareClient.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.schimbareClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.schimbareClient.Name = "schimbareClient";
            this.schimbareClient.Size = new System.Drawing.Size(68, 68);
            this.schimbareClient.Text = "Schimbare Client";
            this.schimbareClient.Click += new System.EventHandler(this.schimbareClient_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // finalizareComanda
            // 
            this.finalizareComanda.AutoSize = false;
            this.finalizareComanda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.finalizareComanda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.finalizareComanda.Image = ((System.Drawing.Image)(resources.GetObject("finalizareComanda.Image")));
            this.finalizareComanda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.finalizareComanda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.finalizareComanda.Name = "finalizareComanda";
            this.finalizareComanda.Size = new System.Drawing.Size(68, 68);
            this.finalizareComanda.Text = "Finalizare Comanda";
            this.finalizareComanda.Click += new System.EventHandler(this.finalizareComanda_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 71);
            // 
            // Informatii
            // 
            this.Informatii.AutoSize = false;
            this.Informatii.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Informatii.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Informatii.Image = ((System.Drawing.Image)(resources.GetObject("Informatii.Image")));
            this.Informatii.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Informatii.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Informatii.Name = "Informatii";
            this.Informatii.Size = new System.Drawing.Size(68, 68);
            this.Informatii.Text = "Informatii";
            this.Informatii.Click += new System.EventHandler(this.Informatii_Click);
            // 
            // btnEAN8
            // 
            this.btnEAN8.Location = new System.Drawing.Point(610, 347);
            this.btnEAN8.Name = "btnEAN8";
            this.btnEAN8.Size = new System.Drawing.Size(113, 47);
            this.btnEAN8.TabIndex = 34;
            this.btnEAN8.Text = "EAN 8";
            this.btnEAN8.UseVisualStyleBackColor = true;
            this.btnEAN8.Click += new System.EventHandler(this.btnEAN8_Click);
            // 
            // btnEAN13
            // 
            this.btnEAN13.Location = new System.Drawing.Point(799, 347);
            this.btnEAN13.Name = "btnEAN13";
            this.btnEAN13.Size = new System.Drawing.Size(113, 47);
            this.btnEAN13.TabIndex = 35;
            this.btnEAN13.Text = "EAN 13";
            this.btnEAN13.UseVisualStyleBackColor = true;
            this.btnEAN13.Click += new System.EventHandler(this.btnEAN13_Click);
            // 
            // scanCode
            // 
            this.scanCode.Location = new System.Drawing.Point(584, 402);
            this.scanCode.Name = "scanCode";
            this.scanCode.Size = new System.Drawing.Size(555, 225);
            this.scanCode.TabIndex = 36;
            this.scanCode.TabStop = false;
            this.scanCode.Paint += new System.Windows.Forms.PaintEventHandler(this.scanCode_Paint);
            // 
            // btnQR
            // 
            this.btnQR.Location = new System.Drawing.Point(1009, 347);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(113, 47);
            this.btnQR.TabIndex = 37;
            this.btnQR.Text = "QR Code";
            this.btnQR.UseVisualStyleBackColor = true;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // saveProductCode
            // 
            this.saveProductCode.Location = new System.Drawing.Point(790, 642);
            this.saveProductCode.Name = "saveProductCode";
            this.saveProductCode.Size = new System.Drawing.Size(161, 44);
            this.saveProductCode.TabIndex = 38;
            this.saveProductCode.Text = "Salveaza Cod Produs";
            this.saveProductCode.UseVisualStyleBackColor = true;
            this.saveProductCode.Click += new System.EventHandler(this.saveProductCode_Click);
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 698);
            this.Controls.Add(this.saveProductCode);
            this.Controls.Add(this.btnQR);
            this.Controls.Add(this.scanCode);
            this.Controls.Add(this.btnEAN13);
            this.Controls.Add(this.btnEAN8);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelGarantie);
            this.Controls.Add(this.adaugaCos);
            this.Controls.Add(this.textCantitate);
            this.Controls.Add(this.labelCantitate);
            this.Controls.Add(this.labelStoc);
            this.Controls.Add(this.labelPret);
            this.Controls.Add(this.labelCateg);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.alege);
            this.Controls.Add(this.Produse);
            this.Name = "Shop";
            this.Text = "Shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Shop_FormClosing);
            this.Load += new System.EventHandler(this.Shop_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scanCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGarantie;
        private System.Windows.Forms.Button adaugaCos;
        private System.Windows.Forms.TextBox textCantitate;
        private System.Windows.Forms.Label labelCantitate;
        private System.Windows.Forms.Label labelStoc;
        private System.Windows.Forms.Label labelPret;
        private System.Windows.Forms.Label labelCateg;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.ComboBox alege;
        private System.Windows.Forms.ListBox Produse;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton schimbareClient;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton finalizareComanda;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Informatii;
        private System.Windows.Forms.Button btnEAN8;
        private System.Windows.Forms.Button btnEAN13;
        private System.Windows.Forms.PictureBox scanCode;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.Button saveProductCode;
    }
}