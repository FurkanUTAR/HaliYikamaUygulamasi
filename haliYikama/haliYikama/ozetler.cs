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
using System.Net;
using System.Collections;
using System.Reflection.Emit;

namespace haliYikama
{
    public partial class ozetler : Form
    {

        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public ozetler()
        {
            InitializeComponent();
        }
        
        private void ozetler_Load(object sender, EventArgs e)
        {
            gunlukSiparis();
            gunlukYeniMusteri();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        void gunlukSiparis()
        {
            //string gunlukSiparisKomut = "SELECT COUNT(*) FROM siparisler WHERE siparisTarih= " + DateTime.Now.ToString("yyyy-MM-dd");

            string gunlukSiparisKomut = "SELECT COUNT(*) FROM siparisler WHERE FORMAT(siparisTarih, 'yyyy-MM-dd') = ?";

            connect.Open();
            OleDbCommand cmd = new OleDbCommand(gunlukSiparisKomut, connect);
            cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy-MM-dd"));
            int gunlukSiparisSayisi = (int)cmd.ExecuteScalar();
            connect.Close();

            gunlukToplamSiparisLabel.Text = gunlukSiparisSayisi.ToString();
        }

        void gunlukYeniMusteri()
        {
            string gunlukYeniMusteriKomut = "SELECT COUNT(*) FROM musteriler WHERE FORMAT(eklemeTarih, 'yyyy-MM-dd') = ?";

            connect.Open();
            OleDbCommand cmd = new OleDbCommand(gunlukYeniMusteriKomut, connect);
            cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy-MM-dd"));
            int gunlukYeniMusteri = (int)cmd.ExecuteScalar();
            connect.Close();

            gunlukYeniMusteriLabel.Text = gunlukYeniMusteri.ToString();
        }
    }
}
