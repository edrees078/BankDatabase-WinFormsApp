using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormDeletePersonel : Form
    {
        private int _personelID;
        private string _connectionString;

        public FormDeletePersonel(int personelID, string connectionString)
        {
            InitializeComponent();
            _personelID = personelID;
            _connectionString = connectionString;
        }

        private void btnConfirmDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("PersonelSilme", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@personelID", _personelID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Personel başarıyla silindi!",
                                "Bilgi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Close this dialog, so the main form can reload data
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
            this.Close(); // Close the dialog without deleting
        }
    }
}
