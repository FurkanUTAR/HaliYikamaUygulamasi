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
        public string islem { get; set; }

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
            DialogResult result = MessageBox.Show("Düzenlemek istediğinizden emin misiniz?", "Sorgu", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes) guncelle();
        }

        void guncelle()
        {

            if (islem == "musteri")
            {
                if (!string.IsNullOrWhiteSpace(adSoyadTextBox.Text) && !string.IsNullOrWhiteSpace(telNoTextBox.Text) && !string.IsNullOrWhiteSpace(adresTextBox.Text))
                {
                    string komut = "UPDATE musteriler SET adiSoyadi='" + adSoyadTextBox.Text + "', telNo='" + telNoTextBox.Text + "', adres='" + adresTextBox.Text + "' WHERE Kimlik=" + kimlik;

                    connect.Open();

                    OleDbCommand cmd = new OleDbCommand(komut, connect);
                    cmd.ExecuteNonQuery();

                    connect.Close();
                    geriDon();
                }
                else
                {
                    MessageBox.Show("Boş alan bırakmayınız");
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(adSoyadTextBox.Text) && !string.IsNullOrWhiteSpace(telNoTextBox.Text) && !string.IsNullOrWhiteSpace(adresTextBox.Text))
                {
                    string komut = "UPDATE siparisler SET adiSoyadi='" + adSoyadTextBox.Text + "', telNo='" + telNoTextBox.Text + "', adres='" + adresTextBox.Text + "' WHERE siparisNo=" + kimlik;

                    connect.Open();

                    OleDbCommand cmd = new OleDbCommand(komut, connect);
                    cmd.ExecuteNonQuery();

                    connect.Close();
                    geriDon();
                }
                else
                {
                    MessageBox.Show("Boş alan bırakmayınız");
                }
            }

        }

        void geriDon()
        {
            siparisOlustur siparisOlustur = new siparisOlustur();
            siparisOlustur.adSoyad = adSoyad;
            siparisOlustur.telNo = telNo;
            siparisOlustur.adres = adres;
            siparisOlustur.Kimlik = kimlik;
            siparisOlustur.Show();
            this.Hide();
        }
    }
}
