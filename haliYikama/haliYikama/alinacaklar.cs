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
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace haliYikama
{
    public partial class alinacaklar : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public int siparisNo { get; set; }
        double indirimMiktari = 0;

        public alinacaklar()
        {
            InitializeComponent();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            siparisler siparisler = new siparisler();
            siparisler.Show();
            this.Hide();
        }

        private void alinacaklar_Load(object sender, EventArgs e)
        {
            yukle();
            goster();
            adet();
            toplam();
        }

        private void urunComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            kontrol();
        }

        private void eklePictureBox_Click(object sender, EventArgs e)
        {
            siparisEkle();
            toplam();
            adet();
        }

        private void cıkarButton_Click(object sender, EventArgs e)
        {
            haliCikar();
            goster();
            toplam();
            adet();
        }

        private void indirimEklePictureBox_Click(object sender, EventArgs e)
        {
            indirimEkle();
            toplam();
            goster();
        }

        private void gonderButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Siparişi tamamlamak istediğinden emin misin?", "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                siparisAl();
                siparisler siparisler = new siparisler();
                siparisler.Show();
                this.Hide();
            }
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

            for (int i = 1; i < 1000; i++) adetComboBox.Items.Add(i);
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
                    goster();
                }
                else
                {
                    string komutEkle = "INSERT INTO haliBilgi(siparisNo, haliCins, haliAdet, haliBoyut, haliFiyat) " +
                    "VALUES (" + siparisNo + ", '" + urunComboBox.Text + "', " + adet + ", " + (metreKare * adet) + ", " + fiyat + ")";

                    connect.Open();

                    OleDbCommand cmd = new OleDbCommand(komutEkle, connect);
                    cmd.ExecuteNonQuery();

                    connect.Close();
                    goster();
                }
            }
            else
            {
                if (metreKareTextBox.Enabled && string.IsNullOrWhiteSpace(metreKareTextBox.Text)) MessageBox.Show("Lütfen 'm²' kısmını boş bırakmayınız!!!");

                if (string.IsNullOrWhiteSpace(adetComboBox.Text)) MessageBox.Show("Lütfen 'Adet' kısmını boş bırakmayınız!!!");
            }
        }

        void kontrol()
        {
            if (urunComboBox.Text == "Yorgan(Tek)" || urunComboBox.Text == "Yorgan(Çift)") { metreKareTextBox.Enabled = false; metreKareTextBox.Text = ""; }
            else metreKareTextBox.Enabled = true;
        }

        void goster()
        {
            string komut = "SELECT * FROM haliBilgi WHERE siparisNo=" + siparisNo + "";

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            alinacakHaliDataGridView.DataSource = dt;
            alinacakHaliDataGridView.Columns["Kimlik"].Visible = false;
            alinacakHaliDataGridView.Columns["siparisNo"].Visible = false;

            connect.Close();
        }

        void haliCikar()
        {
            if (alinacakHaliDataGridView.CurrentRow != null)
            {
                int kimlik = int.Parse(alinacakHaliDataGridView.CurrentRow.Cells[0].Value.ToString());
                string komut = "DELETE FROM haliBilgi WHERE Kimlik=" + kimlik;

                connect.Open();

                OleDbCommand cmd = new OleDbCommand(komut, connect);
                cmd.ExecuteNonQuery();

                connect.Close();
            }
            else MessageBox.Show("Lütfen silmek için geçerli bir kayıt seçin.");
        }

        void toplam()
        {
            string komut = "SELECT haliFiyat FROM haliBilgi WHERE siparisNo=" + siparisNo;
            double fiyat = 0;
            double toplamFiyat = 0;

            connect.Open();

            OleDbCommand cmd = new OleDbCommand(komut, connect);
            OleDbDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                if (double.TryParse(oku["haliFiyat"].ToString(), out double haliFiyat)) fiyat += haliFiyat;
                else MessageBox.Show("Geçersiz haliFiyat değeri: " + oku["haliFiyat"].ToString());
            }
            connect.Close();

            if (fiyat == 0) { toplamFiyat = 0; indirimMiktari = 0; }
            else toplamFiyat = fiyat - indirimMiktari;

            toplamFiyatLabel.Text = toplamFiyat.ToString() + " ₺";
        }

        void adet()
        {
            string komut = "SELECT haliAdet FROM haliBilgi WHERE siparisNo=" + siparisNo;
            double adet = 0;

            connect.Open();

            OleDbCommand cmd = new OleDbCommand(komut, connect);
            OleDbDataReader oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                if (double.TryParse(oku["haliAdet"].ToString(), out double haliAdet)) adet += haliAdet;
                else MessageBox.Show("Geçersiz haliAdet değeri: " + oku["haliAdet"].ToString());
            }

            connect.Close();

            adetLabel.Text = adet.ToString() + " Adet";
        }

        void indirimEkle()
        {
            indirimMiktari = double.Parse(indirimTextBox.Text);
        }

        void siparisAl()
        {
            if (double.TryParse(toplamFiyatLabel.Text.Replace(" ₺", ""), out double toplamFiyat))
            {
                string komut = "UPDATE siparisler SET " +
               "                siparisDurum='Islemde', " +
               "                siparisTutar=" + toplamFiyat.ToString().Replace(",", ".") + ", " +
               "                teslimTarih='" + teslimTarihiDateTimePicker.Value.ToString("yyyy-MM-dd") + "', " +
               "                indirimMiktar=" + indirimMiktari + ", " +
               "                haliAdet='" + adetLabel.Text + "' " +
               "                WHERE siparisNo=" + siparisNo;

                connect.Open();

                OleDbCommand cmd = new OleDbCommand(komut, connect);
                cmd.ExecuteNonQuery();

                connect.Close();
            }
            else MessageBox.Show("Toplam fiyat değeri geçerli bir sayı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
