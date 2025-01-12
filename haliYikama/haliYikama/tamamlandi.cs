using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace haliYikama
{
    public partial class tamamlandi : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public tamamlandi()
        {
            InitializeComponent();
        }

        private void tamamlandi_Load(object sender, EventArgs e)
        {
            butunSiparisleriGoster();
            yukle();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void musteriAdiRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (musteriAdiRadioButton.Checked) araTextBox.KeyPress -= araTextBox_KeyPress;
        }

        private void adresRadiobutton_CheckedChanged(object sender, EventArgs e)
        {
            if (telNoRadioButton.Checked) araTextBox.KeyPress -= araTextBox_KeyPress;
            else araTextBox.KeyPress += araTextBox_KeyPress;
        }

        private void araTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
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
                if (string.IsNullOrWhiteSpace(araTextBox.Text)) butunSiparisleriGoster();
                else musteriAdiAra();

            }
            else if (adresRadiobutton.Checked)
            {
                if (string.IsNullOrWhiteSpace(araTextBox.Text)) butunSiparisleriGoster();
                else adresAra();
            }
            else if (telNoRadioButton.Checked)
            {
                if (string.IsNullOrWhiteSpace(araTextBox.Text)) butunSiparisleriGoster();
                else telNoAra();
            }
            else if (siparisNoRadioButton.Checked)
            {
                if (string.IsNullOrWhiteSpace(araTextBox.Text)) butunSiparisleriGoster();
                else siparisNoAra();
            }
            else butunSiparisleriGoster();
        }

        void musteriAdiAra()
        {
            string arama = "%" + araTextBox.Text + "%";
            string komut = "SELECT * FROM siparisler WHERE adiSoyadi LIKE '" + arama + "' AND siparisDurum='Tamamlandı'";

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
                tamamlandiDataGridView.DataSource = dt;
            }

            connect.Close();

            tamamlandiDataGridView.Columns["veresiyeTutar"].Visible = false;
        }

        void telNoAra()
        {
            string arama = "%" + araTextBox.Text + "%";
            string komut = "SELECT * FROM siparisler WHERE telNo LIKE '" + arama + "' AND siparisDurum='Tamamlandı'";

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
                tamamlandiDataGridView.DataSource = dt;
            }

            connect.Close();

            tamamlandiDataGridView.Columns["veresiyeTutar"].Visible = false;
        }

        void butunSiparisleriGoster()
        {
            string komut = "SELECT * FROM siparisler WHERE siparisDurum='Tamamlandı' ";

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0) MessageBox.Show("Aradığını kriterlere uygun müşteri bulunamadı!!");
            else
            {
                tamamlandiDataGridView.DataSource = dt;
                tamamlandiDataGridView.Columns["veresiyeTutar"].Visible = false;
            }

            connect.Close();
        }

        void siparisNoAra()
        {
            int arama = int.Parse(araTextBox.Text);
            string komut = "SELECT * FROM siparisler WHERE siparisNo LIKE '%" + arama + "%' AND siparisDurum='Tamamlandı'";

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
                tamamlandiDataGridView.DataSource = dt;
            }

            connect.Close();

            tamamlandiDataGridView.Columns["veresiyeTutar"].Visible = false;
        }

        void adresAra()
        {
            string arama = "%" + araTextBox.Text + "%";
            string komut = "SELECT * FROM siparisler WHERE adres LIKE '" + arama + "' AND siparisDurum = 'Tamamlandı' ";

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0) MessageBox.Show("Aradığını kriterlere uygun müşteri bulunamadı!!");
            else
            {
                tamamlandiDataGridView.DataSource = dt;
                if (tamamlandiDataGridView.Columns.Contains("veresiyeTutar")) tamamlandiDataGridView.Columns["veresiyeTutar"].Visible = false;
            }

            connect.Close();
        }

        void yukle()
        {
            if (tamamlandiDataGridView != null && tamamlandiDataGridView.Columns.Count > 0)
            {
                if (tamamlandiDataGridView.Columns.Contains("adSoyad")) tamamlandiDataGridView.Columns["adSoyad"].HeaderText = "Adı Soyadı";
                if (tamamlandiDataGridView.Columns.Contains("telNo")) tamamlandiDataGridView.Columns["telNo"].HeaderText = "Telefon Numarası";
                if (tamamlandiDataGridView.Columns.Contains("adres")) tamamlandiDataGridView.Columns["adres"].HeaderText = "Adresi";
                if (tamamlandiDataGridView.Columns.Contains("eklemeTarih")) tamamlandiDataGridView.Columns["eklemeTarih"].HeaderText = "Kayıt Olma Tarihi";

                if (tamamlandiDataGridView.Columns.Contains("siparisNo")) tamamlandiDataGridView.Columns["siparisNo"].HeaderText = "Sipariş Numarası";
                if (tamamlandiDataGridView.Columns.Contains("siparisTarih")) tamamlandiDataGridView.Columns["siparisTarih"].HeaderText = "Alınma Tarihi";
                if (tamamlandiDataGridView.Columns.Contains("siparisNotu")) tamamlandiDataGridView.Columns["siparisNotu"].HeaderText = "Sipariş Notu";
                if (tamamlandiDataGridView.Columns.Contains("siparisDurum")) tamamlandiDataGridView.Columns["siparisDurum"].HeaderText = "Sipariş Durumu";
                if (tamamlandiDataGridView.Columns.Contains("teslimTarih")) tamamlandiDataGridView.Columns["teslimTarih"].HeaderText = "Teslim Edilme Tarihi";
                if (tamamlandiDataGridView.Columns.Contains("haliAdet")) tamamlandiDataGridView.Columns["haliAdet"].HeaderText = "Halı Adeti";
                if (tamamlandiDataGridView.Columns.Contains("siparisTutar")) tamamlandiDataGridView.Columns["siparisTutar"].HeaderText = "Sipariş Tutarı";
                if (tamamlandiDataGridView.Columns.Contains("indirimMiktar")) tamamlandiDataGridView.Columns["indirimMiktar"].HeaderText = "İndirim Miktarı";
            }
            else MessageBox.Show("DataGridView başlatılmadı veya sütunları yok.");

            tamamlandiDataGridView.BackgroundColor = Color.FromArgb(240, 245, 250);
            tamamlandiDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 250);
            tamamlandiDataGridView.EnableHeadersVisualStyles = false;
            tamamlandiDataGridView.RowHeadersVisible = false;
            tamamlandiDataGridView.ReadOnly = true;
            tamamlandiDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tamamlandiDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            tamamlandiDataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 245, 250);
            tamamlandiDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 235, 245);
            tamamlandiDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 220, 240);
            tamamlandiDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 220, 240);
            tamamlandiDataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
        }
    }
}
