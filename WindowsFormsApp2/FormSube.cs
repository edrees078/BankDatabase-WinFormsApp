using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormSube : Form
    {
        private string _connectionString;

        public FormSube(string connectionString)
        {
            InitializeComponent();
            _connectionString = connectionString;
        }

        private void FormSube_Load(object sender, EventArgs e)
        {
            dataGridViewSube.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSube.MultiSelect = false;  // (optional)
            LoadSubeData();
        }


        private void LoadSubeData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            Şube_ID AS 'Şube ID',
                            Şube_Adı AS 'Adı',
                            Şube_Adresi AS 'Adresi',
                            Şube_Telefonu AS 'Telefon'
                        FROM BankDatabase_Şube
                    ";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridViewSube.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Şube verileri yüklenirken hata oluştu: {ex.Message}",
                                "Hata",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void btnDetay_Click(object sender, EventArgs e)
        {
            if (dataGridViewSube.SelectedRows.Count > 0)
            {
                int selectedSubeID = Convert.ToInt32(
                    dataGridViewSube.SelectedRows[0].Cells["Şube ID"].Value);

                FormSubeDetay frmDetay = new FormSubeDetay(selectedSubeID, _connectionString);
                frmDetay.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir şube seçin.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FormAddSube addForm = new FormAddSube(_connectionString);
            addForm.FormClosed += (s, args) => LoadSubeData(); // Reload data after the form is closed
            addForm.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridViewSube.SelectedRows.Count > 0)
            {
                int selectedSubeID = Convert.ToInt32(
                    dataGridViewSube.SelectedRows[0].Cells["Şube ID"].Value);

                FormEditSube editForm = new FormEditSube(selectedSubeID, _connectionString);
                editForm.ShowDialog();

                // Refresh the data grid after editing
                LoadSubeData();
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek için bir şube seçin.",
                                "Uyarı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewSube.SelectedRows.Count > 0)
            {
                int selectedSubeID = Convert.ToInt32(
                    dataGridViewSube.SelectedRows[0].Cells["Şube ID"].Value);

                DialogResult result = MessageBox.Show(
                    "Bu şubeyi silmek istediğinize emin misiniz?",
                    "Onay",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(_connectionString))
                        {
                            conn.Open();
                            // Call the ŞubeSilme stored procedure
                            using (MySqlCommand cmd = new MySqlCommand("ŞubeSilme", conn))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@şubeID", selectedSubeID);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Şube başarıyla silindi!",
                                        "Bilgi",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        LoadSubeData(); // Reload data after deletion
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Şube silinirken hata oluştu: {ex.Message}",
                                        "Hata",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir şube seçin.",
                                "Uyarı",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }


    }
}
