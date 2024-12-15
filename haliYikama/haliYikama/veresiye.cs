using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace haliYikama
{
    public partial class veresiye : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public int siparisNo { get; set; }
        public double veresiyeTutar { get; set; }
        double veresiyeKalan = 0;

        public veresiye()
        {
            InitializeComponent();
        }

        private void veresiye_Load(object sender, EventArgs e)
        {
            yukle();
            veresiyeFiyatLabel.Text = veresiyeTutar.ToString() + " ₺";
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            siparisler siparisler = new siparisler();
            siparisler.Show();
            this.Hide();
        }

        void yukle()
        {
            odemeYontemiComboBox.Items.Add("Nakit");
            odemeYontemiComboBox.Items.Add("Kart");
            odemeYontemiComboBox.Items.Add("Havale");
        }

        private void gonderButton_Click(object sender, EventArgs e)
        {
            kontrol();
        }

        void kontrol()
        {
            if (!string.IsNullOrWhiteSpace(alinanTutarTextBox.Text) && !string.IsNullOrWhiteSpace(odemeYontemiComboBox.Text))
            {
                int alinanTutar = Convert.ToInt32(alinanTutarTextBox.Text);
                double veresiyeKalan = veresiyeTutar - alinanTutar;
                if (alinanTutar > veresiyeTutar)
                {
                    MessageBox.Show("Alınan tutar toplam fiyattan büyük olamaz!!");
                }
                else if (alinanTutar == veresiyeTutar)
                {
                    string komut = "UPDATE siparisler SET" +
                        "        siparisDurum='Tamamlandi'," +
                        "        veresiyeTutar=0" +
                        "        WHERE siparisNo=" + siparisNo;

                    connect.Open();

                    OleDbCommand cmd = new OleDbCommand(komut, connect);
                    cmd.ExecuteNonQuery();

                    connect.Close();

                    siparisler siparisler = new siparisler();
                    siparisler.Show();
                    this.Hide();
                }
                else
                {
                    string komut = "UPDATE siparisler SET" +
                        "           veresiyeTutar=" + veresiyeKalan + " " +
                        "           WHERE siparisNo=" + siparisNo;
                    connect.Open();

                    OleDbCommand cmd = new OleDbCommand(komut, connect);
                    cmd.ExecuteNonQuery();

                    connect.Close();


                    string odemeYontemiMevcut = "";
                    string komutGetOdemeYontemi = "SELECT odemeYontemi FROM odemeler WHERE siparisNo=" + siparisNo;

                    connect.Open();
                    OleDbCommand cmdGetOdemeYontemi = new OleDbCommand(komutGetOdemeYontemi, connect);
                    object sonuc = cmdGetOdemeYontemi.ExecuteScalar();
                    if (sonuc != DBNull.Value)
                    {
                        odemeYontemiMevcut = sonuc.ToString();
                    }
                    connect.Close();


                    string yeniOdemeYontemi = odemeYontemiMevcut + ", " + odemeYontemiComboBox.Text;

                    string komutOdemeler = "UPDATE odemeler SET" +
                        "           odenenTutar=" + veresiyeTutar + alinanTutar + "," +
                        "           odemeYontemi="+yeniOdemeYontemi+" " +
                        "           WHERE siparisNo=" + siparisNo;
                    connect.Open();

                    OleDbCommand cmdOdemeler = new OleDbCommand(komutOdemeler, connect);
                    cmdOdemeler.ExecuteNonQuery();

                    connect.Close();

                    siparisler siparisler = new siparisler();
                    siparisler.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Alınan Tutar veya Ödeme Yöntemi kısmı boş bırakılamaz!!!");
            }
        }
    }
}
