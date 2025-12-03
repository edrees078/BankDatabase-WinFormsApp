namespace WindowsFormsApp2
{
    partial class FormAddPersonel
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblGorev;
        private System.Windows.Forms.Label lblSubeID;
        private System.Windows.Forms.Label lblCalismaTarihi;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtGorev;
        private System.Windows.Forms.TextBox txtSubeID;
        private System.Windows.Forms.DateTimePicker dateTimePickerCalismaTarihi;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btnIptal;

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
            this.lblGorev = new System.Windows.Forms.Label();
            this.lblSubeID = new System.Windows.Forms.Label();
            this.lblCalismaTarihi = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtGorev = new System.Windows.Forms.TextBox();
            this.txtSubeID = new System.Windows.Forms.TextBox();
            this.dateTimePickerCalismaTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(12, 20);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(24, 16);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(12, 60);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(47, 16);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblGorev
            // 
            this.lblGorev.AutoSize = true;
            this.lblGorev.Location = new System.Drawing.Point(12, 100);
            this.lblGorev.Name = "lblGorev";
            this.lblGorev.Size = new System.Drawing.Size(44, 16);
            this.lblGorev.TabIndex = 2;
            this.lblGorev.Text = "Görev";
            // 
            // lblSubeID
            // 
            this.lblSubeID.AutoSize = true;
            this.lblSubeID.Location = new System.Drawing.Point(12, 140);
            this.lblSubeID.Name = "lblSubeID";
            this.lblSubeID.Size = new System.Drawing.Size(52, 16);
            this.lblSubeID.TabIndex = 3;
            this.lblSubeID.Text = "Şube ID";
            // 
            // lblCalismaTarihi
            // 
            this.lblCalismaTarihi.AutoSize = true;
            this.lblCalismaTarihi.Location = new System.Drawing.Point(12, 180);
            this.lblCalismaTarihi.Name = "lblCalismaTarihi";
            this.lblCalismaTarihi.Size = new System.Drawing.Size(89, 16);
            this.lblCalismaTarihi.TabIndex = 4;
            this.lblCalismaTarihi.Text = "Çalışma Tarihi";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(120, 17);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 22);
            this.txtAd.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(120, 57);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 22);
            this.txtSoyad.TabIndex = 6;
            // 
            // txtGorev
            // 
            this.txtGorev.Location = new System.Drawing.Point(120, 97);
            this.txtGorev.Name = "txtGorev";
            this.txtGorev.Size = new System.Drawing.Size(200, 22);
            this.txtGorev.TabIndex = 7;
            // 
            // txtSubeID
            // 
            this.txtSubeID.Location = new System.Drawing.Point(120, 137);
            this.txtSubeID.Name = "txtSubeID";
            this.txtSubeID.Size = new System.Drawing.Size(200, 22);
            this.txtSubeID.TabIndex = 8;
            // 
            // dateTimePickerCalismaTarihi
            // 
            this.dateTimePickerCalismaTarihi.Location = new System.Drawing.Point(120, 177);
            this.dateTimePickerCalismaTarihi.Name = "dateTimePickerCalismaTarihi";
            this.dateTimePickerCalismaTarihi.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerCalismaTarihi.TabIndex = 9;
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(120, 220);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 30);
            this.btnTamam.TabIndex = 10;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(245, 220);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 30);
            this.btnIptal.TabIndex = 11;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // FormAddPersonel
            // 
            this.ClientSize = new System.Drawing.Size(348, 270);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.dateTimePickerCalismaTarihi);
            this.Controls.Add(this.lblCalismaTarihi);
            this.Controls.Add(this.txtSubeID);
            this.Controls.Add(this.lblSubeID);
            this.Controls.Add(this.txtGorev);
            this.Controls.Add(this.lblGorev);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Name = "FormAddPersonel";
            this.Text = "Personel Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
