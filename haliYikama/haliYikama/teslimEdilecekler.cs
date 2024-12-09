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
    public partial class teslimEdilecekler : Form
    {

        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public int SiparisNo { get; set; }

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

        void yukle()
        {
            odemeSekliComboBox.Items.Add("Nakit");
            odemeSekliComboBox.Items.Add("Kart");
            odemeSekliComboBox.Items.Add("Havale");
        }
    }
}
