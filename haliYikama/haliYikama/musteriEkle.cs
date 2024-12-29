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
    public partial class musteriEkle : Form
    {

        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");


        public musteriEkle()
        {
            InitializeComponent();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            musteriler musteriler = new musteriler();
            musteriler.Show();
            this.Hide();
        }

        private void musteriEkleButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(adSoyadTextBox.Text) && !string.IsNullOrWhiteSpace(telNoTextBox.Text) && !string.IsNullOrWhiteSpace(adresTextBox.Text))
            {
                musteriEklee();
            }
            else
            {
                MessageBox.Show("Boş yer bırakmayınız");
            }
        }

        void musteriEklee()
        {
            string komut = "INSERT INTO musteriler (adiSoyadi, telNo, adres, eklemeTarih) VALUES ('"
              + adSoyadTextBox.Text + "', '"
              + telNoTextBox.Text + "', '"
              + adresTextBox.Text + "', '"
              + DateTime.Now.ToString("yyyy-MM-dd") + "')";


            connect.Open();

            OleDbCommand ekle = new OleDbCommand(komut, connect);
            ekle.ExecuteNonQuery();

            connect.Close();

            musteriler musteriler = new musteriler();
            musteriler.Show();
            this.Hide();
        }
    }
}
