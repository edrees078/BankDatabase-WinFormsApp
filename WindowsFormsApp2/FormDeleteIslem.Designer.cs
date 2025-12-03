namespace WindowsFormsApp2
{
    partial class FormDeleteIslem
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

        private void InitializeComponent()
        {
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnConfirmDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(20, 20);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(235, 17);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "Bu işlemi silmek istediğinize emin misiniz?";
            // 
            // btnConfirmDelete
            // 
            this.btnConfirmDelete.Location = new System.Drawing.Point(30, 60);
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
            // FormDeleteIslem
            // 
            this.ClientSize = new System.Drawing.Size(280, 120);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmDelete);
            this.Controls.Add(this.lblWarning);
            this.Name = "FormDeleteIslem";
            this.Text = "İşlem Sil";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
