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
    public partial class musteriDuzenle : Form
    {

        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public string AdSoyad
        {
            get { return adSoyadTextBox.Text; }
            set { adSoyadTextBox.Text = value; }
        }
        public string TelNo
        {
            get { return telNoTextBox.Text; }
            set { telNoTextBox.Text = value; }
        }
        public string Adres
        {
            get { return adresTextBox.Text; }
            set { adresTextBox.Text = value; }
        }

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

        private void duzenleButton_Click(object sender, EventArgs e)
        {
            musteriGuncelle();
        }

        void musteriGuncelle()
        {
            string komut="UPDATE musteriler SET adiSoyadi='"+adSoyadTextBox.Text+"',telNo='"+telNoTextBox.Text+"',adres='"+adresTextBox.Text+"' WHERE Kimlik=";
        }
    }
}
