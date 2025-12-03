namespace WindowsFormsApp2
{
    partial class FormIslemDetay
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblHesapID;
        private System.Windows.Forms.Label lblIslemTuru;
        private System.Windows.Forms.Label lblIslemTutari;
        private System.Windows.Forms.Label lblIslemAciklama;
        private System.Windows.Forms.Label lblIslemTarihi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHesapID = new System.Windows.Forms.Label();
            this.lblIslemTuru = new System.Windows.Forms.Label();
            this.lblIslemTutari = new System.Windows.Forms.Label();
            this.lblIslemAciklama = new System.Windows.Forms.Label();
            this.lblIslemTarihi = new System.Windows.Forms.Label();

            // 
            // lblHesapID
            // 
            this.lblHesapID.Location = new System.Drawing.Point(20, 20);
            this.lblHesapID.Name = "lblHesapID";
            this.lblHesapID.Size = new System.Drawing.Size(300, 20);
            this.lblHesapID.Text = "Hesap ID:";

            // 
            // lblIslemTuru
            // 
            this.lblIslemTuru.Location = new System.Drawing.Point(20, 60);
            this.lblIslemTuru.Name = "lblIslemTuru";
            this.lblIslemTuru.Size = new System.Drawing.Size(300, 20);
            this.lblIslemTuru.Text = "İşlem Türü:";

            // 
            // lblIslemTutari
            // 
            this.lblIslemTutari.Location = new System.Drawing.Point(20, 100);
            this.lblIslemTutari.Name = "lblIslemTutari";
            this.lblIslemTutari.Size = new System.Drawing.Size(300, 20);
            this.lblIslemTutari.Text = "İşlem Tutarı:";

            // 
            // lblIslemAciklama
            // 
            this.lblIslemAciklama.Location = new System.Drawing.Point(20, 140);
            this.lblIslemAciklama.Name = "lblIslemAciklama";
            this.lblIslemAciklama.Size = new System.Drawing.Size(300, 20);
            this.lblIslemAciklama.Text = "Açıklama:";

            // 
            // lblIslemTarihi
            // 
            this.lblIslemTarihi.Location = new System.Drawing.Point(20, 180);
            this.lblIslemTarihi.Name = "lblIslemTarihi";
            this.lblIslemTarihi.Size = new System.Drawing.Size(300, 20);
            this.lblIslemTarihi.Text = "Tarih:";

            // 
            // FormIslemDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.lblHesapID);
            this.Controls.Add(this.lblIslemTuru);
            this.Controls.Add(this.lblIslemTutari);
            this.Controls.Add(this.lblIslemAciklama);
            this.Controls.Add(this.lblIslemTarihi);
            this.Name = "FormIslemDetay";
            this.Text = "İşlem Detay";
            this.Load += new System.EventHandler(this.FormIslemDetay_Load);
        }
    }
}
