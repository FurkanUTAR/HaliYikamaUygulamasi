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

        public string AdSoyad
        {
            get { return adSoyadLabel.Text; } 
            set { adSoyadLabel.Text = value; } 
        }
        public string TelNo 
        { 
            get { return telNoLabel.Text; } 
            set { telNoLabel.Text = value; } 
        }
        public string Adres
        { 
            get { return adresLabel.Text; }
            set { adresLabel.Text = value; }
        }
        public string Kimlik { get; set; }

        public siparisOlustur()
        {
            InitializeComponent();
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
            musteriDuzenle.Show();
            this.Hide();
        }

        private void siparisOlusturButton_Click(object sender, EventArgs e)
        {
            databaseSiparisOlustur();
        }

        void databaseSiparisOlustur()
        {
            string adiSoyadi = adSoyadLabel.Text; 
            string telNo = telNoLabel.Text; 
            string adres = adresLabel.Text; 
            string siparisTarihi = siparisTarihiDateTimePicker.Value.ToString("yyyy-MM-dd");
            string siparisNotu = siparisNotuTextBox.Text; 
            string siparisDurum = "Alınacak";
            
            string komut = $"INSERT INTO siparisler (adiSoyadi, telNo, adres, siparisTarihi, siparisNotu, siparisDurum) " 
                         + $"VALUES ('{adiSoyadi}', '{telNo}', '{adres}', '{siparisTarihi}', '{siparisNotu}', '{siparisDurum}')";
            connect.Open();

            OleDbCommand siparisOlustur=new OleDbCommand(komut,connect);
            siparisOlustur.ExecuteNonQuery();

            connect.Close();
        }
    
        void musteriSil()
        {
            string komut = "DELETE FROM musteriler WHERE Kimlik=" + Kimlik + "";

            connect.Open();

            OleDbCommand sil=new OleDbCommand(komut,connect);
            sil.ExecuteNonQuery();

            connect.Close();
        }

        private void musteriSilButton_Click(object sender, EventArgs e)
        {
            musteriSil();

            musteriler musteriler = new musteriler();
            musteriler.Show();
            this.Hide();
        }


    }
}
