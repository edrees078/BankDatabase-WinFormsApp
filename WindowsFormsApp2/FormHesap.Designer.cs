namespace WindowsFormsApp2
{
    partial class FormHesap
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewHesap;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDetay;

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
            this.dataGridViewHesap = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHesap)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHesap
            // 
            this.dataGridViewHesap.AllowUserToAddRows = false;
            this.dataGridViewHesap.AllowUserToDeleteRows = false;
            this.dataGridViewHesap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHesap.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewHesap.Name = "dataGridViewHesap";
            this.dataGridViewHesap.ReadOnly = true;
            this.dataGridViewHesap.RowHeadersWidth = 51;
            this.dataGridViewHesap.Size = new System.Drawing.Size(800, 300);
            this.dataGridViewHesap.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(20, 330);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 30);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Hesap Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(140, 330);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(100, 30);
            this.btnDuzenle.TabIndex = 2;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(260, 330);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 30);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // FormHesap
            // 
            this.ClientSize = new System.Drawing.Size(850, 380);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridViewHesap);
            this.Name = "FormHesap";
            this.Text = "Hesaplar";
            this.Load += new System.EventHandler(this.FormHesap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHesap)).EndInit();
            this.ResumeLayout(false);


            // 
            // btnDetay
            // 
            this.btnDetay = new System.Windows.Forms.Button();
            this.btnDetay.Location = new System.Drawing.Point(380, 330);
            this.btnDetay.Name = "btnDetay";
            this.btnDetay.Size = new System.Drawing.Size(100, 30);
            this.btnDetay.TabIndex = 4;
            this.btnDetay.Text = "Detay";
            this.btnDetay.UseVisualStyleBackColor = true;
            this.btnDetay.Click += new System.EventHandler(this.btnDetay_Click);

            this.Controls.Add(this.btnDetay);
        }
    }
}
