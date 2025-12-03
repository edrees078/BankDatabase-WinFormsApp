using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormEditMusteri : Form
    {
        private int _musteriID;
        private string _connectionString;

        public FormEditMusteri(int musteriID, string connectionString)
        {
            InitializeComponent();
            _musteriID = musteriID;
            _connectionString = connectionString;
        }

        private void FormEditMusteri_Load(object sender, EventArgs e)
        {
            LoadMusteriDetails();
        }

        private void LoadMusteriDetails()
        {
            // Call the stored procedure GetMüşteriDetails to load existing info
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("GetMüşteriDetails", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@müşteriID", _musteriID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // For example, you can fill textboxes:
                                txtTelefon.Text = reader["Müşteri_Telefon"].ToString();
                                txtEposta.Text = reader["Müşteri_Eposta"].ToString();
                                // Add more fields as needed (name, address, etc.)
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata (LoadMusteriDetails): {ex.Message}",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Gather new values from textboxes
            string yeniTelefon = txtTelefon.Text.Trim();
            string yeniEposta = txtEposta.Text.Trim();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("UpdateMüşteri", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@müşteriID", _musteriID);
                        cmd.Parameters.AddWithValue("@yeniTelefon", yeniTelefon);
                        cmd.Parameters.AddWithValue("@yeniEposta", yeniEposta);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Müşteri bilgileri güncellendi!", "Bilgi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata (UpdateMüşteri): {ex.Message}",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
