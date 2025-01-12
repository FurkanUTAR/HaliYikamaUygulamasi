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
using System.Data.Common;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

namespace haliYikama
{
    public partial class siparisler : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        string islem;

        public siparisler()
        {
            InitializeComponent();
        }

        private void siparisler_Load(object sender, EventArgs e)
        {
            hepsiGoster();
            yukle();

            hepsiButton.BackColor = Color.FromArgb(150, 150, 180);
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void alinacakDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (islem=="alinacak") alinacakKontrol();
            else if (islem=="teslimat") teslimatKontrol();
            else if (islem=="veresiye") veresiyeKontrol();
            else hepsiKontrol();
        }

        private void alinacaklarButton_Click(object sender, EventArgs e)
        {
            alinacakGoster();
            islem = "alinacak";

            alinacaklarButton.BackColor = Color.FromArgb(150, 150, 180);
            teslimatButton.BackColor = Color.FromArgb(200, 200, 220);
            veresiyeButton.BackColor = Color.FromArgb(200, 200, 220);
            hepsiButton.BackColor = Color.FromArgb(200, 200, 220);
        }

        private void teslimatButton_Click(object sender, EventArgs e)
        {
            teslimatGoster();
            islem = "teslimat";

            teslimatButton.BackColor = Color.FromArgb(150, 150, 180);
            alinacaklarButton.BackColor = Color.FromArgb(200, 200, 220);
            veresiyeButton.BackColor = Color.FromArgb(200, 200, 220);
            hepsiButton.BackColor = Color.FromArgb(200, 200, 220);
        }

        private void veresiyeButton_Click(object sender, EventArgs e)
        {
            veresiyeGoster();
            islem = "veresiye";

            veresiyeButton.BackColor = Color.FromArgb(150, 150, 180);
            teslimatButton.BackColor = Color.FromArgb(200, 200, 220);
            alinacaklarButton.BackColor = Color.FromArgb(200, 200, 220);
            hepsiButton.BackColor = Color.FromArgb(200, 200, 220);
        }

        private void hepsiButton_Click(object sender, EventArgs e)
        {
            hepsiGoster();

            hepsiButton.BackColor = Color.FromArgb(150, 150, 180);
            teslimatButton.BackColor = Color.FromArgb(200, 200, 220);
            veresiyeButton.BackColor = Color.FromArgb(200, 200, 220);
            alinacaklarButton.BackColor = Color.FromArgb(200, 200, 220);
        }

        void alinacakGoster()
        {
            string tarih = DateTime.Now.ToString("yyyy-MM-dd"); // Bugünün tarihi
            string komut = $"SELECT * FROM siparisler WHERE siparisDurum = 'Alınacak' AND siparisTarih = #{tarih}#";

            //string komut = "SELECT * FROM siparisler WHERE siparisDurum = 'Alınacak' AND FORMAT(siparisTarih, 'yyyy-MM-dd') = " + DateTime.Now.ToString("yyyy-MM-dd") + "";

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            siparisDataGridView.DataSource = dt;
            siparisDataGridView.Columns["siparisDurum"].Visible = false;
            siparisDataGridView.Columns["teslimTarih"].Visible = false;
            siparisDataGridView.Columns["siparisTutar"].Visible = false;
            siparisDataGridView.Columns["indirimMiktar"].Visible = false;
            siparisDataGridView.Columns["haliAdet"].Visible = false;
            siparisDataGridView.Columns["veresiyeTutar"].Visible = false;
            siparisDataGridView.Columns["siparisTarih"].Visible = true;

            connect.Close();

        }

        void teslimatGoster()
        {
            string komut = "SELECT * FROM siparisler WHERE siparisDurum = 'Teslimat'";

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            siparisDataGridView.DataSource = dt;
            siparisDataGridView.Columns["siparisDurum"].Visible = false;
            siparisDataGridView.Columns["siparisTarih"].Visible = false;
            siparisDataGridView.Columns["veresiyeTutar"].Visible = false;
            siparisDataGridView.Columns["teslimTarih"].Visible = true;
            siparisDataGridView.Columns["siparisTutar"].Visible = true;
            siparisDataGridView.Columns["indirimMiktar"].Visible = true;
            siparisDataGridView.Columns["haliAdet"].Visible = true;

            connect.Close();
        }

