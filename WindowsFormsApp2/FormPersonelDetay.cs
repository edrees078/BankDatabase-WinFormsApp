using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormPersonelDetay : Form
    {
        private int _personelID;
        private string _connectionString;

        public FormPersonelDetay(int personelID, string connectionString)
        {
            InitializeComponent();
            _personelID = personelID;
            _connectionString = connectionString;
        }

        private void FormPersonelDetay_Load(object sender, EventArgs e)
        {
            LoadPersonelDetails();
        }

        private void LoadPersonelDetails()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("PersonelDetay", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@personelID", _personelID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblPersonelID.Text = $"Personel ID: {reader["Personel_ID"]}";
                                lblIsim.Text = $"Ad: {reader["Personel_İsim"]}";
                                lblSoyisim.Text = $"Soyad: {reader["Personel_Soyisim"]}";
                                lblGorev.Text = $"Görev: {reader["Personel_Görev"]}";
                                lblSubeID.Text = $"Şube ID: {reader["Şube_ID"]}";

                                DateTime calismaTarihi = Convert.ToDateTime(reader["Personel_ÇalışmaTarihi"]);
                                lblCalismaTarihi.Text = $"Çalışma Tarihi: {calismaTarihi:dd/MM/yyyy}";
                            }
                            else
                            {
                                MessageBox.Show("Personel kaydı bulunamadı!",
                                    "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata (LoadPersonelDetails): {ex.Message}",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
