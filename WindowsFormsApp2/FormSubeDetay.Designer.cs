namespace WindowsFormsApp2
{
    partial class FormSubeDetay
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblSubeID;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblAdresi;
        private System.Windows.Forms.Label lblTelefonu;

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
            this.lblSubeID = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblAdresi = new System.Windows.Forms.Label();
            this.lblTelefonu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSubeID
            // 
            this.lblSubeID.AutoSize = true;
            this.lblSubeID.Location = new System.Drawing.Point(20, 20);
            this.lblSubeID.Name = "lblSubeID";
            this.lblSubeID.Size = new System.Drawing.Size(63, 17);
            this.lblSubeID.TabIndex = 0;
            this.lblSubeID.Text = "Şube ID:";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(20, 60);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(31, 17);
            this.lblAdi.TabIndex = 1;
            this.lblAdi.Text = "Ad:";
            // 
            // lblAdresi
            // 
            this.lblAdresi.AutoSize = true;
            this.lblAdresi.Location = new System.Drawing.Point(20, 100);
            this.lblAdresi.Name = "lblAdresi";
            this.lblAdresi.Size = new System.Drawing.Size(51, 17);
            this.lblAdresi.TabIndex = 2;
            this.lblAdresi.Text = "Adresi:";
            // 
            // lblTelefonu
            // 
            this.lblTelefonu.AutoSize = true;
            this.lblTelefonu.Location = new System.Drawing.Point(20, 140);
            this.lblTelefonu.Name = "lblTelefonu";
            this.lblTelefonu.Size = new System.Drawing.Size(59, 17);
            this.lblTelefonu.TabIndex = 3;
            this.lblTelefonu.Text = "Telefon:";
            // 
            // FormSubeDetay
            // 
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.lblTelefonu);
            this.Controls.Add(this.lblAdresi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.lblSubeID);
            this.Name = "FormSubeDetay";
            this.Text = "Şube Detay";
            this.Load += new System.EventHandler(this.FormSubeDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
