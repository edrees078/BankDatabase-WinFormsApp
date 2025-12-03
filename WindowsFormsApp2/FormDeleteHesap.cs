using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormDeleteHesap : Form
    {
        private int _hesapID;
        private string _connectionString;

        public FormDeleteHesap(int hesapID, string connectionString)
        {
            InitializeComponent();
            _hesapID = hesapID;
            _connectionString = connectionString;
        }

        private void btnConfirmDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    // Call the "HesapSil" stored procedure
                    using (MySqlCommand cmd = new MySqlCommand("HesapSil", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@pHesapID", _hesapID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Hesap başarıyla silindi!",
                                "Bilgi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata (HesapSil): {ex.Message}",
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
