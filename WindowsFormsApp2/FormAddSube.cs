using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormAddSube : Form
    {
        private string _connectionString;

        public FormAddSube(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input
            string subeAdi = txtSubeAdi.Text.Trim();
            string subeAdresi = txtSubeAdresi.Text.Trim();
            string subeTelefonu = txtSubeTelefonu.Text.Trim();

            if (string.IsNullOrEmpty(subeAdi) || string.IsNullOrEmpty(subeAdresi) || string.IsNullOrEmpty(subeTelefonu))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert data into the database
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "CALL InsertŞube(@subeAdi, @subeAdresi, @subeTelefonu)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@subeAdi", subeAdi);
                        cmd.Parameters.AddWithValue("@subeAdresi", subeAdresi);
                        cmd.Parameters.AddWithValue("@subeTelefonu", subeTelefonu);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Şube başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
