using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormHesapDetay : Form
    {
        private int _hesapID;
        private string _connectionString;

        public FormHesapDetay(int hesapID, string connectionString)
        {
            InitializeComponent();
            _hesapID = hesapID;
            _connectionString = connectionString;
        }

        private void FormHesapDetay_Load(object sender, EventArgs e)
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
                    using (MySqlCommand cmd = new MySqlCommand("HesapDetay", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@HesapID", _hesapID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblHesapID.Text = $"hesap ID: {reader["hesap_ID"]}";
                                lblMusteriID.Text = $"Müşteri ID: {reader["Müşteri_ID"]}";
                                lblTur.Text = $"Tür: {reader["Hesap_Türü"]}";
                                lblBakiye.Text = $"Bakiye: {reader["Hesap_Bakiye"]}";
                                lblAcilisTarihi.Text =
                                    $"Açılış Tarihi: {Convert.ToDateTime(reader["Hesap_AçılışTarihi"]):dd/MM/yyyy}";
                                lblDurum.Text = $"Durum: {reader["Hesap_Durumu"]}";
                            }
                            else
                            {
                                MessageBox.Show("Hesap kaydı bulunamadı!",
                                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
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
    }
}
