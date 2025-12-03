using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormIslemDetay : Form
    {
        // This constructor sets labels directly from passed string parameters
        // (Used if you already have all the values from somewhere else and just want to display them.)
        public FormIslemDetay(string hesapID, string islemTuru, string islemTutari, string islemTarihi, string islemAciklama)
        {
            InitializeComponent();

            lblHesapID.Text = $"Hesap ID: {hesapID}";
            lblIslemTuru.Text = $"İşlem Türü: {islemTuru}";
            lblIslemTutari.Text = $"İşlem Tutarı: {islemTutari}";
            lblIslemTarihi.Text = $"Tarih: {islemTarihi}";
            lblIslemAciklama.Text = $"Açıklama: {islemAciklama}";
        }

        // This constructor is the one that will load data from the database
        private int İşlem_ID;
        private string _connectionString;

        public FormIslemDetay(int islemID, string connectionString)
        {
            InitializeComponent();
            İşlem_ID = islemID;
            _connectionString = connectionString;
        }

        private void FormIslemDetay_Load(object sender, EventArgs e)
        {
            // Only call LoadTransactionDetails if we have a valid connection string and a valid islemID
            if (!string.IsNullOrEmpty(_connectionString) && İşlem_ID > 0)
            {
                LoadTransactionDetails();
            }
        }

        private void LoadTransactionDetails()
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();

                    // Instead of a "CALL İşlemDetay(?)" string, we'll specify the SP name + CommandType
                    using (MySqlCommand cmd = new MySqlCommand("İşlemDetay", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        // Match the procedure parameter name exactly ("işlemID" in CREATE PROCEDURE İşlemDetay(IN işlemID INT))
                        cmd.Parameters.AddWithValue("@işlemID", İşlem_ID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblHesapID.Text = $"Hesap ID: {reader["Hesap_ID"].ToString()}";
                                lblIslemTuru.Text = $"İşlem Türü: {reader["İşlem_Türü"].ToString()}";
                                lblIslemTutari.Text = $"İşlem Tutarı: {reader["İşlem_Tutarı"].ToString()}";
                                lblIslemAciklama.Text = $"Açıklama: {reader["İşlem_Açıklaması"].ToString()}";

                                // Convert the date from the column "Açılış_İşlem_Tarihi"
                                var tarih = Convert.ToDateTime(reader["Açılış_İşlem_Tarihi"]);
                                lblIslemTarihi.Text = $"Tarih: {tarih:yyyy-MM-dd}";
                            }
                            else
                            {
                                MessageBox.Show("İşlem bulunamadı!", "Uyarı",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
