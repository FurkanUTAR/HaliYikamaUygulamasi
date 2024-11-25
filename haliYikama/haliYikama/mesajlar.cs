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
    public partial class mesajlar : Form
    {

        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public mesajlar()
        {
            InitializeComponent();
        }

        private void mesajlar_Load(object sender, EventArgs e)
        {
            mesajlariGoster();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            kaydet();
        }

        void kaydet()
        {
            string komut =  "UPDATE mesajlar SET " +
                            "teslimAlindi='" + teslimAlindiTextBox.Text + "'," +
                            "teslimEdildi='" + teslimEdildiTextBox.Text + "'," +
                            "teslimataCikti='" + teslimataCiktiTextBox.Text + "'," +
                            "teslimEdilecek='" + teslimEdilecekTextBox.Text + "'," +
                            "teslimatGecikti='" + teslimatGeciktiTextBox.Text + "'" +
                            "WHERE Kimlik=1";

            connect.Open();

            OleDbCommand kaydet = new OleDbCommand(komut,connect);
            kaydet.ExecuteNonQuery();

            connect.Close();
        }

        void mesajlariGoster()
        {
            string komut = "SELECT * FROM mesajlar WHERE Kimlik=1";

            connect.Open();

            OleDbDataAdapter da=new OleDbDataAdapter(komut,connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count>0)
            {
                DataRow row =dt.Rows[0];
                teslimAlindiTextBox.Text = row["teslimAlindi"].ToString();
                teslimEdildiTextBox.Text = row["teslimEdildi"].ToString();
                teslimEdilecekTextBox.Text = row["teslimEdilecek"].ToString();
                teslimataCiktiTextBox.Text = row["teslimataCikti"].ToString();
                teslimatGeciktiTextBox.Text = row["teslimatGecikti"].ToString();
            }

            connect.Close();
        }
    }
}
