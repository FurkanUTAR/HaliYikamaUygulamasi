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
    public partial class anaSayfa : Form
    {

        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public anaSayfa()
        {
            InitializeComponent();
        }

        private void fiyatButton_Click(object sender, EventArgs e)
        {
            fiyat fiyat = new fiyat();
            fiyat.Show();
            this.Hide();
        }

        private void mesajlarButton_Click(object sender, EventArgs e)
        {
            mesajlar mesajlar = new mesajlar();
            mesajlar.Show();
            this.Hide();
        }

        private void musterilerButton_Click(object sender, EventArgs e)
        {
            musteriler musteriler = new musteriler();
            musteriler.Show();
            this.Hide();
        }

        private void siparislerButton_Click(object sender, EventArgs e)
        {
            siparisler siparisler = new siparisler();
            siparisler.Show();
            this.Hide();
        }

        private void aramaGecmisiButton_Click(object sender, EventArgs e)
        {
            aramaGecmisi aramaGecmisi = new aramaGecmisi();
            aramaGecmisi.Show();
            this.Hide();
        }

        private void gelirGiderButton_Click(object sender, EventArgs e)
        {
            gelirGiderTakip gelirGiderTakip = new gelirGiderTakip();
            gelirGiderTakip.Show();
            this.Hide();
        }

        private void ozetlerButton_Click(object sender, EventArgs e)
        {
            ozetler ozetler = new ozetler();
            ozetler.Show();
            this.Hide();
        }

        private void anaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
