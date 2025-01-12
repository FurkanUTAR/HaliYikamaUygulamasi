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
            this.Hide();
        }

        private void gelirGiderEkleButton_Click(object sender, EventArgs e)
        {
            gelirGiderEkle gelirGiderEkle = new gelirGiderEkle();
            gelirGiderEkle.ShowDialog();
        }

        private void gelirGiderTablosuButton_Click(object sender, EventArgs e)
        {
            gelirGiderTablo gelirGiderTablo = new gelirGiderTablo();
            gelirGiderTablo.ShowDialog();
        }

        private void gelirGiderEkleButton_MouseEnter(object sender, EventArgs e)
        {
            gelirGiderEkleButton.BackColor = Color.FromArgb(160, 190, 210);
        }

        private void gelirGiderTablosuButton_MouseEnter(object sender, EventArgs e)
        {
            gelirGiderTablosuButton.BackColor = Color.FromArgb(160, 190, 210);
        }

        private void gelirGiderEkleButton_MouseLeave(object sender, EventArgs e)
        {
            gelirGiderEkleButton.BackColor = Color.FromArgb(200, 220, 240);
        }

        private void gelirGiderTablosuButton_MouseLeave(object sender, EventArgs e)
        {
            gelirGiderTablosuButton.BackColor = Color.FromArgb(200, 220, 240);
        }
    }
}
