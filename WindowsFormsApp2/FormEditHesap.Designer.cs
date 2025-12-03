namespace WindowsFormsApp2
{
    partial class FormEditHesap
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Label lblAcilisTarihi;
        private System.Windows.Forms.DateTimePicker dtpAcilisTarihi;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.ComboBox cmbDurum;
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
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.lblTur = new System.Windows.Forms.Label();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.lblAcilisTarihi = new System.Windows.Forms.Label();
            this.dtpAcilisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblDurum = new System.Windows.Forms.Label();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Location = new System.Drawing.Point(20, 20);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(68, 17);
            this.lblMusteriID.TabIndex = 0;
            this.lblMusteriID.Text = "MüşteriID:";
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Location = new System.Drawing.Point(100, 17);
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(200, 22);
            this.txtMusteriID.TabIndex = 1;
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
            "Vadesiz",
            "Vadeli"});
            this.cmbTur.Location = new System.Drawing.Point(100, 57);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(200, 24);
            this.cmbTur.TabIndex = 3;
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(20, 100);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(51, 17);
            this.lblBakiye.TabIndex = 4;
            this.lblBakiye.Text = "Bakiye:";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(100, 97);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(200, 22);
            this.txtBakiye.TabIndex = 5;
            // 
            // lblAcilisTarihi
            // 
            this.lblAcilisTarihi.AutoSize = true;
            this.lblAcilisTarihi.Location = new System.Drawing.Point(20, 140);
            this.lblAcilisTarihi.Name = "lblAcilisTarihi";
            this.lblAcilisTarihi.Size = new System.Drawing.Size(78, 17);
            this.lblAcilisTarihi.TabIndex = 6;
            this.lblAcilisTarihi.Text = "Açılış Tarihi:";
            // 
            // dtpAcilisTarihi
            // 
            this.dtpAcilisTarihi.Location = new System.Drawing.Point(100, 137);
            this.dtpAcilisTarihi.Name = "dtpAcilisTarihi";
            this.dtpAcilisTarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpAcilisTarihi.TabIndex = 7;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(20, 180);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(52, 17);
            this.lblDurum.TabIndex = 8;
            this.lblDurum.Text = "Durum:";
            // 
            // cmbDurum
            // 
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.cmbDurum.Location = new System.Drawing.Point(100, 177);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(200, 24);
            this.cmbDurum.TabIndex = 9;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(100, 220);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(90, 30);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(210, 220);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(90, 30);
            this.btnIptal.TabIndex = 11;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // FormEditHesap
            // 
            this.ClientSize = new System.Drawing.Size(350, 280);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.dtpAcilisTarihi);
            this.Controls.Add(this.lblAcilisTarihi);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.txtMusteriID);
            this.Controls.Add(this.lblMusteriID);
            this.Name = "FormEditHesap";
            this.Text = "Hesap Düzenle";
            this.Load += new System.EventHandler(this.FormEditHesap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
