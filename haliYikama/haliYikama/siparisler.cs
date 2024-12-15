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
using System.Security.Policy;

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
            alinacakKontrol();
        }

        private void teslimatDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            teslimatKontrol();    
        }

        private void veresiyeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            veresiyeKontrol();
        }

        private void hepsiDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            hepsiKontrol();
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

                if (alinacakDataGridView.Columns.Contains("siparisDurum"))
                {
                    alinacakDataGridView.Columns["siparisDurum"].Visible = false;
                }
                if (alinacakDataGridView.Columns.Contains("teslimTarihi"))
                {
                    alinacakDataGridView.Columns["teslimTarihi"].Visible = false;
                }
                if (alinacakDataGridView.Columns.Contains("siparisTutari"))
                {
                    alinacakDataGridView.Columns["siparisTutari"].Visible = false;
                }
                if (alinacakDataGridView.Columns.Contains("indirimMiktari"))
                {
                    alinacakDataGridView.Columns["indirimMiktari"].Visible = false;
                }
                if (alinacakDataGridView.Columns.Contains("haliAdet"))
                {
                    alinacakDataGridView.Columns["haliAdet"].Visible = false;
                }
                if (alinacakDataGridView.Columns.Contains("veresiyeTutar"))
                {
                    alinacakDataGridView.Columns["veresiyeTutar"].Visible = false;
                }
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

                if (teslimatDataGridView.Columns.Contains("siparisDurum"))
                {
                    teslimatDataGridView.Columns["siparisDurum"].Visible = false;
                }
                if (teslimatDataGridView.Columns.Contains("siparisTarihi"))
                {
                    teslimatDataGridView.Columns["siparisTarihi"].Visible = false;
                }
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

        void alinacakKontrol()
        {
            if (alinacakDataGridView.CurrentRow != null) // Seçili satır var mı?
            {
                var cellValue = alinacakDataGridView.CurrentRow.Cells[0].Value; // Hücre değeri alınır

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int siparisNo)) // Geçerli bir sayı mı?
                {
                    alinacaklar alinacaklar = new alinacaklar();
                    alinacaklar.siparisNo = siparisNo;
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
        }

        void teslimatKontrol()
        {
            if (teslimatDataGridView.CurrentRow != null) // Seçili satır var mı?
            {
                var cellValue = teslimatDataGridView.CurrentRow.Cells[0].Value; // Hücre değeri alınır

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int siparisNo)) // Geçerli bir sayı mı?
                {
                    teslimEdilecekler teslimEdilecekler = new teslimEdilecekler();
                    teslimEdilecekler.siparisNo = siparisNo;
                    teslimEdilecekler.Show();
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
        }

        void veresiyeKontrol()
        {

            if (veresiyeDataGridView.CurrentRow != null) // Seçili satır var mı?
            {
                var cellValue = veresiyeDataGridView.CurrentRow.Cells[0].Value; // Hücre değeri alınır

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int siparisNo)) // Geçerli bir sayı mı?
                {
                    veresiye veresiye = new veresiye();
                    veresiye.siparisNo = siparisNo;
                    veresiye.Show();
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
        }
       


        // Çalışmıyor 
        void hepsiKontrol()
        {
            string status = hepsiDataGridView.CurrentRow.Cells[6].ToString();

            if (hepsiDataGridView.CurrentRow != null) // Seçili satır var mı?
            {
                var cellValue = hepsiDataGridView.CurrentRow.Cells[0].Value; // Hücre değeri alınır

                if (cellValue != null && int.TryParse(cellValue.ToString(), out int siparisNo)) // Geçerli bir sayı mı?
                {
                    if (status == "Alinacak")
                    {
                        alinacaklar alinacaklar = new alinacaklar();
                        alinacaklar.siparisNo = siparisNo;
                        alinacaklar.Show();
                        this.Hide();
                    }
                    else if (status == "Teslimat")
                    {
                        teslimEdilecekler teslimEdilecekler = new teslimEdilecekler();
                        teslimEdilecekler.siparisNo = siparisNo;
                        teslimEdilecekler.Show();
                        this.Hide();
                    }
                    else if(status == "Veresiye")
                    {
                        veresiye veresiye = new veresiye();
                        veresiye.siparisNo = siparisNo;
                        veresiye.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("2");
                    }
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
        }
    }
}
