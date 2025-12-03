using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormHesap : Form
    {
        private string _connectionString;

        public FormHesap(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
        }

        private void FormHesap_Load(object sender, EventArgs e)
        {
            // Make row selection easier
            dataGridViewHesap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHesap.MultiSelect = false;

            LoadHesapData();
        }

        private void LoadHesapData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT
                            Hesap_ID AS 'hesapID',
                            Müşteri_ID AS 'MüşteriID',
                            Hesap_Türü AS 'Tür',
                            Hesap_Bakiye AS 'Bakiye',
                            DATE_FORMAT(Hesap_AçılışTarihi, '%d/%m/%Y') AS 'Açılış Tarihi',
                            Hesap_Durumu AS 'Durum'
                        FROM BankDatabase_Hesap
                    ";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewHesap.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hesap verileri yüklenirken hata oluştu: {ex.Message}",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Assume you already have a FormAddHesap (like your Şube example)
            FormAddHesap addForm = new FormAddHesap(_connectionString);
            addForm.FormClosed += (s, args) => LoadHesapData();
            addForm.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridViewHesap.SelectedRows.Count > 0)
            {
                int selectedHesapID = Convert.ToInt32(
                    dataGridViewHesap.SelectedRows[0].Cells["hesapID"].Value);

                FormEditHesap editForm = new FormEditHesap(selectedHesapID, _connectionString);
                editForm.FormClosed += (s, args) => LoadHesapData();
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek için bir hesap seçin.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewHesap.SelectedRows.Count > 0)
            {
                int selectedHesapID = Convert.ToInt32(
                    dataGridViewHesap.SelectedRows[0].Cells["HesapID"].Value);

                DialogResult result = MessageBox.Show("Bu hesabı silmek istediğinize emin misiniz?",
                                                      "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    FormDeleteHesap deleteForm = new FormDeleteHesap(selectedHesapID, _connectionString);
                    deleteForm.FormClosed += (s, args) => LoadHesapData();
                    deleteForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir hesap seçin.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            if (dataGridViewHesap.SelectedRows.Count > 0)
            {
                int selectedHesapID = Convert.ToInt32(
                    dataGridViewHesap.SelectedRows[0].Cells["hesapID"].Value);

                FormHesapDetay frmDetay = new FormHesapDetay(selectedHesapID, _connectionString);
                frmDetay.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir hesap seçin.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
