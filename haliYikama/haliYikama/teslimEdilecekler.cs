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
using System.IO;

namespace haliYikama
{
    public partial class teslimEdilecekler : Form
    {



        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");
        DateTime date= DateTime.Now;

        public double toplamFiyat {  get; set; }
        public int siparisNo { get; set; }
        

        public teslimEdilecekler()
        {
            InitializeComponent();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            siparisler siparisler = new siparisler();
            siparisler.Show();
            this.Hide();
        }

        private void teslimEdilecekler_Load(object sender, EventArgs e)
        {
            yukle();
        }

        private void gonderButton_Click(object sender, EventArgs e)
        {
            siparisTamamla();
        }

        void yukle()
        {
            odemeSekliComboBox.Items.Add("Nakit");
            odemeSekliComboBox.Items.Add("Kart");
            odemeSekliComboBox.Items.Add("Havale");

            string komut= "SELECT * FROM haliBilgi WHERE siparisNo=" + siparisNo + "";

            connect.Open();
            
            OleDbDataAdapter da=new OleDbDataAdapter(komut,connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            haliDataGridView.DataSource = dt;

            connect.Close();

            if (haliDataGridView.Columns.Contains("Kimlik"))
            {
                haliDataGridView.Columns["Kimlik"].Visible = false;
            }
        }

        void siparisTamamla()
        {
            if (!string.IsNullOrWhiteSpace(alinanTutarTextBox.Text) && !string.IsNullOrWhiteSpace(odemeSekliComboBox.Text))
            {
                double alinanTutar = double.Parse(alinanTutarTextBox.Text);

                if (alinanTutar >= toplamFiyat)
                {
                    double veresiye = alinanTutar - toplamFiyat;

                    string komut = "INSERT INTO odemeler (siparisNo,odemeTarih,odemeTutar,odemeYontemi) " +
                               "VALUES(" + siparisNo + ",'" + date.ToString("yyyy-MM-dd") + "'," + alinanTutar + ",'" + odemeSekliComboBox.Text + "') ";

                    connect.Open();

                    OleDbCommand cmd = new OleDbCommand(komut, connect);
                    cmd.ExecuteNonQuery();

                    connect.Close();

                }
                else MessageBox.Show("Alınan tutar toplam tutardan büyük olamaz!!!");

            }
            else MessageBox.Show("Lütfen alınacak tutar ve ödeme yöntemi giriniz!!!");
        }


    }
}
