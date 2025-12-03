using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormDeleteMusteri : Form
    {
        private int _musteriID;
        private string _connectionString;

        public FormDeleteMusteri(int musteriID, string connectionString)
        {
            InitializeComponent();
            _musteriID = musteriID;
            _connectionString = connectionString;
        }

        private void btnConfirmDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("DeleteMüşteri", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@müşteriID", _musteriID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Müşteri başarıyla silindi!",
                                "Bilgi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Close this dialog, so Form1 can reload data
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata (Sil): {ex.Message}",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // simply close without deleting
        }
    }
}