        void veresiyeGoster()
        {
            string komut = "SELECT * FROM siparisler WHERE siparisDurum = 'Veresiye'";

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            siparisDataGridView.DataSource = dt;
            siparisDataGridView.Columns["siparisDurum"].Visible = false;
            siparisDataGridView.Columns["siparisTarih"].Visible = false;
            siparisDataGridView.Columns["veresiyeTutar"].Visible = true;
            siparisDataGridView.Columns["teslimTarih"].Visible = true;
            siparisDataGridView.Columns["siparisTutar"].Visible = true;
            siparisDataGridView.Columns["indirimMiktar"].Visible = true;
            siparisDataGridView.Columns["haliAdet"].Visible = true;

            connect.Close();
        }

        void hepsiGoster()
        {
            string komut = "SELECT * FROM siparisler WHERE siparisDurum = 'Alınacak' OR siparisDurum = 'Teslimat' OR siparisDurum = 'Veresiye'";

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            siparisDataGridView.DataSource = dt;
            siparisDataGridView.Columns["siparisDurum"].Visible = true;
            siparisDataGridView.Columns["teslimTarih"].Visible = true;
            siparisDataGridView.Columns["siparisTutar"].Visible = true;
            siparisDataGridView.Columns["indirimMiktar"].Visible = true;
            siparisDataGridView.Columns["haliAdet"].Visible = true;
            siparisDataGridView.Columns["veresiyeTutar"].Visible = true;

            connect.Close();
        }

