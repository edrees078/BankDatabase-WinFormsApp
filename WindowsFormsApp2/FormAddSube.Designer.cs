namespace WindowsFormsApp2
{
    partial class FormAddSube
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSubeAdi;
        private System.Windows.Forms.TextBox txtSubeAdresi;
        private System.Windows.Forms.TextBox txtSubeTelefonu;
        private System.Windows.Forms.Label lblSubeAdi;
        private System.Windows.Forms.Label lblSubeAdresi;
        private System.Windows.Forms.Label lblSubeTelefonu;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;

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
            this.txtSubeAdi = new System.Windows.Forms.TextBox();
            this.txtSubeAdresi = new System.Windows.Forms.TextBox();
            this.txtSubeTelefonu = new System.Windows.Forms.TextBox();
            this.lblSubeAdi = new System.Windows.Forms.Label();
            this.lblSubeAdresi = new System.Windows.Forms.Label();
            this.lblSubeTelefonu = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            // txtSubeAdi
            this.txtSubeAdi.Location = new System.Drawing.Point(130, 20);
            this.txtSubeAdi.Size = new System.Drawing.Size(200, 22);

            // txtSubeAdresi
            this.txtSubeAdresi.Location = new System.Drawing.Point(130, 60);
            this.txtSubeAdresi.Size = new System.Drawing.Size(200, 22);

            // txtSubeTelefonu
            this.txtSubeTelefonu.Location = new System.Drawing.Point(130, 100);
            this.txtSubeTelefonu.Size = new System.Drawing.Size(200, 22);

            // lblSubeAdi
            this.lblSubeAdi.Location = new System.Drawing.Point(20, 20);
            this.lblSubeAdi.Text = "Şube Adı:";

            // lblSubeAdresi
            this.lblSubeAdresi.Location = new System.Drawing.Point(20, 60);
            this.lblSubeAdresi.Text = "Şube Adresi:";

            // lblSubeTelefonu
            this.lblSubeTelefonu.Location = new System.Drawing.Point(20, 100);
            this.lblSubeTelefonu.Text = "Şube Telefonu:";

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(50, 150);
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(200, 150);
            this.btnCancel.Text = "İptal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // FormAddSube
            this.Controls.Add(this.txtSubeAdi);
            this.Controls.Add(this.txtSubeAdresi);
            this.Controls.Add(this.txtSubeTelefonu);
            this.Controls.Add(this.lblSubeAdi);
            this.Controls.Add(this.lblSubeAdresi);
            this.Controls.Add(this.lblSubeTelefonu);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.ClientSize = new System.Drawing.Size(360, 220);
            this.Text = "Şube Ekle";
        }
    }
}
