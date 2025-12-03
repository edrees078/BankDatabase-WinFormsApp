using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormAddPersonel : Form
    {
        private string _connectionString;

        public FormAddPersonel(string connectionString)
        {
            _connectionString = connectionString;
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            InsertPersonel();

            this.Close();
        }

        private void InsertPersonel()
        {
            // Validate input as needed
            string isim = txtAd.Text.Trim();
            string soyisim = txtSoyad.Text.Trim();
            string gorev = txtGorev.Text.Trim();
            int subeID = int.TryParse(txtSubeID.Text.Trim(), out var parsedSubeID) ? parsedSubeID : 0;
            DateTime calismaTarihi = dateTimePickerCalismaTarihi.Value;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("PersonelEkleme", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@isim", isim);
                        cmd.Parameters.AddWithValue("@soyisim", soyisim);
                        cmd.Parameters.AddWithValue("@görev", gorev);
                        cmd.Parameters.AddWithValue("@şubeID", subeID);
                        cmd.Parameters.AddWithValue("@çalışmaTarihi", calismaTarihi);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Personel başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
