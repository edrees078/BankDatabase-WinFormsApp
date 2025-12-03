using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormPersonel : Form
    {
        // Adjust your connection string as needed
        private string connectionString = "Server=127.0.0.1;Port=3306;Database=BankDatabase_spot;Uid=root;Pwd=Edrees123;";

        public FormPersonel()
        {
            InitializeComponent();
        }

        private void FormPersonel_Load(object sender, EventArgs e)
        {
            LoadPersonelData();
        }

        private void LoadPersonelData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            Personel_ID AS 'ID',
                            Personel_İsim AS 'Ad',
                            Personel_Soyisim AS 'Soyad',
                            Personel_Görev AS 'Görev',
                            Şube_ID AS 'Şube ID',
                            Personel_ÇalışmaTarihi AS 'Çalışma Tarihi'
                        FROM BankDatabase_Personel";

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
            FormAddPersonel frmAdd = new FormAddPersonel(connectionString);

            frmAdd.FormClosed += (s, args) => LoadPersonelData();

            frmAdd.ShowDialog();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int personelID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

                FormEditPersonel frmEdit = new FormEditPersonel(personelID, connectionString);

                frmEdit.FormClosed += (s, args) => LoadPersonelData();

                frmEdit.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir personel seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int personelID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

                FormDeletePersonel frmDelete = new FormDeletePersonel(personelID, connectionString);

                frmDelete.FormClosed += (s, args) => LoadPersonelData();

                frmDelete.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir personel seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int personelID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

                FormPersonelDetay frmDetay = new FormPersonelDetay(personelID, connectionString);
                frmDetay.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen listeden bir personel seçin.",
                                "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
