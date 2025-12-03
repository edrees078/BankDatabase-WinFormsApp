namespace WindowsFormsApp2
{
    partial class FormEditPersonel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtNewBranchID;
        private System.Windows.Forms.TextBox txtNewRole;
        private System.Windows.Forms.Label lblNewRole;
        private System.Windows.Forms.Label lblNewBranchID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;

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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNewBranchID = new System.Windows.Forms.TextBox();
            this.txtNewRole = new System.Windows.Forms.TextBox();
            this.lblNewRole = new System.Windows.Forms.Label();
            this.lblNewBranchID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            // 
            // lblNewRole
            // 
            this.lblNewRole.AutoSize = true;
            this.lblNewRole.Location = new System.Drawing.Point(20, 100);
            this.lblNewRole.Name = "lblNewRole";
            this.lblNewRole.Size = new System.Drawing.Size(45, 16);
            this.lblNewRole.TabIndex = 0;
            this.lblNewRole.Text = "Görev:";
            // 
            // txtNewRole
            // 
            this.txtNewRole.Location = new System.Drawing.Point(120, 97);
            this.txtNewRole.Name = "txtNewRole";
            this.txtNewRole.Size = new System.Drawing.Size(200, 22);
            this.txtNewRole.TabIndex = 1;
            // 
            // lblNewBranchID
            // 
            this.lblNewBranchID.AutoSize = true;
            this.lblNewBranchID.Location = new System.Drawing.Point(20, 140);
            this.lblNewBranchID.Name = "lblNewBranchID";
            this.lblNewBranchID.Size = new System.Drawing.Size(62, 16);
            this.lblNewBranchID.TabIndex = 2;
            this.lblNewBranchID.Text = "Şube ID:";
            // 
            // txtNewBranchID
            // 
            this.txtNewBranchID.Location = new System.Drawing.Point(120, 137);
            this.txtNewBranchID.Name = "txtNewBranchID";
            this.txtNewBranchID.Size = new System.Drawing.Size(200, 22);
            this.txtNewBranchID.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(120, 180);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(245, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormEditPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNewBranchID);
            this.Controls.Add(this.lblNewBranchID);
            this.Controls.Add(this.txtNewRole);
            this.Controls.Add(this.lblNewRole);
            this.Name = "FormEditPersonel";
            this.Text = "Personel Düzenle";
        }

        #endregion
    }
}
