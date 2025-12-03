namespace WindowsFormsApp2
{
    partial class FormAddHesap
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.ComboBox comboTur;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.DateTimePicker dateTimePickerAcilis;
        private System.Windows.Forms.ComboBox comboDurum;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label lblMusteriID;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label lblAcilis;
        private System.Windows.Forms.Label lblDurum;

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
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.comboTur = new System.Windows.Forms.ComboBox();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.dateTimePickerAcilis = new System.Windows.Forms.DateTimePicker();
            this.comboDurum = new System.Windows.Forms.ComboBox();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.lblMusteriID = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.lblAcilis = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();

            this.SuspendLayout();
            // 
            // lblMusteriID
            // 
            this.lblMusteriID.AutoSize = true;
            this.lblMusteriID.Location = new System.Drawing.Point(20, 20);
            this.lblMusteriID.Name = "lblMusteriID";
            this.lblMusteriID.Size = new System.Drawing.Size(78, 17);
            this.lblMusteriID.TabIndex = 0;
            this.lblMusteriID.Text = "Müşteri ID:";
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Location = new System.Drawing.Point(120, 17);
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(150, 22);
            this.txtMusteriID.TabIndex = 1;
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(20, 60);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(31, 17);
            this.lblTur.TabIndex = 2;
            this.lblTur.Text = "Tür:";
            // 
            // comboTur
            // 
            this.comboTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTur.FormattingEnabled = true;
            this.comboTur.Items.AddRange(new object[] {
            "Vadesiz",
            "Vadeli"});
            this.comboTur.Location = new System.Drawing.Point(120, 57);
            this.comboTur.Name = "comboTur";
            this.comboTur.Size = new System.Drawing.Size(150, 24);
            this.comboTur.TabIndex = 3;
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Location = new System.Drawing.Point(20, 100);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(54, 17);
            this.lblBakiye.TabIndex = 4;
            this.lblBakiye.Text = "Bakiye:";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(120, 97);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(150, 22);
            this.txtBakiye.TabIndex = 5;
            // 
            // lblAcilis
            // 
            this.lblAcilis.AutoSize = true;
            this.lblAcilis.Location = new System.Drawing.Point(20, 140);
            this.lblAcilis.Name = "lblAcilis";
            this.lblAcilis.Size = new System.Drawing.Size(81, 17);
            this.lblAcilis.TabIndex = 6;
            this.lblAcilis.Text = "Açılış Tarihi:";
            // 
            // dateTimePickerAcilis
            // 
            this.dateTimePickerAcilis.Location = new System.Drawing.Point(120, 135);
            this.dateTimePickerAcilis.Name = "dateTimePickerAcilis";
            this.dateTimePickerAcilis.Size = new System.Drawing.Size(150, 22);
            this.dateTimePickerAcilis.TabIndex = 7;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(20, 180);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(53, 17);
            this.lblDurum.TabIndex = 8;
            this.lblDurum.Text = "Durum:";
            // 
            // comboDurum
            // 
            this.comboDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDurum.FormattingEnabled = true;
            this.comboDurum.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.comboDurum.Location = new System.Drawing.Point(120, 177);
            this.comboDurum.Name = "comboDurum";
            this.comboDurum.Size = new System.Drawing.Size(150, 24);
            this.comboDurum.TabIndex = 9;
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(120, 220);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(70, 30);
            this.btnTamam.TabIndex = 10;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(200, 220);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(70, 30);
            this.btnIptal.TabIndex = 11;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // FormAddHesap
            // 
            this.ClientSize = new System.Drawing.Size(320, 280);
            this.Controls.Add(this.lblMusteriID);
            this.Controls.Add(this.txtMusteriID);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.comboTur);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.lblAcilis);
            this.Controls.Add(this.dateTimePickerAcilis);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.comboDurum);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.btnIptal);

            this.Name = "FormAddHesap";
            this.Text = "Hesap Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
