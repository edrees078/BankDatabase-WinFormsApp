namespace WindowsFormsApp2
{
    partial class FormAddIslem
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblHesapID;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.TextBox txtHesapID;
        private System.Windows.Forms.ComboBox comboTur;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DateTimePicker dateTimePickerTarih;
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
            this.lblHesapID = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.txtHesapID = new System.Windows.Forms.TextBox();
            this.comboTur = new System.Windows.Forms.ComboBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dateTimePickerTarih = new System.Windows.Forms.DateTimePicker();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHesapID
            // 
            this.lblHesapID.AutoSize = true;
            this.lblHesapID.Location = new System.Drawing.Point(12, 20);
            this.lblHesapID.Name = "lblHesapID";
            this.lblHesapID.Size = new System.Drawing.Size(65, 16);
            this.lblHesapID.TabIndex = 0;
            this.lblHesapID.Text = "Hesap ID:";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(12, 60);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(28, 16);
            this.lblTur.TabIndex = 1;
            this.lblTur.Text = "Tür:";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(12, 100);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(41, 16);
            this.lblTutar.TabIndex = 2;
            this.lblTutar.Text = "Tutar:";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(12, 140);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(62, 16);
            this.lblAciklama.TabIndex = 3;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(12, 180);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(41, 16);
            this.lblTarih.TabIndex = 4;
            this.lblTarih.Text = "Tarih:";
            // 
            // txtHesapID
            // 
            this.txtHesapID.Location = new System.Drawing.Point(120, 17);
            this.txtHesapID.Name = "txtHesapID";
            this.txtHesapID.Size = new System.Drawing.Size(200, 22);
            this.txtHesapID.TabIndex = 5;
            // 
            // comboTur
            // 
            this.comboTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTur.FormattingEnabled = true;
            this.comboTur.Items.AddRange(new object[] {
            "Havale",
            "EFT",
            "Yatırım",
            "Ödeme"});
            this.comboTur.Location = new System.Drawing.Point(120, 57);
            this.comboTur.Name = "comboTur";
            this.comboTur.Size = new System.Drawing.Size(200, 24);
            this.comboTur.TabIndex = 6;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(120, 97);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(200, 22);
            this.txtTutar.TabIndex = 7;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(120, 137);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 22);
            this.txtAciklama.TabIndex = 8;
            // 
            // dateTimePickerTarih
            // 
            this.dateTimePickerTarih.Location = new System.Drawing.Point(120, 177);
            this.dateTimePickerTarih.Name = "dateTimePickerTarih";
            this.dateTimePickerTarih.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTarih.TabIndex = 9;
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
            // FormAddIslem
            // 
            this.ClientSize = new System.Drawing.Size(348, 270);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.dateTimePickerTarih);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.comboTur);
            this.Controls.Add(this.txtHesapID);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblHesapID);
            this.Name = "FormAddIslem";
            this.Text = "İşlem Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
