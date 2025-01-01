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

        double gunlukGelir;
        double gunlukGider;
        double gunlukKar;

        double aylikGelir;
        double aylikGider;
        double aylikKar;

        double yillikGelir;
        double yillikGider;
        double yillikKar;


        public ozetler()
        {
            InitializeComponent();
        }

        private void ozetler_Load(object sender, EventArgs e)
        {
            gunlukOzet();
            aylikOzet();
            yillikOzet();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        void gunlukOzet()
        {
            gunlukSiparisHesap();
            gunlukYeniMusteriHesap();
            gunlukGelirHesap();
            gunlukGiderHesap();
            gunlukKarHesap();

            void gunlukSiparisHesap()
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
            void gunlukYeniMusteriHesap()
            {
                string gunlukYeniMusteriKomut = "SELECT COUNT(*) FROM musteriler WHERE FORMAT(eklemeTarih, 'yyyy-MM-dd') = ?";

                connect.Open();
                OleDbCommand cmd = new OleDbCommand(gunlukYeniMusteriKomut, connect);
                cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy-MM-dd"));
                int gunlukYeniMusteri = (int)cmd.ExecuteScalar();
                connect.Close();

                gunlukYeniMusteriLabel.Text = gunlukYeniMusteri.ToString();
            }

            void gunlukGelirHesap()
            {
                string gunlukGelirKomut = "SELECT SUM(odenenTutar) FROM odemeler WHERE FORMAT(odemeTarih, 'yyyy-MM-dd') = ?";

                connect.Open();
                OleDbCommand cmd = new OleDbCommand(gunlukGelirKomut, connect);
                cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy-MM-dd"));

                object sonuc = cmd.ExecuteScalar();
                gunlukGelir = sonuc != DBNull.Value && sonuc != null ? Convert.ToDouble(sonuc) : 0;

                connect.Close();

                string gunlukGelirKomut2 = "SELECT SUM(miktar) FROM gelirGiderTakip WHERE tur='Gelir' AND FORMAT(tarih, 'yyyy-MM-dd') = ?";

                connect.Open();
                OleDbCommand cmd2 = new OleDbCommand(gunlukGelirKomut2, connect);
                cmd2.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy-MM-dd"));

                object sonuc2 = cmd2.ExecuteScalar();
                gunlukGelir += sonuc2 != DBNull.Value && sonuc2 != null ? Convert.ToDouble(sonuc2) : 0;

                connect.Close();

                gunlukGelirLabel.Text = gunlukGelir.ToString();
            }

            void gunlukGiderHesap()
            {
                string gunlukGiderKomut = "SELECT SUM(miktar) FROM gelirGiderTakip WHERE tur='Gider' AND FORMAT(tarih, 'yyyy-MM-dd') = ?";

                connect.Open();
                OleDbCommand cmd = new OleDbCommand(gunlukGiderKomut, connect);
                cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy-MM-dd"));

                object sonuc = cmd.ExecuteScalar();
                gunlukGider = sonuc != DBNull.Value && sonuc != null ? Convert.ToDouble(sonuc) : 0;

                connect.Close();

                gunlukGiderLabel.Text = gunlukGider.ToString();
            }

            void gunlukKarHesap()
            {
                gunlukKar = gunlukGelir - gunlukGider;
                gunlukKarLabel.Text = gunlukKar.ToString();
            }
        }

        void aylikOzet()
        {
            aylikSiparisHesap();
            aylikYeniMusteriHesap();
            aylikGelirHesap();
            aylikGiderHesap();
            aylikKarHesap();

            void aylikSiparisHesap()
            {
                string aylıkSiparisKomut = "SELECT COUNT(*) FROM siparisler WHERE FORMAT(siparisTarih, 'yyyy-MM') = ?";

                connect.Open();

                OleDbCommand cmd = new OleDbCommand(aylıkSiparisKomut, connect);
                cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy-MM"));
                int aylıkSiparisSayisi = (int)cmd.ExecuteScalar();

                connect.Close();

                aylikToplamSiprarisLabel.Text = aylıkSiparisSayisi.ToString();
            }

            void aylikYeniMusteriHesap()
            {
                string aylikYeniMusteriKomut = "SELECT COUNT(*) FROM musteriler WHERE FORMAT(eklemeTarih, 'yyyy-MM') = ?";

                connect.Open();

                OleDbCommand cmd = new OleDbCommand(aylikYeniMusteriKomut, connect);
                cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy-MM"));
                int aylikYeniMusteri = (int)cmd.ExecuteScalar();

                connect.Close();

                aylikYeniMusteriLabel.Text = aylikYeniMusteri.ToString();
            }

            void aylikGelirHesap()
            {
                string aylikGelirKomut = "SELECT SUM(odenenTutar) FROM odemeler WHERE FORMAT(odemeTarih, 'yyyy-MM') = ?";

                connect.Open();

                OleDbCommand cmd = new OleDbCommand(aylikGelirKomut, connect);
                cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy-MM"));
                object sonuc = cmd.ExecuteScalar();
                aylikGelir = sonuc != DBNull.Value && sonuc != null ? Convert.ToDouble(sonuc) : 0;

                connect.Close();

                string aylikGelirKomut2 = "SELECT SUM(miktar) FROM gelirGiderTakip WHERE tur='Gelir' AND FORMAT(tarih, 'yyyy-MM') = ?";

                connect.Open();

                OleDbCommand cmd2 = new OleDbCommand(aylikGelirKomut2, connect);
                cmd2.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy-MM"));
                object sonuc2 = cmd2.ExecuteScalar();
                aylikGelir += sonuc2 != DBNull.Value && sonuc2 != null ? Convert.ToDouble(sonuc2) : 0;

                connect.Close();

                aylikGelirLabel.Text = aylikGelir.ToString();
            }

            void aylikGiderHesap()
            {
                string aylikGiderKomut = "SELECT SUM(miktar) FROM gelirGiderTakip WHERE tur='Gider' AND FORMAT(tarih, 'yyyy-MM') = ?";

                connect.Open();

                OleDbCommand cmd = new OleDbCommand(aylikGiderKomut, connect);
                cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy-MM"));
                object sonuc = cmd.ExecuteScalar();
                aylikGider = sonuc != DBNull.Value && sonuc != null ? Convert.ToDouble(sonuc) : 0;

                connect.Close();

                aylikGiderLabel.Text = aylikGider.ToString();
            }

            void aylikKarHesap()
            {
                aylikKar = aylikGelir - aylikGider;
                aylikKarLabel.Text = aylikKar.ToString();
            }
        }

        void yillikOzet()
        {
            yillikSiparisHesap();
            yillikYeniMusteriHesap();
            yillikGelirHesap();
            yillikGiderHesap();
            yillikKarHesap();

            void yillikSiparisHesap()
            {
                string yıllıkSiparisKomut = "SELECT COUNT(*) FROM siparisler WHERE FORMAT(siparisTarih, 'yyyy') = ?";

                connect.Open();

                OleDbCommand cmd = new OleDbCommand(yıllıkSiparisKomut, connect);
                cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy"));
                int yıllıkSiparisSayisi = (int)cmd.ExecuteScalar();

                connect.Close();

                yillikToplamSiparisLabel.Text = yıllıkSiparisSayisi.ToString();
            }

            void yillikYeniMusteriHesap()
            {
                string yillikYeniMusteriKomut = "SELECT COUNT(*) FROM musteriler WHERE FORMAT(eklemeTarih, 'yyyy') = ?";

                connect.Open();

                OleDbCommand cmd = new OleDbCommand(yillikYeniMusteriKomut, connect);
                cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy"));
                int yillikYeniMusteri = (int)cmd.ExecuteScalar();

                connect.Close();

                yillikYeniMusteriLabel.Text = yillikYeniMusteri.ToString();
            }

            void yillikGelirHesap()
            {
                string yillikGelirKomut = "SELECT SUM(odenenTutar) FROM odemeler WHERE FORMAT(odemeTarih, 'yyyy') = ?";

                connect.Open();

                OleDbCommand cmd = new OleDbCommand(yillikGelirKomut, connect);
                cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy"));
                object sonuc = cmd.ExecuteScalar();
                yillikGelir = sonuc != DBNull.Value && sonuc != null ? Convert.ToDouble(sonuc) : 0;

                connect.Close();

                string yillikGelirKomut2 = "SELECT SUM(miktar) FROM gelirGiderTakip WHERE tur='Gelir' AND FORMAT(tarih, 'yyyy') = ?";

                connect.Open();

                OleDbCommand cmd2 = new OleDbCommand(yillikGelirKomut2, connect);
                cmd2.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy"));
                object sonuc2 = cmd2.ExecuteScalar();
                yillikGelir += sonuc2 != DBNull.Value && sonuc2 != null ? Convert.ToDouble(sonuc2) : 0;

                connect.Close();

                yillikGelirLabel.Text = yillikGelir.ToString();
            }

            void yillikGiderHesap()
            {
                string yillikGiderKomut = "SELECT SUM(miktar) FROM gelirGiderTakip WHERE tur='Gider' AND FORMAT(tarih, 'yyyy') = ?";

                connect.Open();

                OleDbCommand cmd = new OleDbCommand(yillikGiderKomut, connect);
                cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy"));
                object sonuc = cmd.ExecuteScalar();
                yillikGider = sonuc != DBNull.Value && sonuc != null ? Convert.ToDouble(sonuc) : 0;

                connect.Close();

                yillikGiderLabel.Text = yillikGider.ToString();
            }

            void yillikKarHesap()
            {
                yillikKar = yillikGelir - yillikGider;
                yillikKarLabel.Text = yillikKar.ToString();
            }
        }
    }
}
