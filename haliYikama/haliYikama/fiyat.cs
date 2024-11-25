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
using System.Data.Common;

namespace haliYikama
{
    public partial class fiyat : Form
    {

        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");


        public fiyat()
        {
            InitializeComponent();
        }

        private void fiyat_Load(object sender, EventArgs e)
        {
            fiyatGoster();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            fiyatKaydet();
        }

        
        void fiyatGoster()
        {
            string komut ="SELECT * FROM haliFiyat WHERE Kimlik=11";

            connect.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(komut,connect);
            DataTable dt=new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count>0)
            {
                DataRow row = dt.Rows[0];
                makineFiyatTextBox.Text = row["makine"].ToString();
                akrilikFiyatTextBox.Text = row["akrilik"].ToString();
                shaggyFiyatTextBox.Text = row["shaggy"].ToString();
                plastikFiyatTextBox.Text = row["plastik"].ToString();
                bambuFiyatTextBox.Text = row["bambu"].ToString();
                yunFiyatTextBox.Text = row["yun"].ToString();
                ipekFiyatTextBox.Text = row["ipek"].ToString();
                storPerdeTextBox.Text = row["storPerde"].ToString();
                overlokFiyatTextBox.Text = row["overlok"].ToString();
                yorganTekFiyatTextBox.Text = row["yorganTek"].ToString();
                yorganCiftFiyatTextBox.Text = row["yorganCift"].ToString();
            }

            connect.Close();
        }
        

        void fiyatKaydet()
        {
            string komut =   "UPDATE haliFiyat SET " +
                             "makine=" + makineFiyatTextBox.Text + ", " +
                             "akrilik=" + akrilikFiyatTextBox.Text + ", " +
                             "shaggy=" + shaggyFiyatTextBox.Text + ", " +
                             "plastik=" + plastikFiyatTextBox.Text + ", " +
                             "bambu=" + bambuFiyatTextBox.Text + ", " +
                             "yun=" + yunFiyatTextBox.Text + ", " +
                             "ipek=" + ipekFiyatTextBox.Text + ", " +
                             "storPerde=" + storPerdeTextBox.Text + ", " +
                             "overlok=" + overlokFiyatTextBox.Text + ", " +
                             "yorganTek=" + yorganTekFiyatTextBox.Text + ", " +
                             "yorganCift=" + yorganCiftFiyatTextBox.Text + " " +
                             "WHERE Kimlik=11";
            connect.Open(); 

            OleDbCommand kaydet=new OleDbCommand(komut,connect);
            kaydet.ExecuteNonQuery();

            connect.Close();
        }
    }
}
