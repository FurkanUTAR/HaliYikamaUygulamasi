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
using System.Globalization;

namespace haliYikama
{
    public partial class siparisOlustur : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public string adSoyad { get; set; }
        public string telNo { get; set; }
        public string adres { get; set; }
        public int Kimlik { get; set; }
        public string islem { get; set; }

        public siparisOlustur()
        {
            InitializeComponent();
        }

        private void siparisOlustur_Load(object sender, EventArgs e)
        {
            veriGuncelle();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            musteriler musteriler = new musteriler();
            musteriler.Show();
            this.Hide();
        }

        private void musteriDuzenleButton_Click(object sender, EventArgs e)
        {
            musteriDuzenle musteriDuzenle = new musteriDuzenle();
            musteriDuzenle.adSoyad = adSoyad;
            musteriDuzenle.telNo = telNo;
            musteriDuzenle.adres = adres;
            musteriDuzenle.kimlik = Kimlik;
            musteriDuzenle.islem = islem;
            musteriDuzenle.ShowDialog();
            this.Hide();
        }

        private void siparisOlusturButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sipariş oluşturmak istediğinden emin misin?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                databaseSiparisOlustur();
                musteriler musteriler = new musteriler();
                musteriler.Show();
                this.Hide();
            }
        }

        private void musteriSilButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Müşteriyi silmek istediğinden emin misin?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                musteriSil();
                musteriler musteriler = new musteriler();
                musteriler.Show();
                this.Hide();
            }
        }

        void databaseSiparisOlustur()
        {
            string adSoyad = adSoyadLabel.Text;
            string telNo = telNoLabel.Text;
            string adres = adresLabel.Text;
            string siparisTarihi = siparisTarihiDateTimePicker.Value.ToString("yyyy-MM-dd");
            string siparisNotu = siparisNotuTextBox.Text;
            string siparisDurum = "Alınacak";

            string komut = $"INSERT INTO siparisler (adSoyad, telNo, adres, siparisTarih, siparisNotu, siparisDurum) "
                         + $"VALUES ('{adSoyad}', '{telNo}', '{adres}', '{siparisTarihi}', '{siparisNotu}', '{siparisDurum}')";
            connect.Open();

            OleDbCommand cmd = new OleDbCommand(komut, connect);
            cmd.ExecuteNonQuery();

            connect.Close();
        }

        void musteriSil()
        {
            string komut = "DELETE FROM musteriler WHERE Kimlik=" + Kimlik + "";

            connect.Open();

            OleDbCommand cmd = new OleDbCommand(komut, connect);
            cmd.ExecuteNonQuery();

            connect.Close();
        }

        void veriGuncelle()
        {
            if (islem == "musteri")
            {
                string komut = "SELECT * FROM musteriler WHERE Kimlik = " + Kimlik;

                connect.Open();

                OleDbCommand cmd = new OleDbCommand(komut, connect);
                OleDbDataReader oku = cmd.ExecuteReader();

                if (oku.Read())
                {
                    adSoyadLabel.Text = oku.GetString(1).ToString();
                    telNoLabel.Text = oku.GetString(2).ToString();
                    adresLabel.Text = oku.GetString(3).ToString();
                }
                else MessageBox.Show("Hata!!");

                connect.Close();

                //adSoyadLabel.Text = adSoyad;
                //telNoLabel.Text = telNo;
                //adresLabel.Text = adres;

                siparisTarihiDateTimePicker.Value = DateTime.Now;
            }
            else
            {
                string komut = "SELECT * FROM siparisler WHERE siparisNo = " + Kimlik;

                connect.Open();

                OleDbCommand cmd = new OleDbCommand(komut, connect);
                OleDbDataReader oku = cmd.ExecuteReader();

                if (oku.Read())
                {
                    adSoyadLabel.Text = oku.GetString(1).ToString();
                    telNoLabel.Text = oku.GetString(2).ToString();
                    adresLabel.Text = oku.GetString(3).ToString();
                }
                else MessageBox.Show("Hata!!");

                connect.Close();

                //adSoyadLabel.Text = adSoyad;
                //telNoLabel.Text = telNo;
                //adresLabel.Text = adres;

                siparisTarihiDateTimePicker.Value = DateTime.Now;
            }
        }
    }
}
