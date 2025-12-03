using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormMain : Form
    {
        // The connection string for your DB
        private string connectionString =
            "Server=127.0.0.1;Port=3306;Database=BankDatabase_spot;Uid=root;Pwd=Edrees123;";

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            // Show Müşteri Yönetim form
            Form1 frmMusteri = new Form1();
            frmMusteri.ShowDialog();
        }

        private void btnHesaplar_Click(object sender, EventArgs e)
        {
            // Show Hesaplar form
            FormHesap frmHesap = new FormHesap(connectionString);
            frmHesap.ShowDialog();
        }

        private void btnPersonel_Click(object sender, EventArgs e)
        {
            // Open the Personel management form
            FormPersonel frmPersonel = new FormPersonel();
            frmPersonel.ShowDialog();
        }

        private void btnIslem_Click(object sender, EventArgs e)
        {
            FormIslem frmIslem = new FormIslem();
            frmIslem.ShowDialog();
        }

        private void btnSube_Click(object sender, EventArgs e)
        {
            FormSube subeForm = new FormSube(connectionString);
            subeForm.ShowDialog();
        }
    }
}
