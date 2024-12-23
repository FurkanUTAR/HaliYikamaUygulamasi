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
    public partial class gelirGiderTakip : Form
    {

        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public gelirGiderTakip()
        {
            InitializeComponent();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void gelirGiderEkleButton_Click(object sender, EventArgs e)
        {
            gelirGiderEkle gelirGiderEkle = new gelirGiderEkle();
            gelirGiderEkle.Show();
            this.Hide();
        }

        private void gelirGiderTablosuButton_Click(object sender, EventArgs e)
        {
            gelirGiderTablo gelirGiderTablo = new gelirGiderTablo();
            gelirGiderTablo.Show();
            this.Hide();
        }
    }
}
