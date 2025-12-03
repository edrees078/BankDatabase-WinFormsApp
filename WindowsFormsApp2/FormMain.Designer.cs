namespace WindowsFormsApp2
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnHesaplar;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.Button btnIslemler;
        private System.Windows.Forms.Button btnSube;

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
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnHesaplar = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.btnIslemler = new System.Windows.Forms.Button();
            this.btnSube = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // Common Button Settings
            //
            int buttonWidth = 150;
            int buttonHeight = 40;
            int formWidth = 220;
            int buttonSpacing = 10;
            int startX = (formWidth - buttonWidth) / 2; // Center buttons horizontally
            int startY = 20; // Initial Y position

            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Location = new System.Drawing.Point(startX, startY);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.btnMusteriler.TabIndex = 0;
            this.btnMusteriler.Text = "Müşteriler";
            this.btnMusteriler.UseVisualStyleBackColor = true;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);

            // 
            // btnHesaplar
            // 
            this.btnHesaplar.Location = new System.Drawing.Point(startX, startY + (buttonHeight + buttonSpacing) * 1);
            this.btnHesaplar.Name = "btnHesaplar";
            this.btnHesaplar.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.btnHesaplar.TabIndex = 1;
            this.btnHesaplar.Text = "Hesaplar";
            this.btnHesaplar.UseVisualStyleBackColor = true;
            this.btnHesaplar.Click += new System.EventHandler(this.btnHesaplar_Click);

            // 
            // btnPersonel
            // 
            this.btnPersonel.Location = new System.Drawing.Point(startX, startY + (buttonHeight + buttonSpacing) * 2);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.btnPersonel.TabIndex = 2;
            this.btnPersonel.Text = "Personel";
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);

            // 
            // btnIslemler
            // 
            this.btnIslemler.Location = new System.Drawing.Point(startX, startY + (buttonHeight + buttonSpacing) * 3);
            this.btnIslemler.Name = "btnIslemler";
            this.btnIslemler.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.btnIslemler.TabIndex = 3;
            this.btnIslemler.Text = "İşlemler";
            this.btnIslemler.UseVisualStyleBackColor = true;
            this.btnIslemler.Click += new System.EventHandler(this.btnIslem_Click);

            // 
            // btnSube
            // 
            this.btnSube.Location = new System.Drawing.Point(startX, startY + (buttonHeight + buttonSpacing) * 4);
            this.btnSube.Name = "btnSube";
            this.btnSube.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.btnSube.TabIndex = 4;
            this.btnSube.Text = "Şube";
            this.btnSube.UseVisualStyleBackColor = true;
            this.btnSube.Click += new System.EventHandler(this.btnSube_Click);

            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(formWidth, startY + (buttonHeight + buttonSpacing) * 5 + 20); // Adjusted height for buttons
            this.Controls.Add(this.btnSube);
            this.Controls.Add(this.btnIslemler);
            this.Controls.Add(this.btnPersonel);
            this.Controls.Add(this.btnHesaplar);
            this.Controls.Add(this.btnMusteriler);
            this.Name = "FormMain";
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
