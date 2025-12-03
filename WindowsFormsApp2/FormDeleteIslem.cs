using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormDeleteIslem : Form
    {
        private int _islemID;
        private string _connectionString;

        public FormDeleteIslem(int islemID, string connectionString)
        {
            InitializeComponent();
            _islemID = islemID;
            _connectionString = connectionString;
        }

        private void btnConfirmDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("IslemSil", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@pIslemID", _islemID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("İşlem başarıyla silindi!", "Bilgi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata (IslemSil): {ex.Message}",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
