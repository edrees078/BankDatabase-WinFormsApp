using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp2;
using System.Configuration;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        // NOTE: Adjust your connection string as needed:
        private readonly string _connectionString;

        public Form1()
        {
            InitializeComponent();

            _connectionString = ConfigurationManager
                               .ConnectionStrings["BankDb"]
                               .ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        public void LoadCustomerData()
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    // Basic SELECT to load customer data
                    string query = @"
                        SELECT 
                            Müşteri_ID AS 'ID', 
                            Müşteri_isim AS 'Ad', 
                            Müşteri_Soyisim AS 'Soyad', 
                            Müşteri_Telefon AS 'Telefon', 
                            Müşteri_Eposta AS 'E-posta', 
                            Müşteri_TCKNŞirketVergiNo AS 'TCKN/Şirket Vergi No',
                            Müşteri_Türü AS 'Tür', 
                            Müşteri_KayıtTarihi AS 'Kayıt Tarihi'
                        FROM BankDatabase_Müşteri"
                    ;

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading data: {ex.Message}");
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Open the FormAddMusteri dialog
            FormAddMusteri frmAdd = new FormAddMusteri(_connectionString);

            // When the add form closes, reload data so we can see the new record
            frmAdd.FormClosed += (s, args) => LoadCustomerData();

            frmAdd.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Get the selected row's Müşteri_ID
                int musteriID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

                // Open the edit form, passing in the ID and connection string
                FormEditMusteri frmEdit = new FormEditMusteri(musteriID, _connectionString);

                // Reload DataGridView when edit form closes
                frmEdit.FormClosed += (s, args) => LoadCustomerData();

                frmEdit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir müşteri seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int musteriID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

                // Open the delete form, passing in the ID and connection string
                FormDeleteMusteri frmDelete = new FormDeleteMusteri(musteriID, _connectionString);

                // Reload DataGridView when delete form closes (in case user confirms the delete)
                frmDelete.FormClosed += (s, args) => LoadCustomerData();

                frmDelete.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir müşteri seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnHesaplar_Click(object sender, EventArgs e)
        {
            FormHesap frmHesap = new FormHesap(_connectionString);
            frmHesap.ShowDialog();
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Get the selected row's Müşteri_ID
                int musteriID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

                // Open the detail form, passing in the ID and connection string
                FormMusteriDetay frmDetay = new FormMusteriDetay(musteriID, _connectionString);
                frmDetay.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir müşteri seçin.",
                                "Uyarı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }




    }
}
