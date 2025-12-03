using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormAddHesap : Form
    {
        private string _connectionString;

        public FormAddHesap(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            // Gather user input
            int musteriID = int.Parse(txtMusteriID.Text.Trim());  // must exist in Müşteri table
            string tur = comboTur.SelectedItem?.ToString();       // "Vadesiz" or "Vadeli"
            decimal bakiye = decimal.Parse(txtBakiye.Text.Trim());
            DateTime acilisTarihi = dateTimePickerAcilis.Value;
            string durum = comboDurum.SelectedItem?.ToString();   // "Aktif" or "Pasif"

            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("HesapEkle", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@müşteriID", musteriID);
                        cmd.Parameters.AddWithValue("@tür", tur);
                        cmd.Parameters.AddWithValue("@bakiye", bakiye);
                        cmd.Parameters.AddWithValue("@açılışTarihi", acilisTarihi);
                        cmd.Parameters.AddWithValue("@durum", durum);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Hesap başarıyla eklendi!",
                                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // close the add form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata (Hesap Ekle): {ex.Message}",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
