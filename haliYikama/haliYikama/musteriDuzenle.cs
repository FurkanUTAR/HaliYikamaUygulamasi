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
    public partial class musteriDuzenle : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public string AdSoyad { get;set; }
        public string TelNo
        {
            get { return telNoTextBox.Text; }
            set { telNoTextBox.Text = value; }
        }
        public string TelNo2
        {
            get { return telNoIkiTextBox.Text; }
            set { telNoIkiTextBox.Text = value; }
        }
        public string Adres
        {
            get { return adresTextBox.Text; }
            set { adresTextBox.Text = value; }
        }
        public int Kimlik {  get; set; }

        public musteriDuzenle()
        {
            InitializeComponent();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            siparisOlustur siparisOlustur = new siparisOlustur();
            siparisOlustur.Show();
            this.Hide();
        }

        void guncelle()
        {
            string komut = "UPDATE musteriler SET adiSoyAdi='" + adSoyadTextBox.Text + "', telNo='" + telNoTextBox.Text + "', telNo2='" + telNoIkiTextBox.Text + "', adres='" + adresTextBox.Text + "' WHERE Kimlik="+Kimlik+" ";

        }

        private void musteriDuzenle_Load(object sender, EventArgs e)
        {
            adSoyadTextBox.Text = AdSoyad;
        }
    }
}
