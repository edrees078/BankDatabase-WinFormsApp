using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormMusteriDetay : Form
    {
        private int _musteriID;
        private string _connectionString;

        public FormMusteriDetay(int musteriID, string connectionString)
        {
            InitializeComponent();
            _musteriID = musteriID;
            _connectionString = connectionString;
        }

        private void FormMusteriDetay_Load(object sender, EventArgs e)
        {
            LoadMusteriDetails();
        }

        private void LoadMusteriDetails()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    // We call the stored procedure "GetMüşteriDetails"
                    using (MySqlCommand cmd = new MySqlCommand("GetMüşteriDetails", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@müşteriID", _musteriID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate the labels with the retrieved values.
                                lblAd.Text = $"Ad: {reader["Müşteri_isim"].ToString()}";
                                lblSoyad.Text = $"Soyad: {reader["Müşteri_Soyisim"].ToString()}";
                                lblTelefon.Text = $"Telefon: {reader["Müşteri_Telefon"].ToString()}";
                                lblEposta.Text = $"E-posta: {reader["Müşteri_Eposta"].ToString()}";
                                lblTCKN.Text = $"TCKN / Şirket No: {reader["Müşteri_TCKNŞirketVergiNo"].ToString()}";
                                lblTur.Text = $"Tür: {reader["Müşteri_Türü"].ToString()}";

                                // Convert date from column "Müşteri_KayıtTarihi"
                                DateTime kayitTarihi = Convert.ToDateTime(reader["Müşteri_KayıtTarihi"]);
                                lblKayitTarihi.Text = $"Kayıt Tarihi: {kayitTarihi:dd/MM/yyyy}";
                            }
                            else
                            {
                                MessageBox.Show("Müşteri kaydı bulunamadı!",
                                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
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
    }
}
