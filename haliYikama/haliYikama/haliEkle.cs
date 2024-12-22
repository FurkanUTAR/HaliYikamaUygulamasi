using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace haliYikama
{
    public partial class haliEkle : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public int siparisNo { get; set; }

        public haliEkle()
        {
            InitializeComponent();
        }

        private void haliEkle_Load(object sender, EventArgs e)
        {
            yukle();
        }

        private void eklePictureBox_Click(object sender, EventArgs e)
        {
            siparisEkle();
            this.Close();
        }

        void yukle()
        {
            urunComboBox.Items.Add("Makine");
            urunComboBox.Items.Add("Akrilik");
            urunComboBox.Items.Add("Shaggy");
            urunComboBox.Items.Add("Plastik");
            urunComboBox.Items.Add("Bambu");
            urunComboBox.Items.Add("Yün");
            urunComboBox.Items.Add("İpek");
            urunComboBox.Items.Add("Stor Perde");
            urunComboBox.Items.Add("Overlok");
            urunComboBox.Items.Add("Yorgan(Tek)");
            urunComboBox.Items.Add("Yorgan(Çift)");

            for (int i = 1; i < 1000; i++)
            {
                adetComboBox.Items.Add(i);
            }
        }

        void siparisEkle()
        {
            if (!string.IsNullOrWhiteSpace(adetComboBox.Text) && (!string.IsNullOrWhiteSpace(metreKareTextBox.Text) || !metreKareTextBox.Enabled))
            {

                double metreKare = metreKareTextBox.Enabled ? Convert.ToDouble(metreKareTextBox.Text) : 1;
                double adet = Convert.ToDouble(adetComboBox.Text);
                double fiyat = 0;

                double makine = 0; double akrilik = 0; double shaggy = 0; double plastik = 0; double bambu = 0; double yun = 0;
                double ipek = 0; double storPerde = 0; double overlok = 0; double yorganTek = 0; double yorganCift = 0;

                string komut = "SELECT * FROM haliFiyat WHERE Kimlik=11";
                connect.Open();

                OleDbCommand command = new OleDbCommand(komut, connect);
                OleDbDataReader oku = command.ExecuteReader();

                if (oku.Read())
                {
                    makine = Convert.ToDouble(oku["makine"]);
                    akrilik = Convert.ToDouble(oku["akrilik"]);
                    shaggy = Convert.ToDouble(oku["shaggy"]);
                    plastik = Convert.ToDouble(oku["plastik"]);
                    bambu = Convert.ToDouble(oku["bambu"]);
                    yun = Convert.ToDouble(oku["yun"]);
                    ipek = Convert.ToDouble(oku["ipek"]);
                    storPerde = Convert.ToDouble(oku["storPerde"]);
                    overlok = Convert.ToDouble(oku["overlok"]);
                    yorganTek = Convert.ToDouble(oku["yorganTek"]);
                    yorganCift = Convert.ToDouble(oku["yorganCift"]);
                }

                switch (urunComboBox.Text)
                {
                    case "Makine": fiyat = makine * metreKare * adet; break;
                    case "Akrilik": fiyat = akrilik * metreKare * adet; break;
                    case "Shaggy": fiyat = shaggy * metreKare * adet; break;
                    case "Plastik": fiyat = plastik * metreKare * adet; break;
                    case "Bambu": fiyat = bambu * metreKare * adet; break;
                    case "Yün": fiyat = yun * metreKare * adet; break;
                    case "İpek": fiyat = ipek * metreKare * adet; break;
                    case "Stor Perde": fiyat = storPerde * metreKare * adet; break;
                    case "Overlok": fiyat = overlok * metreKare * adet; break;
                    case "Yorgan(Tek)": fiyat = yorganTek * adet; break;
                    case "Yorgan(Çift)": fiyat = yorganCift * metreKare * adet; break;
                    default: fiyat = makine * metreKare * adet; break;
                }

                connect.Close();

                if (string.IsNullOrWhiteSpace(urunComboBox.Text))
                {
                    string komutEkle = "INSERT INTO haliBilgi(siparisNo, haliCins, haliAdet, haliBoyut, haliFiyat) " +
                    "VALUES (" + siparisNo + ", '" + "Makine" + "', " + adet + ", " + (metreKare * adet) + ", " + fiyat + ")";
                    connect.Open();

                    OleDbCommand cmd = new OleDbCommand(komutEkle, connect);
                    cmd.ExecuteNonQuery();

                    connect.Close();
                }
                else
                {
                    string komutEkle = "INSERT INTO haliBilgi(siparisNo, haliCins, haliAdet, haliBoyut, haliFiyat) " +
                    "VALUES (" + siparisNo + ", '" + urunComboBox.Text + "', " + adet + ", " + (metreKare * adet) + ", " + fiyat + ")";
                    connect.Open();

                    OleDbCommand cmd = new OleDbCommand(komutEkle, connect);
                    cmd.ExecuteNonQuery();

                    connect.Close();
                }
            }
            else
            {
                if (metreKareTextBox.Enabled && string.IsNullOrWhiteSpace(metreKareTextBox.Text))
                {
                    MessageBox.Show("Lütfen 'm²' kısmını boş bırakmayınız!!!");
                }
                if (string.IsNullOrWhiteSpace(adetComboBox.Text))
                {
                    MessageBox.Show("Lütfen 'Adet' kısmını boş bırakmayınız!!!");
                }
            }
        }
    }
}
