using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormAddMusteri : Form
    {
        private string _connectionString;

        public FormAddMusteri(string connectionString)
        {
            _connectionString = connectionString;
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            InsertMusteri();

            this.Close();
            // close the parent Müşteri form as well:
            Form parentForm = this.Owner;
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

        private void InsertMusteri()
        {
            // Validate input as needed
            string isim = txtAd.Text.Trim();
            string soyisim = txtSoyad.Text.Trim();
            string telefon = txtTelefon.Text.Trim();
            string eposta = txtMail.Text.Trim();
            string tckn = txtTCKN.Text.Trim();
            string tur = comboTur.SelectedItem?.ToString(); // "Bireysel" or "Kurumsal"
            DateTime kayitTarihi = dateTimePickerKayit.Value;

            // Default values for SubeID / PersonelID if the user doesn't fill them
            int subeID = 1;
            int personelID = 1;

            // Try to parse user input from the textboxes (if you add them)
            // For example, if you have a textbox for SubeID:
            //   if (!int.TryParse(txtSubeID.Text, out subeID)) { subeID = 1; }
            //   if (!int.TryParse(txtPersonelID.Text, out personelID)) { personelID = 1; }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("InsertMüşteri", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@isim", isim);
                        cmd.Parameters.AddWithValue("@soyisim", soyisim);
                        cmd.Parameters.AddWithValue("@telefon", telefon);
                        cmd.Parameters.AddWithValue("@eposta", eposta);
                        cmd.Parameters.AddWithValue("@tckn", tckn);
                        cmd.Parameters.AddWithValue("@tür", tur);
                        cmd.Parameters.AddWithValue("@kayıtTarihi", kayitTarihi);
                        cmd.Parameters.AddWithValue("@şubeID", subeID);
                        cmd.Parameters.AddWithValue("@personelID", personelID);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Müşteri başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // close the 'add' form
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
