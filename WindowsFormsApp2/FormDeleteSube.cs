using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormDeleteSube : Form
    {
        private int _subeID;
        private string _connectionString;

        public FormDeleteSube(int subeID, string connectionString)
        {
            InitializeComponent();
            _subeID = subeID;
            _connectionString = connectionString;
        }

        private void btnConfirmDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    // Call the ŞubeSilme stored procedure
                    using (MySqlCommand cmd = new MySqlCommand("ŞubeSilme", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@şubeID", _subeID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Şube başarıyla silindi!",
                                "Bilgi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata (ŞubeSilme): {ex.Message}",
                                "Hata",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
