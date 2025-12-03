using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormEditHesap : Form
    {
        private int _hesapID;
        private string _connectionString;

        public FormEditHesap(int hesapID, string connectionString)
        {
            InitializeComponent();
            _hesapID = hesapID;
            _connectionString = connectionString;
        }

        private void FormEditHesap_Load(object sender, EventArgs e)
        {
            LoadHesapDetails();
        }

        private void LoadHesapDetails()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            Müşteri_ID, 
                            Hesap_Türü,
                            Hesap_Bakiye,
                            Hesap_AçılışTarihi,
                            Hesap_Durumu
                        FROM BankDatabase_Hesap
                        WHERE Hesap_ID = @pHesapID
                    ";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@pHesapID", _hesapID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtMusteriID.Text = reader["Müşteri_ID"].ToString();
                                cmbTur.SelectedItem = reader["Hesap_Türü"].ToString();
                                txtBakiye.Text = reader["Hesap_Bakiye"].ToString();
                                dtpAcilisTarihi.Value = Convert.ToDateTime(reader["Hesap_AçılışTarihi"]);
                                cmbDurum.SelectedItem = reader["Hesap_Durumu"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata (LoadHesapDetails): {ex.Message}",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Collect new values
            int newMusteriID = Convert.ToInt32(txtMusteriID.Text.Trim());
            string newTur = cmbTur.SelectedItem.ToString();
            decimal newBakiye = Convert.ToDecimal(txtBakiye.Text.Trim());
            DateTime newAcilisTarihi = dtpAcilisTarihi.Value;
            string newDurum = cmbDurum.SelectedItem.ToString();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    // Call the "HesapGuncelle" stored procedure
                    using (MySqlCommand cmd = new MySqlCommand("HesapGuncelle", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@pHesapID", _hesapID);
                        cmd.Parameters.AddWithValue("@pMusteriID", newMusteriID);
                        cmd.Parameters.AddWithValue("@pTur", newTur);
                        cmd.Parameters.AddWithValue("@pBakiye", newBakiye);
                        cmd.Parameters.AddWithValue("@pAcilisTarihi", newAcilisTarihi);
                        cmd.Parameters.AddWithValue("@pDurum", newDurum);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Hesap bilgileri güncellendi!", "Bilgi",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata (HesapGuncelle): {ex.Message}",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            // Close without saving
            this.Close();
        }
    }
}
