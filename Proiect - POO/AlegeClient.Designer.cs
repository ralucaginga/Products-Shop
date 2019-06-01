namespace Proiect___POO
{
    partial class AlegeClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.listClient = new System.Windows.Forms.ListBox();
            this.AdaugaClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alege un client";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listClient
            // 
            this.listClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listClient.FormattingEnabled = true;
            this.listClient.ItemHeight = 20;
            this.listClient.Location = new System.Drawing.Point(42, 84);
            this.listClient.Margin = new System.Windows.Forms.Padding(4);
            this.listClient.Name = "listClient";
            this.listClient.Size = new System.Drawing.Size(333, 304);
            this.listClient.TabIndex = 2;
            this.listClient.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listClient_MouseDoubleClick_1);
            // 
            // AdaugaClient
            // 
            this.AdaugaClient.Location = new System.Drawing.Point(124, 419);
            this.AdaugaClient.Margin = new System.Windows.Forms.Padding(4);
            this.AdaugaClient.Name = "AdaugaClient";
            this.AdaugaClient.Size = new System.Drawing.Size(163, 62);
            this.AdaugaClient.TabIndex = 4;
            this.AdaugaClient.Text = "Creare client";
            this.AdaugaClient.UseVisualStyleBackColor = true;
            this.AdaugaClient.Click += new System.EventHandler(this.AdaugaClient_Click);
            // 
            // AlegeClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 510);
            this.Controls.Add(this.AdaugaClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listClient);
            this.Name = "AlegeClient";
            this.Text = "AlegeClient";
            this.Load += new System.EventHandler(this.AlegeClient_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listClient;
        private System.Windows.Forms.Button AdaugaClient;
    }
}