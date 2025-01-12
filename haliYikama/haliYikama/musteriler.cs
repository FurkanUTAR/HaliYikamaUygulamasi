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
            araTextBox.KeyPress -= araTextBox_KeyPress;
            butunMusterileriGoster();
            yukle();
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
            musteriEkle.ShowDialog();
            this.Hide();
        }

        private void musteriDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (siparisNoRadioButton.Checked)
            {
                try
                {
                    if (e.RowIndex >= 0) // Tıkladığın satırın geçerli bir satır olduğundan emin ol
                    {
                        DataGridViewRow row = musteriDataGridView.Rows[e.RowIndex];
                        int siparisNo = int.Parse(row.Cells["siparisNo"].Value.ToString());
                        string adSoyad = row.Cells["adSoyad"].Value.ToString();
                        string telNo = row.Cells["telNo"].Value.ToString();
                        string adres = row.Cells["adres"].Value.ToString();

                        siparisOlustur siparisOlustur = new siparisOlustur();
                        siparisOlustur.Kimlik = siparisNo;
                        siparisOlustur.adSoyad = adSoyad;
                        siparisOlustur.telNo = telNo;
                        siparisOlustur.adres = adres;
                        siparisOlustur.islem = "siparis";
                        siparisOlustur.ShowDialog();
                        this.Hide();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen geçerli bir kayıt seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    if (e.RowIndex >= 0) // Tıkladığın satırın geçerli bir satır olduğundan emin ol
                    {
                        DataGridViewRow row = musteriDataGridView.Rows[e.RowIndex];
                        int kimlik = int.Parse(row.Cells["Kimlik"].Value.ToString());
                        string adSoyad = row.Cells["adSoyad"].Value.ToString();
                        string telNo = row.Cells["telNo"].Value.ToString();
                        string adres = row.Cells["adres"].Value.ToString();

                        siparisOlustur siparisOlustur = new siparisOlustur();
                        siparisOlustur.Kimlik = kimlik;
                        siparisOlustur.adSoyad = adSoyad;
                        siparisOlustur.telNo = telNo;
                        siparisOlustur.adres = adres;
                        siparisOlustur.islem = "musteri";
                        siparisOlustur.ShowDialog();
                        this.Hide();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Lütfen geçerli bir kayıt seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void musteriAdiRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (musteriAdiRadioButton.Checked) araTextBox.KeyPress -= araTextBox_KeyPress;
        }

        private void adresRadiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if (adresRadiobutton.Checked) araTextBox.KeyPress -= araTextBox_KeyPress;
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

        private void araButton_MouseEnter(object sender, EventArgs e)
        {
            araButton.BackColor = Color.FromArgb(160, 190, 210);
        }

        private void araButton_MouseLeave(object sender, EventArgs e)
        {
            araButton.BackColor = Color.FromArgb(200, 220, 240);
        }

        private void araButton_Click(object sender, EventArgs e)
        {
            if (musteriAdiRadioButton.Checked)
            {
                if (string.IsNullOrWhiteSpace(araTextBox.Text)) butunMusterileriGoster();
                else musteriAdiAra();

            }
            else if (adresRadiobutton.Checked)
            {
                if (string.IsNullOrWhiteSpace(araTextBox.Text)) butunMusterileriGoster();
                else adresAra();
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
            string komut = "SELECT * FROM musteriler WHERE adSoyad LIKE '" + arama + "'";

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0) MessageBox.Show("Aradığını kriterlere uygun müşteri bulunamadı!!");
            else
            {
                musteriDataGridView.DataSource = dt;
                musteriDataGridView.Columns["Kimlik"].Visible = false;
            }

            connect.Close();
        }

        void adresAra()
        {
            string arama = "%" + araTextBox.Text + "%";
            string komut = "SELECT * FROM musteriler WHERE adres LIKE '" + arama + "'";

            connect.Open();


            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0) MessageBox.Show("Aradığını kriterlere uygun müşteri bulunamadı!!");
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

            if (dt.Rows.Count == 0) MessageBox.Show("Aradığını kriterlere uygun müşteri bulunamadı!!");
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

            if (dt.Rows.Count == 0) MessageBox.Show("Aradığını kriterlere uygun müşteri bulunamadı!!");
            else musteriDataGridView.DataSource = dt;

            connect.Close();

            yukle();
        }

        void siparisNoAra()
        {
            int arama = int.Parse(araTextBox.Text);
            string komut = "SELECT * FROM siparisler WHERE siparisNo LIKE '%" + arama + "%'";

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0) MessageBox.Show("Aradığını kriterlere uygun müşteri bulunamadı!!");
            else musteriDataGridView.DataSource = dt;

            connect.Close();
        }

        void yukle()
        {
            if (musteriDataGridView != null && musteriDataGridView.Columns.Count > 0)
            {
                if (musteriDataGridView.Columns.Contains("adSoyad")) musteriDataGridView.Columns["adSoyad"].HeaderText = "Adı Soyadı";
                if (musteriDataGridView.Columns.Contains("telNo")) musteriDataGridView.Columns["telNo"].HeaderText = "Telefon Numarası";
                if (musteriDataGridView.Columns.Contains("adres")) musteriDataGridView.Columns["adres"].HeaderText = "Adresi";
                if (musteriDataGridView.Columns.Contains("eklemeTarih")) musteriDataGridView.Columns["eklemeTarih"].HeaderText = "Kayıt Olma Tarihi";

                if (musteriDataGridView.Columns.Contains("siparisNo")) musteriDataGridView.Columns["siparisNo"].HeaderText = "Sipariş Numarası";
                if (musteriDataGridView.Columns.Contains("siparisTarih")) musteriDataGridView.Columns["siparisTarih"].HeaderText = "Alınma Tarihi";
                if (musteriDataGridView.Columns.Contains("siparisNotu")) musteriDataGridView.Columns["siparisNotu"].HeaderText = "Sipariş Notu";
                if (musteriDataGridView.Columns.Contains("siparisDurum")) musteriDataGridView.Columns["siparisDurum"].HeaderText = "Sipariş Durumu";
                if (musteriDataGridView.Columns.Contains("teslimTarih")) musteriDataGridView.Columns["teslimTarih"].HeaderText = "Teslim Edilme Tarihi";
                if (musteriDataGridView.Columns.Contains("haliAdet")) musteriDataGridView.Columns["haliAdet"].HeaderText = "Halı Adeti";
                if (musteriDataGridView.Columns.Contains("siparisTutar")) musteriDataGridView.Columns["siparisTutar"].HeaderText = "Sipariş Tutarı";
                if (musteriDataGridView.Columns.Contains("veresiyeTutar")) musteriDataGridView.Columns["veresiyeTutar"].Visible = false;
                if (musteriDataGridView.Columns.Contains("indirimMiktar")) musteriDataGridView.Columns["indirimMiktar"].HeaderText = "İndirim Miktarı";
            }
            else MessageBox.Show("DataGridView başlatılmadı veya sütunları yok.");

            musteriDataGridView.BackgroundColor = Color.FromArgb(240, 245, 250);
            musteriDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 250);
            musteriDataGridView.EnableHeadersVisualStyles = false;
            musteriDataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 245, 250);
            musteriDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 235, 245);
            musteriDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 220, 240);
            musteriDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 220, 240);
            musteriDataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
        }
    }
}
