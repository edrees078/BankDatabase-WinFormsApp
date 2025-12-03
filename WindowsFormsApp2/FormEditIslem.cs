using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormEditIslem : Form
    {
        private int _islemID;
        private string _connectionString;

        public FormEditIslem(int islemID, string connectionString)
        {
            InitializeComponent();
            _islemID = islemID;
            _connectionString = connectionString;
        }

        private void FormEditIslem_Load(object sender, EventArgs e)
        {
            LoadIslemDetails();
        }

        private void LoadIslemDetails()
        {
            // Retrieve the existing row from BankDatabase_İşlem for _islemID
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            Hesap_ID,
                            İşlem_Türü,
                            Açılış_İşlem_Tarihi,
                            İşlem_Tutarı,
                            İşlem_Açıklaması
                        FROM BankDatabase_İşlem
                        WHERE İşlem_ID = @pIslemID
                    ";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@pIslemID", _islemID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtHesapID.Text = reader["Hesap_ID"].ToString();
                                cmbTur.SelectedItem = reader["İşlem_Türü"].ToString();
                                dtpTarih.Value = Convert.ToDateTime(reader["Açılış_İşlem_Tarihi"]);
                                txtTutar.Text = reader["İşlem_Tutarı"].ToString();
                                txtAciklama.Text = reader["İşlem_Açıklaması"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("İşlem kaydı bulunamadı!",
                                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata (LoadIslemDetails): {ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Get updated values
            int newHesapID = Convert.ToInt32(txtHesapID.Text.Trim());
            string newTur = cmbTur.SelectedItem.ToString();
            DateTime newTarih = dtpTarih.Value;
            decimal newTutar = Convert.ToDecimal(txtTutar.Text.Trim());
            string newAciklama = txtAciklama.Text.Trim();

            // Call the IslemGuncelle SP
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand("IslemGuncelle", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@pIslemID", _islemID);
                        cmd.Parameters.AddWithValue("@pHesapID", newHesapID);
                        cmd.Parameters.AddWithValue("@pTur", newTur);
                        cmd.Parameters.AddWithValue("@pTarih", newTarih);
                        cmd.Parameters.AddWithValue("@pTutar", newTutar);
                        cmd.Parameters.AddWithValue("@pAciklama", newAciklama);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("İşlem güncellendi!", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata (IslemGuncelle): {ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
