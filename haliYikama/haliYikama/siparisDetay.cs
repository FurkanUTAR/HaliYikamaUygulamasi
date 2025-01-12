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
    public partial class siparisDetay : Form
    {

        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        double toplamFiyat;
        double haliAdet;
        double indirimMiktari;

        public int siparisNo { get; set; }

        public siparisDetay()
        {
            InitializeComponent();
        }

        private void siparisDetay_Load(object sender, EventArgs e)
        {
            yukle();
            indirimHesap();
            adet();
            toplam();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            islemdekiler islemdekiler = new islemdekiler();
            islemdekiler.Show();
            this.Hide();
        }

        private void teslimatCekButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Teslimata çekmek istediğinden emin misin?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                teslimatCek();

                islemdekiler islemdekiler = new islemdekiler();
                islemdekiler.Show();
                this.Hide();
            }
        }

        private void yenilePictureBox_Click(object sender, EventArgs e)
        {
            yukle();
            indirimHesap();
            adet();
            toplam();
        }

        private void haliEkleButton_MouseEnter(object sender, EventArgs e)
        {
            haliEkleButton.BackColor = Color.FromArgb(160, 190, 210);
        }

        private void haliCikarButton_MouseEnter(object sender, EventArgs e)
        {
            haliCikarButton.BackColor = Color.FromArgb(160, 190, 210);
        }

        private void teslimatCekButton_MouseEnter(object sender, EventArgs e)
        {
            teslimatCekButton.BackColor = Color.FromArgb(160, 190, 210);
        }

        private void haliEkleButton_MouseLeave(object sender, EventArgs e)
        {
            haliEkleButton.BackColor = Color.FromArgb(200, 220, 240);
        }

        private void haliCikarButton_MouseLeave(object sender, EventArgs e)
        {
            haliCikarButton.BackColor = Color.FromArgb(200, 220, 240);
        }

        private void teslimatCekButton_MouseLeave(object sender, EventArgs e)
        {
            teslimatCekButton.BackColor = Color.FromArgb(200, 220, 240);
        }

        private void haliEkleButton_Click(object sender, EventArgs e)
        {
            haliEkle haliEkle = new haliEkle();
            haliEkle.siparisNo = siparisNo;
            haliEkle.ShowDialog();
        }

        private void haliCikarButton_Click(object sender, EventArgs e)
        {
            haliCikar();
            yukle();
            indirimHesap();
            toplam();
            adet();
        }

        void toplam()
        {
            string komut = "SELECT SUM(haliFiyat) FROM haliBilgi WHERE siparisNo=" + siparisNo;

            connect.Open();

            OleDbCommand cmd = new OleDbCommand(komut, connect);
            object sonuc = cmd.ExecuteScalar();
            if (sonuc != DBNull.Value) toplamFiyat = Convert.ToDouble(sonuc) - indirimMiktari;
            else MessageBox.Show("Toplam fiyat hesaplanamadı.");

            connect.Close();

            toplamFiyatLabel.Text = toplamFiyat.ToString() + " ₺";
        }

        void adet()
        {
            string komut = "SELECT SUM(haliAdet) FROM haliBilgi WHERE siparisNo=" + siparisNo;

            connect.Open();

            OleDbCommand cmd = new OleDbCommand(komut, connect);
            object sonuc = cmd.ExecuteScalar();
            if (sonuc != DBNull.Value) haliAdet = Convert.ToDouble(sonuc);
            else MessageBox.Show("Halı adet hesaplanamadı.");

            connect.Close();

            adetLabel.Text = haliAdet.ToString() + " Adet";
        }

        void teslimatCek()
        {
            string komut = "UPDATE siparisler SET siparisDurum='Teslimat', siparisNotu='" + teslimatNotuTextBox.Text + "',siparisTutar=" + toplamFiyat + ",haliAdet='" + adetLabel.Text + "' WHERE siparisNo=" + siparisNo;

            connect.Open();

            OleDbCommand cmd = new OleDbCommand(komut, connect);
            cmd.ExecuteNonQuery();

            connect.Close();
        }

        void haliCikar()
        {
            if (haliBilgiDataGridView.CurrentRow != null)
            {
                int kimlik = int.Parse(haliBilgiDataGridView.CurrentRow.Cells[0].Value.ToString());
                string komut = "DELETE FROM haliBilgi WHERE Kimlik=" + kimlik;

                connect.Open();

                OleDbCommand cmd = new OleDbCommand(komut, connect);
                cmd.ExecuteNonQuery();

                connect.Close();
            }
            else MessageBox.Show("Lütfen silmek için geçerli bir kayıt seçin.");
        }

        void indirimHesap()
        {
            string komut = "SELECT indirimMiktar FROM siparisler WHERE siparisNo =" + siparisNo;

            connect.Open();

            OleDbCommand cmd = new OleDbCommand(komut, connect);
            OleDbDataReader oku = cmd.ExecuteReader();
            if (oku.Read()) indirimMiktari = oku["indirimMiktar"] != DBNull.Value ? Convert.ToDouble(oku["indirimMiktar"]) : 0.0;

            connect.Close();
        }

        void yukle()
        {
            string komut = "SELECT * FROM haliBilgi WHERE siparisNo= " + siparisNo;

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            haliBilgiDataGridView.DataSource = dt;

            connect.Close();

            if (haliBilgiDataGridView != null && haliBilgiDataGridView.Columns.Count > 0)
            {
                if (haliBilgiDataGridView.Columns.Contains("Kimlik")) haliBilgiDataGridView.Columns["Kimlik"].Visible = false;
                if (haliBilgiDataGridView.Columns.Contains("siparisNo")) haliBilgiDataGridView.Columns["siparisNo"].Visible = false;

                if (haliBilgiDataGridView.Columns.Contains("siparisNo")) haliBilgiDataGridView.Columns["siparisNo"].HeaderText = "Sipariş Numarası";
                if (haliBilgiDataGridView.Columns.Contains("haliCins")) haliBilgiDataGridView.Columns["haliCins"].HeaderText = "Halı Cinsi";
                if (haliBilgiDataGridView.Columns.Contains("haliAdet")) haliBilgiDataGridView.Columns["haliAdet"].HeaderText = "Halı Adeti";
                if (haliBilgiDataGridView.Columns.Contains("haliBoyut")) haliBilgiDataGridView.Columns["haliBoyut"].HeaderText = "Halı Boyutu";
                if (haliBilgiDataGridView.Columns.Contains("haliFiyat")) haliBilgiDataGridView.Columns["haliFiyat"].HeaderText = "Halı Fiyatı";
            }
            else MessageBox.Show("DataGridView başlatılmadı veya sütunları yok.");

            haliBilgiDataGridView.BackgroundColor = Color.FromArgb(240, 245, 250);
            haliBilgiDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 250);
            haliBilgiDataGridView.ReadOnly = true;
            haliBilgiDataGridView.RowHeadersVisible = false;
            haliBilgiDataGridView.EnableHeadersVisualStyles = false;
            haliBilgiDataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 245, 250);
            haliBilgiDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 235, 245);
            haliBilgiDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 220, 240);
            haliBilgiDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 220, 240);
            haliBilgiDataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
        }
    }
}
