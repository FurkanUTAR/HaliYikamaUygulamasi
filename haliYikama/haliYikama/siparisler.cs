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
using System.Security.Cryptography.X509Certificates;

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
            if (alinacakDataGridView.CurrentRow != null) // Seçili satır var mı?
            {
                var cellValue = alinacakDataGridView.CurrentRow.Cells[0].Value; // Hücre değeri alınır

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int siparisNo)) // Geçerli bir sayı mı?
                {
                    alinacaklar alinacaklar = new alinacaklar();
                    alinacaklar.SiparisNo = siparisNo;

                    alinacaklar.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Seçilen kaydın Sipariş Numarası geçerli bir sayı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir kayıt seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



            /*
            if (alinacakDataGridView.CurrentRow != null)
            {
                int siparisNo = int.Parse(alinacakDataGridView.CurrentRow.Cells[0].Value.ToString());

                alinacaklar alinacaklar = new alinacaklar();
                alinacaklar.SiparisNo = siparisNo;

                alinacaklar.Show();
                this.Hide();
            }
            else MessageBox.Show("Lütfen geçerli bir kayıt seçin.");
            */
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
            hepsiGoster();

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

            void hepsiGoster()
            {
                string komut = "SELECT * FROM siparisler WHERE siparisDurum = 'Alınacak' OR siparisDurum = 'Teslimat' OR siparisDurum = 'Veresiye'";

                connect.Open();

                OleDbDataAdapter da = new OleDbDataAdapter(komut, connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                hepsiDataGridView.DataSource = dt;

                connect.Close();
            }
        }
    }
}
