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
            goster();
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
            timer1.Start();
            timer1.Interval = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            goster();
            indirimHesap();
            adet();
            toplam();
            timer1.Stop();
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
            goster();
            indirimHesap();
            toplam();
            adet();
        }

        void goster()
        {
            string komut = "SELECT * FROM haliBilgi WHERE siparisNo= " + siparisNo;

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            haliBilgiDataGridView.DataSource = dt;

            connect.Close();
            haliBilgiDataGridView.Columns["Kimlik"].Visible = false;
            haliBilgiDataGridView.Columns["siparisNo"].Visible = false;
            haliBilgiDataGridView.Columns["haliCins"].HeaderText = "Cins";
            haliBilgiDataGridView.Columns["haliAdet"].HeaderText = "Adet";
            haliBilgiDataGridView.Columns["haliBoyut"].HeaderText = "Boyut";
            haliBilgiDataGridView.Columns["haliFiyat"].HeaderText = "Fiyat";
        }

        void toplam()
        {
            string komut = "SELECT SUM(haliFiyat) FROM haliBilgi WHERE siparisNo=" + siparisNo;

            connect.Open();

            OleDbCommand cmd = new OleDbCommand(komut, connect);
            object sonuc = cmd.ExecuteScalar();
            if (sonuc != DBNull.Value)
            {
                toplamFiyat = Convert.ToDouble(sonuc)-indirimMiktari;
            }
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
            if (sonuc != DBNull.Value)
            {
                haliAdet = Convert.ToDouble(sonuc);
            }
            else MessageBox.Show("Halı adet hesaplanamadı.");

            connect.Close();

            adetLabel.Text = haliAdet.ToString() + " Adet";
        }

        void teslimatCek()
        {
            string komut = "UPDATE siparisler SET siparisDurum='Teslimat', siparisNotu='" + teslimatNotuTextBox.Text + "',siparisTutar="+toplamFiyat+",haliAdet='"+adetLabel.Text+"' WHERE siparisNo=" + siparisNo;

            OleDbCommand cmd = new OleDbCommand(komut, connect);
            connect.Open();
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
            if (oku.Read())
            {
                indirimMiktari = oku["indirimMiktar"] != DBNull.Value ? Convert.ToDouble(oku["indirimMiktar"]) : 0.0;
            }
            connect.Close();
        }
    }
}
