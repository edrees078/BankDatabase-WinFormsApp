namespace WindowsFormsApp2
{
    partial class FormHesapDetay
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblHesapID;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label lblAcilisTarihi;
        private System.Windows.Forms.Label lblDurum;

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
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.lblAcilisTarihi = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHesapID
            // 
            this.lblHesapID.AutoSize = true;
            this.lblHesapID.Location = new System.Drawing.Point(20, 20);
            this.lblHesapID.Name = "lblHesapID";
            this.lblHesapID.Size = new System.Drawing.Size(72, 17);
            this.lblHesapID.TabIndex = 0;
            this.lblHesapID.Text = "hesap ID:";
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Location = new System.Drawing.Point(20, 60);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(77, 17);
            this.lblMusteriID.TabIndex = 1;
            this.lblMusteriID.Text = "Müşteri ID:";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(20, 100);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(33, 17);
            this.lblTur.TabIndex = 2;
            this.lblTur.Text = "Tür:";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(20, 140);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(54, 17);
            this.lblBakiye.TabIndex = 3;
            this.lblBakiye.Text = "Bakiye:";
            // 
            // lblAcilisTarihi
            // 
            this.lblAcilisTarihi.AutoSize = true;
            this.lblAcilisTarihi.Location = new System.Drawing.Point(20, 180);
            this.lblAcilisTarihi.Name = "lblAcilisTarihi";
            this.lblAcilisTarihi.Size = new System.Drawing.Size(84, 17);
            this.lblAcilisTarihi.TabIndex = 4;
            this.lblAcilisTarihi.Text = "Açılış Tarihi:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(20, 220);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(52, 17);
            this.lblDurum.TabIndex = 5;
            this.lblDurum.Text = "Durum:";
            // 
            // FormHesapDetay
            // 
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblAcilisTarihi);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblMusteriID);
            this.Controls.Add(this.lblHesapID);
            this.Name = "FormHesapDetay";
            this.Text = "Hesap Detay";
            this.Load += new System.EventHandler(this.FormHesapDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
