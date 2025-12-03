using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormEditSube : Form
    {
        private int _subeID;
        private string _connectionString;

        public FormEditSube(int subeID, string connectionString)
        {
            InitializeComponent();
            _subeID = subeID;
            _connectionString = connectionString;
        }

        private void FormEditSube_Load(object sender, EventArgs e)
        {
            LoadSubeDetails();
        }

        private void LoadSubeDetails()
        {
            // Query to load existing branch details
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            Şube_Adı, 
                            Şube_Adresi, 
                            Şube_Telefonu 
                        FROM BankDatabase_Şube 
                        WHERE Şube_ID = @şubeID";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@şubeID", _subeID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate the textboxes with the existing values
                                txtAdi.Text = reader["Şube_Adı"].ToString();
                                txtAdresi.Text = reader["Şube_Adresi"].ToString();
                                txtTelefonu.Text = reader["Şube_Telefonu"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata (LoadSubeDetails): {ex.Message}",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Get updated values from the textboxes
            string yeniAdi = txtAdi.Text.Trim();
            string yeniAdresi = txtAdresi.Text.Trim();
            string yeniTelefonu = txtTelefonu.Text.Trim();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    // Call the ŞubeGuncelle stored procedure
                    using (MySqlCommand cmd = new MySqlCommand("ŞubeGuncelle", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@şubeID", _subeID);
                        cmd.Parameters.AddWithValue("@yeniAdı", yeniAdi);
                        cmd.Parameters.AddWithValue("@yeniAdresi", yeniAdresi);
                        cmd.Parameters.AddWithValue("@yeniTelefonu", yeniTelefonu);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Şube bilgileri güncellendi!", "Bilgi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata (ŞubeGuncelle): {ex.Message}",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form without saving changes
        }
    }
}
