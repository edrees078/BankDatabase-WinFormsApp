namespace WindowsFormsApp2
{
    partial class FormEditMusteri
    {
        private System.ComponentModel.IContainer components = null;

        // ADD references to your new controls here
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblEposta;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblEposta = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();

            //
            // lblTelefon
            //
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(20, 20);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(67, 17);
            this.lblTelefon.TabIndex = 0;
            this.lblTelefon.Text = "Telefon:";

            //
            // txtTelefon
            //
            this.txtTelefon.Location = new System.Drawing.Point(100, 17);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 22);
            this.txtTelefon.TabIndex = 1;

            //
            // lblEposta
            //
            this.lblEposta.AutoSize = true;
            this.lblEposta.Location = new System.Drawing.Point(20, 60);
            this.lblEposta.Name = "lblEposta";
            this.lblEposta.Size = new System.Drawing.Size(57, 17);
            this.lblEposta.TabIndex = 2;
            this.lblEposta.Text = "E-posta:";

            //
            // txtEposta
            //
            this.txtEposta.Location = new System.Drawing.Point(100, 57);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(200, 22);
            this.txtEposta.TabIndex = 3;

            //
            // btnKaydet
            //
            this.btnKaydet.Location = new System.Drawing.Point(100, 100);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(90, 30);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            //
            // btnIptal
            //
            this.btnIptal.Location = new System.Drawing.Point(210, 100);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(90, 30);
            this.btnIptal.TabIndex = 5;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);

            //
            // FormEditMusteri
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 160);

            // Add controls to the form
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblEposta);
            this.Controls.Add(this.txtEposta);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnIptal);

            this.Name = "FormEditMusteri";
            this.Text = "Müşteri Düzenle";
            this.Load += new System.EventHandler(this.FormEditMusteri_Load);
        }

        #endregion
    }
}
