using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormIslem : Form
    {
        private string _connectionString =
            "Server=127.0.0.1;Port=3306;Database=BankDatabase_spot;Uid=root;Pwd=Edrees123;";

        public FormIslem()
        {
            InitializeComponent();
        }

        private void FormIslem_Load(object sender, EventArgs e)
        {
            LoadIslemData();
        }

        private void LoadIslemData()
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            İşlem_ID AS 'İşlem_ID',
                            Hesap_ID AS 'Hesap ID',
                            İşlem_Türü AS 'Tür',
                            İşlem_Tutarı AS 'Tutar',
                            Açılış_İşlem_Tarihi AS 'Tarih',
                            İşlem_Açıklaması AS 'Açıklama'
                        FROM BankDatabase_İşlem";

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
            FormAddIslem frmAdd = new FormAddIslem(_connectionString);

            // Refresh data when the "Add" form is closed
            frmAdd.FormClosed += (s, args) => LoadIslemData();
            frmAdd.ShowDialog();
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Get the selected row's İşlem_ID
                int İşlem_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["İşlem_ID"].Value);

                // Open the details form
                FormIslemDetay frmDetay = new FormIslemDetay(İşlem_ID, _connectionString);
                frmDetay.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir işlem seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int islemID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["İşlem_ID"].Value);

                FormEditIslem frmEdit = new FormEditIslem(islemID, _connectionString);
                // Reload data after edit form closes
                frmEdit.FormClosed += (s, args) => LoadIslemData();
                frmEdit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir işlem seçin!", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int islemID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["İşlem_ID"].Value);

                DialogResult result = MessageBox.Show(
                    "Bu işlemi silmek istediğinize emin misiniz?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Show the FormDeleteIslem
                    FormDeleteIslem frmDelete = new FormDeleteIslem(islemID, _connectionString);
                    frmDelete.FormClosed += (s, args) => LoadIslemData();
                    frmDelete.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir işlem seçin!", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
