namespace WindowsFormsApp2
{
    partial class FormEditSube
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label lblAdresi;
        private System.Windows.Forms.TextBox txtAdresi;
        private System.Windows.Forms.Label lblTelefonu;
        private System.Windows.Forms.TextBox txtTelefonu;
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
            this.lblAdi = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.lblAdresi = new System.Windows.Forms.Label();
            this.txtAdresi = new System.Windows.Forms.TextBox();
            this.lblTelefonu = new System.Windows.Forms.Label();
            this.txtTelefonu = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(20, 20);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(65, 17);
            this.lblAdi.TabIndex = 0;
            this.lblAdi.Text = "Şube Adı:";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(100, 17);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(200, 22);
            this.txtAdi.TabIndex = 1;
            // 
            // lblAdresi
            // 
            this.lblAdresi.AutoSize = true;
            this.lblAdresi.Location = new System.Drawing.Point(20, 60);
            this.lblAdresi.Name = "lblAdresi";
            this.lblAdresi.Size = new System.Drawing.Size(84, 17);
            this.lblAdresi.TabIndex = 2;
            this.lblAdresi.Text = "Şube Adresi:";
            // 
            // txtAdresi
            // 
            this.txtAdresi.Location = new System.Drawing.Point(100, 57);
            this.txtAdresi.Name = "txtAdresi";
            this.txtAdresi.Size = new System.Drawing.Size(200, 22);
            this.txtAdresi.TabIndex = 3;
            // 
            // lblTelefonu
            // 
            this.lblTelefonu.AutoSize = true;
            this.lblTelefonu.Location = new System.Drawing.Point(20, 100);
            this.lblTelefonu.Name = "lblTelefonu";
            this.lblTelefonu.Size = new System.Drawing.Size(105, 17);
            this.lblTelefonu.TabIndex = 4;
            this.lblTelefonu.Text = "Şube Telefonu:";
            // 
            // txtTelefonu
            // 
            this.txtTelefonu.Location = new System.Drawing.Point(100, 97);
            this.txtTelefonu.Name = "txtTelefonu";
            this.txtTelefonu.Size = new System.Drawing.Size(200, 22);
            this.txtTelefonu.TabIndex = 5;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(100, 140);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(90, 30);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(210, 140);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(90, 30);
            this.btnIptal.TabIndex = 7;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // FormEditSube
            // 
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.lblAdresi);
            this.Controls.Add(this.txtAdresi);
            this.Controls.Add(this.lblTelefonu);
            this.Controls.Add(this.txtTelefonu);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnIptal);
            this.Name = "FormEditSube";
            this.Text = "Şube Düzenle";
            this.Load += new System.EventHandler(this.FormEditSube_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
