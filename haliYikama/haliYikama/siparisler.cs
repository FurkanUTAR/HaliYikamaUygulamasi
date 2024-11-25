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
using System.Reflection;

namespace haliYikama
{
    public partial class siparisler : Form
    {

        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public siparisler()
        {
            InitializeComponent();
        }

        private void siparisler_Load(object sender, EventArgs e)
        {
            goster();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void alinacakDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            alinacaklar alinacaklar = new alinacaklar();
            alinacaklar.Show();
            this.Hide();
        }

        private void teslimatDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            teslimEdilecekler teslimEdilecekler = new teslimEdilecekler();
            teslimEdilecekler.Show();
            this.Hide();
        }

        private void veresiyeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            veresiye veresiye = new veresiye();
            veresiye.Show();
            this.Hide();
        }

        private void hepsiDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            hepsi hepsi = new hepsi();
            hepsi.Show();
            this.Hide();
        }

        void goster()
        {
            alinacakGoster();
            teslimatGoster();
            veresiyeGoster();
            hespiGoster();

            void alinacakGoster()
            {
                string komut = "SELECT * FROM siparisler WHERE siparisDurum = 'Alınacak'";

                connect.Open();

                OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                alinacakDataGridView.DataSource = dt;

                connect.Close();
            }

            void teslimatGoster()
            {
                string komut = "SELECT * FROM siparisler WHERE siparisDurum = 'Teslimat'";

                connect.Open();

                OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                teslimatDataGridView.DataSource = dt;

                connect.Close();
            }

            void veresiyeGoster()
            {
                string komut = "SELECT * FROM siparisler WHERE siparisDurum = 'Veresiye'";

                connect.Open();

                OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                veresiyeDataGridView.DataSource = dt;

                connect.Close();
            }

            void hespiGoster()
            {
                string komut = "SELECT * FROM siparisler WHERE siparisDurum = 'Alınacak' OR 'Teslimat' OR 'Veresiye'";

                connect.Open();

                OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                hepsiDataGridView.DataSource = dt;

                connect.Close();
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
