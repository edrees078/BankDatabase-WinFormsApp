using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormAddIslem : Form
    {
        private string _connectionString;

        public FormAddIslem(string connectionString)
        {
            _connectionString = connectionString;
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            InsertIslem();

            this.Close();
        }

        private void InsertIslem()
        {
            // Validate input as needed
            int hesapID = int.Parse(txtHesapID.Text.Trim());
            string tur = comboTur.SelectedItem?.ToString(); // "Havale", "EFT", etc.
            decimal tutar = decimal.Parse(txtTutar.Text.Trim());
            string aciklama = txtAciklama.Text.Trim();
            DateTime islemTarihi = dateTimePickerTarih.Value;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("İşlemEkle", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@hesapID", hesapID);
                        cmd.Parameters.AddWithValue("@tür", tur);
                        cmd.Parameters.AddWithValue("@işlemTutarı", tutar);
                        cmd.Parameters.AddWithValue("@açıklama", aciklama);
                        cmd.Parameters.AddWithValue("@işlemTarihi", islemTarihi);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("İşlem başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
