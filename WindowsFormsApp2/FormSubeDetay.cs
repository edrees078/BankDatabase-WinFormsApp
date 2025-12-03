using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormSubeDetay : Form
    {
        private int _subeID;
        private string _connectionString;

        public FormSubeDetay(int subeID, string connectionString)
        {
            InitializeComponent();
            _subeID = subeID;
            _connectionString = connectionString;
        }

        private void FormSubeDetay_Load(object sender, EventArgs e)
        {
            LoadSubeDetails();
        }

        private void LoadSubeDetails()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("ŞubeDetay", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@şubeID", _subeID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblSubeID.Text = $"Şube ID: {reader["Şube_ID"]}";
                                lblAdi.Text = $"Ad: {reader["Şube_Adı"]}";
                                lblAdresi.Text = $"Adresi: {reader["Şube_Adresi"]}";
                                lblTelefonu.Text = $"Telefon: {reader["Şube_Telefonu"]}";
                            }
                            else
                            {
                                MessageBox.Show("Şube kaydı bulunamadı!",
                                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata (LoadSubeDetails): {ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
