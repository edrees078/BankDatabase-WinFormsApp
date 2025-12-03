namespace WindowsFormsApp2
{
    partial class FormDeletePersonel
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnConfirmDelete;
        private System.Windows.Forms.Button btnCancel;

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
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnConfirmDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(25, 20);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(200, 17);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "Personeli silmek istediğinize emin misiniz?";

            // 
            // btnConfirmDelete
            // 
            this.btnConfirmDelete.Location = new System.Drawing.Point(28, 60);
            this.btnConfirmDelete.Name = "btnConfirmDelete";
            this.btnConfirmDelete.Size = new System.Drawing.Size(75, 30);
            this.btnConfirmDelete.TabIndex = 1;
            this.btnConfirmDelete.Text = "Sil";
            this.btnConfirmDelete.UseVisualStyleBackColor = true;
            this.btnConfirmDelete.Click += new System.EventHandler(this.btnConfirmDelete_Click);

            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(130, 60);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 
            // FormDeletePersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 120);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnConfirmDelete);
            this.Controls.Add(this.btnCancel);
            this.Name = "FormDeletePersonel";
            this.Text = "Personel Sil";
        }

        #endregion
    }
}