        void alinacakKontrol()
        {
            if (siparisDataGridView.CurrentRow != null) // Seçili satır var mı?
            {
                var cellValue = siparisDataGridView.CurrentRow.Cells[0].Value; // Hücre değeri alınır

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int siparisNo)) // Geçerli bir sayı mı?
                {
                    alinacaklar alinacaklar = new alinacaklar();
                    alinacaklar.siparisNo = siparisNo;
                    alinacaklar.Show();
                    this.Hide();
                }
                else MessageBox.Show("Seçilen kaydın Sipariş Numarası geçerli bir sayı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Lütfen geçerli bir kayıt seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        void teslimatKontrol()
        {
            if (siparisDataGridView.CurrentRow != null) // Seçili satır var mı?
            {
                var cellValue = siparisDataGridView.CurrentRow.Cells[0].Value; // Hücre değeri alınır

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int siparisNo)) // Geçerli bir sayı mı?
                {
                    teslimEdilecekler teslimEdilecekler = new teslimEdilecekler();
                    teslimEdilecekler.siparisNo = siparisNo;
                    teslimEdilecekler.Show();
                    this.Hide();
                }
                else MessageBox.Show("Seçilen kaydın Sipariş Numarası geçerli bir sayı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Lütfen geçerli bir kayıt seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        void veresiyeKontrol()
        {

            if (siparisDataGridView.CurrentRow != null) // Seçili satır var mı?
            {
                var cellValue = siparisDataGridView.CurrentRow.Cells[0].Value; // Hücre değeri alınır

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int siparisNo)) // Geçerli bir sayı mı?
                {
                    veresiye veresiye = new veresiye();
                    veresiye.siparisNo = siparisNo;
                    veresiye.Show();
                    this.Hide();
                }
                else MessageBox.Show("Seçilen kaydın Sipariş Numarası geçerli bir sayı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Lütfen geçerli bir kayıt seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        void hepsiKontrol()
        {
            if (siparisDataGridView.CurrentRow != null) // Seçili satır var mı?
            {
                var cellValue = siparisDataGridView.CurrentRow.Cells[0].Value; // Hücre değeri alınır

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int siparisNo)) // Geçerli bir sayı mı?
                {
                    string durum = siparisDataGridView.CurrentRow.Cells["siparisDurum"].Value.ToString();

                    if (durum == "Alınacak")
                    {
                        islem = "alinacak";
                        alinacaklar alinacaklar = new alinacaklar();
                        alinacaklar.siparisNo = siparisNo;
                        alinacaklar.Show();
                        this.Hide();
                    }
                    else if (durum == "Teslimat")
                    {
                        islem = "teslimat";
                        teslimEdilecekler teslimEdilecekler = new teslimEdilecekler();
                        teslimEdilecekler.siparisNo = siparisNo;
                        teslimEdilecekler.Show();
                        this.Hide();
                    }
                    else if (durum == "Veresiye")
                    {
                        islem = "veresiye";
                        veresiye veresiye = new veresiye();
                        veresiye.siparisNo = siparisNo;
                        veresiye.Show();
                        this.Hide();
                    }
                    else MessageBox.Show($"Geçersiz durum: {durum}");
                }
                else MessageBox.Show("Seçilen kaydın Sipariş Numarası geçerli bir sayı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Lütfen geçerli bir kayıt seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        void yukle()
        {
            if (siparisDataGridView != null && siparisDataGridView.Columns.Count > 0)
            {
                if (siparisDataGridView.Columns.Contains("adSoyad")) siparisDataGridView.Columns["adSoyad"].HeaderText = "Adı Soyadı";
                if (siparisDataGridView.Columns.Contains("telNo")) siparisDataGridView.Columns["telNo"].HeaderText = "Telefon Numarası";
                if (siparisDataGridView.Columns.Contains("adres")) siparisDataGridView.Columns["adres"].HeaderText = "Adresi";
                if (siparisDataGridView.Columns.Contains("eklemeTarih")) siparisDataGridView.Columns["eklemeTarih"].HeaderText = "Kayıt Olma Tarihi";

                if (siparisDataGridView.Columns.Contains("siparisNo")) siparisDataGridView.Columns["siparisNo"].HeaderText = "Sipariş Numarası";
                if (siparisDataGridView.Columns.Contains("siparisTarih")) siparisDataGridView.Columns["siparisTarih"].HeaderText = "Alınma Tarihi";
                if (siparisDataGridView.Columns.Contains("siparisNotu")) siparisDataGridView.Columns["siparisNotu"].HeaderText = "Sipariş Notu";
                if (siparisDataGridView.Columns.Contains("siparisDurum")) siparisDataGridView.Columns["siparisDurum"].HeaderText = "Sipariş Durumu";
                if (siparisDataGridView.Columns.Contains("teslimTarih")) siparisDataGridView.Columns["teslimTarih"].HeaderText = "Teslim Edilme Tarihi";
                if (siparisDataGridView.Columns.Contains("haliAdet")) siparisDataGridView.Columns["haliAdet"].HeaderText = "Halı Adeti";
                if (siparisDataGridView.Columns.Contains("siparisTutar")) siparisDataGridView.Columns["siparisTutar"].HeaderText = "Sipariş Tutarı";
                if (siparisDataGridView.Columns.Contains("veresiyeTutar")) siparisDataGridView.Columns["veresiyeTutar"].HeaderText = "Veresiye Tutar";
                if (siparisDataGridView.Columns.Contains("indirimMiktar")) siparisDataGridView.Columns["indirimMiktar"].HeaderText = "İndirim Miktarı";
            }
            else
            {
                MessageBox.Show("DataGridView başlatılmadı veya sütunları yok.");
            }

            siparisDataGridView.BackgroundColor = Color.FromArgb(240, 245, 250);
            siparisDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 245, 250);
            siparisDataGridView.EnableHeadersVisualStyles = false;
            siparisDataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 245, 250);
            siparisDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 235, 245);
            siparisDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 220, 240);
            siparisDataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 220, 240);
            siparisDataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
        }
    }
}
