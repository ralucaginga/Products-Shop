namespace Proiect___POO
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.pictureFactura = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveFIle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimare = new System.Windows.Forms.ToolStripButton();
            this.pd = new System.Windows.Forms.PrintDialog();
            this.print = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFactura)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureFactura
            // 
            this.pictureFactura.Location = new System.Drawing.Point(12, 59);
            this.pictureFactura.Name = "pictureFactura";
            this.pictureFactura.Size = new System.Drawing.Size(843, 842);
            this.pictureFactura.TabIndex = 0;
            this.pictureFactura.TabStop = false;
            this.pictureFactura.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureFactura_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFIle,
            this.toolStripSeparator1,
            this.imprimare});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(867, 47);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveFIle
            // 
            this.saveFIle.AutoSize = false;
            this.saveFIle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveFIle.Image = ((System.Drawing.Image)(resources.GetObject("saveFIle.Image")));
            this.saveFIle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveFIle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveFIle.Name = "saveFIle";
            this.saveFIle.Size = new System.Drawing.Size(58, 58);
            this.saveFIle.Text = "Salveaza Factura";
            this.saveFIle.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 47);
            // 
            // imprimare
            // 
            this.imprimare.AutoSize = false;
            this.imprimare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprimare.Image = ((System.Drawing.Image)(resources.GetObject("imprimare.Image")));
            this.imprimare.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.imprimare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimare.Name = "imprimare";
            this.imprimare.Size = new System.Drawing.Size(58, 58);
            this.imprimare.Text = "Printeaza factura";
            this.imprimare.Click += new System.EventHandler(this.imprimare_Click);
            // 
            // pd
            // 
            this.pd.UseEXDialog = true;
            // 
            // print
            // 
            this.print.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.print_EndPrint);
            this.print.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.print_PrintPage);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 915);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureFactura);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFactura)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureFactura;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveFIle;
        private System.Windows.Forms.PrintDialog pd;
        private System.Drawing.Printing.PrintDocument print;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton imprimare;
    }
}