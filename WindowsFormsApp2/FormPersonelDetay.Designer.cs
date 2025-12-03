namespace WindowsFormsApp2
{
    partial class FormPersonelDetay
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblPersonelID;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.Label lblSoyisim;
        private System.Windows.Forms.Label lblGorev;
        private System.Windows.Forms.Label lblSubeID;
        private System.Windows.Forms.Label lblCalismaTarihi;

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
            this.lblPersonelID = new System.Windows.Forms.Label();
            this.lblIsim = new System.Windows.Forms.Label();
            this.lblSoyisim = new System.Windows.Forms.Label();
            this.lblGorev = new System.Windows.Forms.Label();
            this.lblSubeID = new System.Windows.Forms.Label();
            this.lblCalismaTarihi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPersonelID
            // 
            this.lblPersonelID.AutoSize = true;
            this.lblPersonelID.Location = new System.Drawing.Point(20, 20);
            this.lblPersonelID.Name = "lblPersonelID";
            this.lblPersonelID.Size = new System.Drawing.Size(88, 17);
            this.lblPersonelID.TabIndex = 0;
            this.lblPersonelID.Text = "Personel ID:";
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(20, 60);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(36, 17);
            this.lblIsim.TabIndex = 1;
            this.lblIsim.Text = "Ad: ";
            // 
            // lblSoyisim
            // 
            this.lblSoyisim.AutoSize = true;
            this.lblSoyisim.Location = new System.Drawing.Point(20, 100);
            this.lblSoyisim.Name = "lblSoyisim";
            this.lblSoyisim.Size = new System.Drawing.Size(53, 17);
            this.lblSoyisim.TabIndex = 2;
            this.lblSoyisim.Text = "Soyad:";
            // 
            // lblGorev
            // 
            this.lblGorev.AutoSize = true;
            this.lblGorev.Location = new System.Drawing.Point(20, 140);
            this.lblGorev.Name = "lblGorev";
            this.lblGorev.Size = new System.Drawing.Size(49, 17);
            this.lblGorev.TabIndex = 3;
            this.lblGorev.Text = "Görev:";
            // 
            // lblSubeID
            // 
            this.lblSubeID.AutoSize = true;
            this.lblSubeID.Location = new System.Drawing.Point(20, 180);
            this.lblSubeID.Name = "lblSubeID";
            this.lblSubeID.Size = new System.Drawing.Size(64, 17);
            this.lblSubeID.TabIndex = 4;
            this.lblSubeID.Text = "Şube ID:";
            // 
            // lblCalismaTarihi
            // 
            this.lblCalismaTarihi.AutoSize = true;
            this.lblCalismaTarihi.Location = new System.Drawing.Point(20, 220);
            this.lblCalismaTarihi.Name = "lblCalismaTarihi";
            this.lblCalismaTarihi.Size = new System.Drawing.Size(100, 17);
            this.lblCalismaTarihi.TabIndex = 5;
            this.lblCalismaTarihi.Text = "Çalışma Tarihi:";
            // 
            // FormPersonelDetay
            // 
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.lblCalismaTarihi);
            this.Controls.Add(this.lblSubeID);
            this.Controls.Add(this.lblGorev);
            this.Controls.Add(this.lblSoyisim);
            this.Controls.Add(this.lblIsim);
            this.Controls.Add(this.lblPersonelID);
            this.Name = "FormPersonelDetay";
            this.Text = "Personel Detay";
            this.Load += new System.EventHandler(this.FormPersonelDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
