namespace WindowsFormsApp2
{
    partial class FormAddMusteri
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTCKN;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblKayitTarihi;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTCKN;
        private System.Windows.Forms.ComboBox comboTur;
        private System.Windows.Forms.DateTimePicker dateTimePickerKayit;
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
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTCKN = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblKayitTarihi = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTCKN = new System.Windows.Forms.TextBox();
            this.comboTur = new System.Windows.Forms.ComboBox();
            this.dateTimePickerKayit = new System.Windows.Forms.DateTimePicker();
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
            this.lblAd.TabIndex = 15;
            this.lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(12, 60);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(47, 16);
            this.lblSoyad.TabIndex = 13;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(12, 100);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(53, 16);
            this.lblTelefon.TabIndex = 11;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(12, 140);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(32, 16);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "Mail";
            // 
            // lblTCKN
            // 
            this.lblTCKN.AutoSize = true;
            this.lblTCKN.Location = new System.Drawing.Point(12, 180);
            this.lblTCKN.Name = "lblTCKN";
            this.lblTCKN.Size = new System.Drawing.Size(43, 16);
            this.lblTCKN.TabIndex = 7;
            this.lblTCKN.Text = "TCKN";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(12, 220);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(27, 16);
            this.lblTur.TabIndex = 5;
            this.lblTur.Text = "Tür";
            // 
            // lblKayitTarihi
            // 
            this.lblKayitTarihi.AutoSize = true;
            this.lblKayitTarihi.Location = new System.Drawing.Point(12, 260);
            this.lblKayitTarihi.Name = "lblKayitTarihi";
            this.lblKayitTarihi.Size = new System.Drawing.Size(73, 16);
            this.lblKayitTarihi.TabIndex = 3;
            this.lblKayitTarihi.Text = "Kayıt Tarihi";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(120, 17);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 22);
            this.txtAd.TabIndex = 14;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(120, 57);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 22);
            this.txtSoyad.TabIndex = 12;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(120, 97);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 22);
            this.txtTelefon.TabIndex = 10;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(120, 137);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(200, 22);
            this.txtMail.TabIndex = 8;
            // 
            // txtTCKN
            // 
            this.txtTCKN.Location = new System.Drawing.Point(120, 177);
            this.txtTCKN.Name = "txtTCKN";
            this.txtTCKN.Size = new System.Drawing.Size(200, 22);
            this.txtTCKN.TabIndex = 6;
            // 
            // comboTur
            // 
            this.comboTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTur.FormattingEnabled = true;
            this.comboTur.Items.AddRange(new object[] {
            "Bireysel",
            "Kurumsal"});
            this.comboTur.Location = new System.Drawing.Point(120, 217);
            this.comboTur.Name = "comboTur";
            this.comboTur.Size = new System.Drawing.Size(200, 24);
            this.comboTur.TabIndex = 4;
            // 
            // dateTimePickerKayit
            // 
            this.dateTimePickerKayit.Location = new System.Drawing.Point(120, 255);
            this.dateTimePickerKayit.Name = "dateTimePickerKayit";
            this.dateTimePickerKayit.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerKayit.TabIndex = 2;
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(120, 300);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 1;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(245, 300);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 0;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // FormAddMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 350);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.dateTimePickerKayit);
            this.Controls.Add(this.lblKayitTarihi);
            this.Controls.Add(this.comboTur);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.txtTCKN);
            this.Controls.Add(this.lblTCKN);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Name = "FormAddMusteri";
            this.Text = "Müşteri Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

            // ... your existing controls for name, phone, etc. ...

            this.btnTamam = new System.Windows.Forms.Button();
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(200, 300);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(80, 30);
            this.btnTamam.TabIndex = 10;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);

            this.Controls.Add(this.btnTamam);

        }
    }
}
