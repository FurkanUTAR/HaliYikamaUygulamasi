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
using System.IO;

namespace haliYikama
{
    public partial class teslimEdilecekler : Form
    {

        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public int siparisNo { get; set; }
        public double indirim { get; set; }
        double toplamFiyat = 0;

        public teslimEdilecekler()
        {
            InitializeComponent();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            siparisler siparisler = new siparisler();
            siparisler.Show();
            this.Hide();
        }

        private void teslimEdilecekler_Load(object sender, EventArgs e)
        {
            yukle();
            toplam();

            toplamFiyatLabel.Text = toplamFiyat.ToString() + " ₺";
        }

        private void gonderButton_Click(object sender, EventArgs e)
        {
            kontrol();
        }

        void yukle()
        {
            odemeYontemiComboBox.Items.Add("Nakit");
            odemeYontemiComboBox.Items.Add("Kart");
            odemeYontemiComboBox.Items.Add("Havale");

            string komut= "SELECT * FROM haliBilgi WHERE siparisNo=" + siparisNo + "";

            connect.Open();
            
            OleDbDataAdapter da=new OleDbDataAdapter(komut,connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            haliDataGridView.DataSource = dt;

            connect.Close();

            if (haliDataGridView.Columns.Contains("Kimlik"))
            {
                haliDataGridView.Columns["Kimlik"].Visible = false;
            }
        }

        void toplam()
        {
            string komut = "SELECT SUM(haliFiyat) FROM haliBilgi WHERE siparisNo=" + siparisNo;

            connect.Open();

            OleDbCommand cmd = new OleDbCommand(komut, connect);
            object sonuc = cmd.ExecuteScalar();
            if (sonuc != DBNull.Value)
            {
                toplamFiyat = Convert.ToDouble(sonuc) - indirim;
            }
            else MessageBox.Show("Toplam fiyat hesaplanamadı.");

            connect.Close();
        }

        void kontrol()
        {
            if (!string.IsNullOrWhiteSpace(alinanTutarTextBox.Text) && !string.IsNullOrWhiteSpace(odemeYontemiComboBox.Text))
            {
                int alinanTutar = Convert.ToInt32(alinanTutarTextBox.Text);
                double veresiyeTutar = toplamFiyat - alinanTutar;

                if (alinanTutar > toplamFiyat)
                {
                    MessageBox.Show("Alınan tutar toplam fiyattan büyük olamaz!!");
                }
                else if (alinanTutar == toplamFiyat)
                {
                    string komutEkle = "INSERT INTO odemeler(siparisNo, odemeTarih, odenecekTutar, odenenTutar, odemeYontemi)" +
                        "               VALUES( " +
                        "               " + siparisNo + "," +
                        "               " + DateTime.Now.ToString("dd/MM/yyyy") + "," +
                        "               " + toplamFiyat + "," +
                        "               " + alinanTutar + "," +
                        "               '" + odemeYontemiComboBox.Text + "') ";

                    connect.Open();

                    OleDbCommand ekle = new OleDbCommand(komutEkle, connect);
                    ekle.ExecuteNonQuery();

                    connect.Close();

                    string komutGuncelle = "UPDATE siparisler SET " +
                        "        siparisDurum='Tamamlandi'" +
                        "        WHERE siparisNo=" + siparisNo;

                    connect.Open();

                    OleDbCommand guncelle = new OleDbCommand(komutGuncelle, connect);
                    guncelle.ExecuteNonQuery();

                    connect.Close();

                    siparisler siparisler = new siparisler();
                    siparisler.Show();
                    this.Hide();
                }
                else
                {
                    string komutEkle = "INSERT INTO odemeler(siparisNo, odemeTarih, odenecekTutar, odenenTutar, odemeYontemi)" +
                        "               VALUES( " +
                        "               " + siparisNo + "," +
                        "               " + DateTime.Now.ToString("dd/MM/yyyy") + "," +
                        "               " + toplamFiyat + "," +
                        "               " + alinanTutar + "," +
                        "               '" + odemeYontemiComboBox.Text + "') ";

                    connect.Open();

                    OleDbCommand ekle = new OleDbCommand(komutEkle, connect);
                    ekle.ExecuteNonQuery();

                    connect.Close();

                    string komutGuncelle = "UPDATE siparisler SET " +
                        "                   siparisDurum='Veresiye'," +
                        "                   veresiyeTutar=" + veresiyeTutar + "" +
                        "                   WHERE siparisNo=" + siparisNo;

                    connect.Open();

                    OleDbCommand guncelle = new OleDbCommand(komutGuncelle, connect);
                    guncelle.ExecuteNonQuery();

                    connect.Close();

                    siparisler siparisler = new siparisler();
                    siparisler.Show();
                    this.Hide();

                    veresiye veresiye = new veresiye();
                    veresiye.veresiyeTutar = veresiyeTutar;
                }
            }
            else
            {
                MessageBox.Show("Alınan Tutar veya Ödeme Yöntemi kısmı boş bırakılamaz!!!");
            } 
        }
    }
}
