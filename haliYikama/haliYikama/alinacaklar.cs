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
    public partial class alinacaklar : Form
    {

        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

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
        }

        private void urunComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            kontrol();
        }

        private void eklePictureBox_Click(object sender, EventArgs e)
        {
            siparisEkle();
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

            for (int i = 0; i < 1000; i++)
            {
                adetComboBox.Items.Add(i);
            }
        }

        void siparisEkle()
        {

            double metreKare = Convert.ToDouble(metreKareTextBox.Text);
            double adet = Convert.ToDouble(adetComboBox.Text);
            double fiyat = 0;

            double makine = 0; double akrilik = 0; double shaggy = 0; double plastik = 0; double bambu = 0; double yun = 0;
            double ipek = 0; double storPerde = 0; double overlok = 0; double yorganTek = 0; double yorganCift = 0;

            string komut = "SELECT * FROM haliFiyat WHERE Kimlik=11";

            connect.Open();
            
            OleDbCommand command= new OleDbCommand(komut,connect);
            OleDbDataReader oku=command.ExecuteReader();

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
            else
            {

            }

            if (urunComboBox.Text=="Makine") fiyat = makine * metreKare * adet;
            else if(urunComboBox.Text=="Akrilik") fiyat = akrilik * metreKare * adet;
            else if(urunComboBox.Text=="Shaggy") fiyat = shaggy * metreKare * adet;
            else if(urunComboBox.Text=="Plastik") fiyat = plastik * metreKare * adet;
            else if(urunComboBox.Text=="Bambu") fiyat = bambu * metreKare * adet;
            else if(urunComboBox.Text=="Yün") fiyat = yun * metreKare * adet;
            else if(urunComboBox.Text=="İpek") fiyat = ipek * metreKare * adet;
            else if(urunComboBox.Text=="Stor Perde") fiyat = storPerde * metreKare * adet;
            else if(urunComboBox.Text=="Overlok") fiyat = overlok * metreKare * adet;
            else if(urunComboBox.Text=="Yorgan(Tek)") fiyat = yorganTek * adet;
            else if(urunComboBox.Text=="Yorgan(Çift)") fiyat = yorganCift * metreKare * adet;
            else
            {

            }

            connect.Close();

            
        }

        void kontrol()
        {
            if (urunComboBox.Text == "Yorgan(Tek)" || urunComboBox.Text == "Yorgan(Çift)") { metreKareTextBox.Enabled = false; }
            else { metreKareTextBox.Enabled = true; }
        }

        
    }
}
