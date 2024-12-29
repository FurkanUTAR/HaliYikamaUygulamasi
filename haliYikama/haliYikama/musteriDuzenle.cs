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

namespace haliYikama
{
    public partial class musteriDuzenle : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public string adSoyad { get; set; }
        public string telNo { get; set; }
        public string adres { get; set; }
        public int kimlik { get; set; }


        public musteriDuzenle()
        {
            InitializeComponent();
        }

        private void musteriDuzenle_Load(object sender, EventArgs e)
        {
            adSoyadTextBox.Text = adSoyad;
            telNoTextBox.Text = telNo;
            adresTextBox.Text = adres;
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            geriDon();
        }

        private void duzenleButton_Click(object sender, EventArgs e)
        {
            guncelle();
            geriDon();
        }

        void guncelle()
        {
            string komut = "UPDATE musteriler SET adiSoyadi='" + adSoyadTextBox.Text + "', telNo='" + telNoTextBox.Text + "', adres='" + adresTextBox.Text + "' WHERE Kimlik=" + kimlik;

            connect.Open();

            OleDbCommand cmd=new OleDbCommand(komut,connect);
            cmd.ExecuteNonQuery();

            connect.Close();
        }

        void geriDon()
        {
            siparisOlustur siparisOlustur = new siparisOlustur();
            siparisOlustur.AdSoyad = adSoyad;
            siparisOlustur.TelNo = telNo;
            siparisOlustur.Adres = adres;
            siparisOlustur.Kimlik = kimlik;
            siparisOlustur.Show();
            this.Hide();
        }
    }
}
