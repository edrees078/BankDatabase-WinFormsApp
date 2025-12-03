namespace WindowsFormsApp2
{
    partial class FormDeleteSube
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
            this.lblWarning.Size = new System.Drawing.Size(250, 17);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "Şubeyi silmek istediğinize emin misiniz?";
            // 
            // btnConfirmDelete
            // 
            this.btnConfirmDelete.Location = new System.Drawing.Point(30, 60);
            this.btnConfirmDelete.Name = "btnConfirmDelete";
            this.btnConfirmDelete.Size = new System.Drawing.Size(90, 30);
            this.btnConfirmDelete.TabIndex = 1;
            this.btnConfirmDelete.Text = "Sil";
            this.btnConfirmDelete.UseVisualStyleBackColor = true;
            this.btnConfirmDelete.Click += new System.EventHandler(this.btnConfirmDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(140, 60);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormDeleteSube
            // 
            this.ClientSize = new System.Drawing.Size(280, 120);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnConfirmDelete);
            this.Controls.Add(this.btnCancel);
            this.Name = "FormDeleteSube";
            this.Text = "Şube Sil";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
