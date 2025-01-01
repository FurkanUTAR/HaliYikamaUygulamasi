using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace haliYikama
{
    public partial class musteriler : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public musteriler()
        {
            InitializeComponent();
        }

        private void musteriler_Load(object sender, EventArgs e)
        {
            butunMusterileriGoster();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void musteriEklePictureBox_Click(object sender, EventArgs e)
        {
            musteriEkle musteriEkle = new musteriEkle();
            musteriEkle.Show();
            this.Hide();
        }

        private void musteriDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (siparisNoRadioButton.Checked)
            {
                if (e.RowIndex >= 0) // Tıkladığın satırın geçerli bir satır olduğundan emin ol
                {
                    DataGridViewRow row = musteriDataGridView.Rows[e.RowIndex];
                    int siparisNo = int.Parse(row.Cells["siparisnO"].Value.ToString());
                    string adSoyad = row.Cells["adiSoyadi"].Value.ToString();
                    string telNo = row.Cells["telNo"].Value.ToString();
                    string adres = row.Cells["adres"].Value.ToString();

                    siparisOlustur siparisForm = new siparisOlustur();
                    siparisForm.Kimlik = siparisNo;
                    siparisForm.adSoyad = adSoyad;
                    siparisForm.telNo = telNo;
                    siparisForm.adres = adres;
                    siparisForm.islem =  "siparis";
                    siparisForm.Show();
                    this.Hide();
                }
            }
            else
            {
                if (e.RowIndex >= 0) // Tıkladığın satırın geçerli bir satır olduğundan emin ol
                {
                    DataGridViewRow row = musteriDataGridView.Rows[e.RowIndex];
                    int kimlik = int.Parse(row.Cells["Kimlik"].Value.ToString());
                    string adSoyad = row.Cells["adiSoyadi"].Value.ToString();
                    string telNo = row.Cells["telNo"].Value.ToString();
                    string adres = row.Cells["adres"].Value.ToString();

                    siparisOlustur siparisForm = new siparisOlustur();
                    siparisForm.Kimlik = kimlik;
                    siparisForm.adSoyad = adSoyad;
                    siparisForm.telNo = telNo;
                    siparisForm.adres = adres;
                    siparisForm.islem = "musteri";
                    siparisForm.Show();
                    this.Hide();
                }
            } 
        }

        private void musteriAdiRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (musteriAdiRadioButton.Checked) araTextBox.KeyPress -= araTextBox_KeyPress;
        }

        private void telNoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (telNoRadioButton.Checked) araTextBox.KeyPress += araTextBox_KeyPress;
            else araTextBox.KeyPress -= araTextBox_KeyPress;
        }

        private void siparisNoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (siparisNoRadioButton.Checked) araTextBox.KeyPress += araTextBox_KeyPress;
            else araTextBox.KeyPress -= araTextBox_KeyPress;
        }

        private void araButton_Click(object sender, EventArgs e)
        {
            if (musteriAdiRadioButton.Checked)
            {
                if (string.IsNullOrWhiteSpace(araTextBox.Text)) butunMusterileriGoster();
                else musteriAdiAra();

            }
            else if (telNoRadioButton.Checked)
            {
                if (string.IsNullOrWhiteSpace(araTextBox.Text)) butunMusterileriGoster();
                else telNoAra();
            }
            else if (siparisNoRadioButton.Checked)
            {
                if (string.IsNullOrWhiteSpace(araTextBox.Text)) butunSiparisleriGoster();
                else siparisNoAra();
            }
            else butunMusterileriGoster();
        }

        private void araTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        void butunMusterileriGoster()
        {
            string komut = "SELECT * FROM musteriler";

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            connect.Close();
            musteriDataGridView.DataSource = dt;
            musteriDataGridView.Columns["Kimlik"].Visible = false;
        }

        void musteriAdiAra()
        {
            string arama = "%" + araTextBox.Text + "%";
            string komut = "SELECT * FROM musteriler WHERE adiSoyadi LIKE '" + arama + "'";

            connect.Open();


            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Aradığını kriterlere uygun müşteri bulunamadı!!");
            }
            else
            {
                musteriDataGridView.DataSource = dt;
                musteriDataGridView.Columns["Kimlik"].Visible = false;
            }

            connect.Close();
        }

        void telNoAra()
        {
            string arama = "%" + araTextBox.Text + "%";
            string komut = "SELECT * FROM musteriler WHERE telNo LIKE '" + arama + "'";

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Aradığını kriterlere uygun müşteri bulunamadı!!");
            }
            else
            {
                musteriDataGridView.DataSource = dt;
                musteriDataGridView.Columns["Kimlik"].Visible = false;
            }

            connect.Close();
        }

        void butunSiparisleriGoster()
        {
            string komut = "SELECT * FROM siparisler WHERE siparisNo ";

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Aradığını kriterlere uygun müşteri bulunamadı!!");
            }
            else
            {
                musteriDataGridView.DataSource = dt;
            }

            connect.Close();
        }

        void siparisNoAra()
        {
            int arama = int.Parse(araTextBox.Text);
            string komut = "SELECT * FROM siparisler WHERE siparisNo LIKE '%" + arama + "%'";

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Aradığını kriterlere uygun müşteri bulunamadı!!");
            }
            else
            {
                musteriDataGridView.DataSource = dt;
            }

            connect.Close();
        }
    }
}
