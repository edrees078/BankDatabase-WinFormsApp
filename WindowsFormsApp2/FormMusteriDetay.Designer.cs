namespace WindowsFormsApp2
{
    partial class FormMusteriDetay
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.Label lblTCKN;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblKayitTarihi;

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
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblEposta = new System.Windows.Forms.Label();
            this.lblTCKN = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblKayitTarihi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(20, 20);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(31, 17);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad: ";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(20, 60);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(53, 17);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad: ";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(20, 100);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(59, 17);
            this.lblTelefon.TabIndex = 2;
            this.lblTelefon.Text = "Telefon: ";
            // 
            // lblEposta
            // 
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(20, 140);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(59, 17);
            this.lblEposta.TabIndex = 3;
            this.lblEposta.Text = "E-posta:";
            // 
            // lblTCKN
            // 
            this.lblTCKN.AutoSize = true;
            this.lblTCKN.Location = new System.Drawing.Point(20, 180);
            this.lblTCKN.Name = "lblTCKN";
            this.lblTCKN.Size = new System.Drawing.Size(120, 17);
            this.lblTCKN.TabIndex = 4;
            this.lblTCKN.Text = "TCKN / Şirket No:";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(20, 220);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(34, 17);
            this.lblTur.TabIndex = 5;
            this.lblTur.Text = "Tür:";
            // 
            // lblKayitTarihi
            // 
            this.lblKayitTarihi.AutoSize = true;
            this.lblKayitTarihi.Location = new System.Drawing.Point(20, 260);
            this.lblKayitTarihi.Name = "lblKayitTarihi";
            this.lblKayitTarihi.Size = new System.Drawing.Size(84, 17);
            this.lblKayitTarihi.TabIndex = 6;
            this.lblKayitTarihi.Text = "Kayıt Tarihi:";
            // 
            // FormMusteriDetay
            // 
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.lblKayitTarihi);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblTCKN);
            this.Controls.Add(this.lblEposta);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Name = "FormMusteriDetay";
            this.Text = "Müşteri Detay";
            this.Load += new System.EventHandler(this.FormMusteriDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
