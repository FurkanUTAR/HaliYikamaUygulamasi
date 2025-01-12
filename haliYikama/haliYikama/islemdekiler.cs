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
    public partial class islemdekiler : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public islemdekiler()
        {
            InitializeComponent();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void islemdekiler_Load(object sender, EventArgs e)
        {
            yukle();
        }

        private void islemdekilerDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            kontrol();
        }

        void kontrol()
        {
            var cellValue = islemdekilerDataGridView.CurrentRow.Cells[0].Value;
            if (cellValue != null && int.TryParse(cellValue.ToString(), out int siparisNo))
            {
                siparisDetay siparisDetay = new siparisDetay();
                siparisDetay.siparisNo = siparisNo;
                siparisDetay.ShowDialog();
                this.Hide();
            }
            else MessageBox.Show("Seçilen kaydın Sipariş Numarası geçerli bir sayı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void yukle()
        {
            string komut = "SELECT * FROM siparisler WHERE siparisDurum='Islemde'";

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            islemdekilerDataGridView.DataSource = dt;

            connect.Close();

            if (islemdekilerDataGridView != null && islemdekilerDataGridView.Columns.Count > 0)
            {
                if (islemdekilerDataGridView.Columns.Contains("siparisNotu")) islemdekilerDataGridView.Columns["siparisNotu"].Visible = false;
                if (islemdekilerDataGridView.Columns.Contains("siparisDurum")) islemdekilerDataGridView.Columns["siparisDurum"].Visible = false;
                if (islemdekilerDataGridView.Columns.Contains("teslimTarih")) islemdekilerDataGridView.Columns["teslimTarih"].Visible = false;
                if (islemdekilerDataGridView.Columns.Contains("veresiyeTutar")) islemdekilerDataGridView.Columns["veresiyeTutar"].Visible = false;

                if (islemdekilerDataGridView.Columns.Contains("siparisNo")) islemdekilerDataGridView.Columns["siparisNo"].HeaderText = "Sipariş Numarası";
                if (islemdekilerDataGridView.Columns.Contains("adSoyad")) islemdekilerDataGridView.Columns["adSoyad"].HeaderText = "Adı Soyadı";
                if (islemdekilerDataGridView.Columns.Contains("telNo")) islemdekilerDataGridView.Columns["telNo"].HeaderText = "Telefon Numarası";
                if (islemdekilerDataGridView.Columns.Contains("adres")) islemdekilerDataGridView.Columns["adres"].HeaderText = "Adresi";
                if (islemdekilerDataGridView.Columns.Contains("siparisTarih")) islemdekilerDataGridView.Columns["siparisTarih"].HeaderText = "Sipariş Tarihi";
                if (islemdekilerDataGridView.Columns.Contains("siparisNotu")) islemdekilerDataGridView.Columns["siparisNotu"].HeaderText = "Sipariş Notu";
                if (islemdekilerDataGridView.Columns.Contains("siparisDurum")) islemdekilerDataGridView.Columns["siparisDurum"].HeaderText = "Sipariş Durumu";
                if (islemdekilerDataGridView.Columns.Contains("teslimTarih")) islemdekilerDataGridView.Columns["teslimTarih"].HeaderText = "Teslim Edilme Tarihi";
                if (islemdekilerDataGridView.Columns.Contains("haliAdet")) islemdekilerDataGridView.Columns["haliAdet"].HeaderText = "Halı Adeti";
                if (islemdekilerDataGridView.Columns.Contains("siparisTutar")) islemdekilerDataGridView.Columns["siparisTutar"].HeaderText = "Sipariş Tutarı";
                if (islemdekilerDataGridView.Columns.Contains("veresiyeTutar")) islemdekilerDataGridView.Columns["veresiyeTutar"].HeaderText = "Veresiye Tutar";
                if (islemdekilerDataGridView.Columns.Contains("indirimMiktar")) islemdekilerDataGridView.Columns["indirimMiktar"].HeaderText = "İndirim Miktarı";
            }
            else MessageBox.Show("DataGridView başlatılmadı veya sütunları yok.");

            islemdekilerDataGridView.BackgroundColor = Color.FromArgb(240, 245, 250);
            islemdekilerDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 250);
            islemdekilerDataGridView.ReadOnly = true;
            islemdekilerDataGridView.RowHeadersVisible = false;
            islemdekilerDataGridView.EnableHeadersVisualStyles = false;
            islemdekilerDataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 245, 250);
            islemdekilerDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 235, 245);
            islemdekilerDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 220, 240);
            islemdekilerDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 220, 240);
            islemdekilerDataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
        }
    }
}
