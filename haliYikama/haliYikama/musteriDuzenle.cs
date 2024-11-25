using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace haliYikama
{
    public partial class musteriDuzenle : Form
    {
        public musteriDuzenle()
        {
            InitializeComponent();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            siparisOlustur siparisOlustur = new siparisOlustur();
            siparisOlustur.Show();
            this.Hide();
        }
    }
}
