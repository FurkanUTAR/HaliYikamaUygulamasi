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
    public partial class siparisDetay : Form
    {

        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public int siparisNo {  get; set; }

        public siparisDetay()
        {
            InitializeComponent();
        }

        private void siparisDetay_Load(object sender, EventArgs e)
        {
            goster();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            islemdekiler islemdekiler = new islemdekiler();
            islemdekiler.Show();
            this.Hide();
        }

        private void teslimatCekButton_Click(object sender, EventArgs e)
        {
            teslimatCek();
        }

        void goster()
        {
            string komut = "SELECT haliCins,haliAdet,haliBoyut,haliFiyat FROM haliBilgi WHERE siparisNo= " + siparisNo;

            connect.Open();

            OleDbDataAdapter da= new OleDbDataAdapter(komut,connect);
            DataTable dt= new DataTable();
            da.Fill(dt);
            haliBilgiDataGridView.DataSource = dt;

            connect.Close();
        }

        void teslimatCek()
        {
                string komut = "UPDATE siparisler SET siparisDurum='Teslimat', siparisNotu='"+teslimatNotuTextBox.Text+"' WHERE siparisNo=" + siparisNo;

                OleDbCommand cmd = new OleDbCommand(komut, connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
        }   
    }
}
