namespace WindowsFormsApp2
{
    partial class FormEditIslem
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblHesapID;
        private System.Windows.Forms.TextBox txtHesapID;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnKaydet;
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
            this.txtHesapID = new System.Windows.Forms.TextBox();
            this.lblTur = new System.Windows.Forms.Label();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.lblTarih = new System.Windows.Forms.Label();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblTutar = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHesapID
            // 
            this.lblHesapID.AutoSize = true;
            this.lblHesapID.Location = new System.Drawing.Point(20, 20);
            this.lblHesapID.Name = "lblHesapID";
            this.lblHesapID.Size = new System.Drawing.Size(72, 17);
            this.lblHesapID.TabIndex = 0;
            this.lblHesapID.Text = "Hesap ID:";
            // 
            // txtHesapID
            // 
            this.txtHesapID.Location = new System.Drawing.Point(120, 17);
            this.txtHesapID.Name = "txtHesapID";
            this.txtHesapID.Size = new System.Drawing.Size(200, 22);
            this.txtHesapID.TabIndex = 1;
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(20, 60);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(33, 17);
            this.lblTur.TabIndex = 2;
            this.lblTur.Text = "Tür:";
            // 
            // cmbTur
            // 
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Items.AddRange(new object[] {
                "Havale",
                "EFT",
                "Yatırım",
                "Ödeme"
            });
            this.cmbTur.Location = new System.Drawing.Point(120, 57);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(200, 24);
            this.cmbTur.TabIndex = 3;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(20, 100);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(42, 17);
            this.lblTarih.TabIndex = 4;
            this.lblTarih.Text = "Tarih:";
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(120, 97);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 22);
            this.dtpTarih.TabIndex = 5;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(20, 140);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(45, 17);
            this.lblTutar.TabIndex = 6;
            this.lblTutar.Text = "Tutar:";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(120, 137);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(200, 22);
            this.txtTutar.TabIndex = 7;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(20, 180);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(67, 17);
            this.lblAciklama.TabIndex = 8;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(120, 177);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 22);
            this.txtAciklama.TabIndex = 9;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(120, 220);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(90, 30);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(230, 220);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(90, 30);
            this.btnIptal.TabIndex = 11;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // FormEditIslem
            // 
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.txtHesapID);
            this.Controls.Add(this.lblHesapID);
            this.Name = "FormEditIslem";
            this.Text = "İşlem Düzenle";
            this.Load += new System.EventHandler(this.FormEditIslem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
