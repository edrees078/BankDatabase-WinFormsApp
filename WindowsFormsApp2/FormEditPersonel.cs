using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormEditPersonel : Form
    {
        private string connectionString;
        private int personelID;

        public FormEditPersonel(int id, string connString)
        {
            InitializeComponent();
            connectionString = connString;
            personelID = id;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "CALL PersonelGuncelle(@personelID, @yeniGorev, @yeniSubeID)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@personelID", personelID);
                    cmd.Parameters.AddWithValue("@yeniGorev", txtNewRole.Text);
                    cmd.Parameters.AddWithValue("@yeniSubeID", int.Parse(txtNewBranchID.Text));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Personel başarıyla güncellendi.", "Başarılı");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Hata");
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form when the Cancel button is clicked
            this.Close();
        }
    }
}
