using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace haliYikama
{
    public partial class gelirGiderEkle : Form
    {

        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public gelirGiderEkle()
        {
            InitializeComponent();
        }

        private void gelirGiderEkle_Load(object sender, EventArgs e)
        {
            yukle();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            gelirGiderTakip gelirGiderTakip = new gelirGiderTakip();
            gelirGiderTakip.Show();
            this.Hide();
        }

        private void turComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            kategoriComboBox.Items.Clear();

            if (turComboBox.Text == "Gider")
            {
                string[] giderKategorileri = { "Çalışan Maaşı", "Sigorta ve Vergiler", "Kira", "Elektrik, Su ve Doğalgaz Faturası", "İnternet ve Telefon", "Ofis Malzemeleri", "Ham Madde Alımı", "Temizlik Malzemesi", "Sarf Malzemeleri", "Araç Yakıt", "Araç Bakım ve Sigorta", "Reklam Harcamaları", "Gelir Vergisi", "KDV", "Hukuki Danışmanlık Ücretleri", "Cihaz Tamiri", "Ekipman Bakımı", "Hosting ve Alan Adı", "Donanım Alımı", "Diğer" };
                kategoriComboBox.Items.AddRange(giderKategorileri);
            }
            else if (turComboBox.Text == "Gelir")
            {
                string[] gelirKategorileri = { "Ürün Satışı", "Hizmet Satışı", "Yatırım Geliri", "Banka Faizi Geliri", "Hisse Senedi Geliri", "Diğer" };
                kategoriComboBox.Items.AddRange(gelirKategorileri);
            }

            if (kategoriComboBox.Items.Count > 0) kategoriComboBox.SelectedIndex = 0;
        }

        private void miktarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            gelirGiderEkleme();
        }

        void yukle()
        {
            turComboBox.Items.Add("Gelir");
            turComboBox.Items.Add("Gider");
        }

        void gelirGiderEkleme()
        {

            string tarih = tarihDateTimePicker.Value.ToString("yyyy-MM-dd");
            string tur = turComboBox.Text;
            string kategori = kategoriComboBox.Text;
            int miktar = int.Parse(miktarTextBox.Text);
            string aciklama = aciklamaTextBox.Text;

            string komut = $"INSERT INTO gelirGiderTakip (tarih, tur, kategori, miktar, aciklama)" +
                           $"VALUES ('{tarih}', '{tur}', '{kategori}', {miktar}, '{aciklama}')";

            OleDbCommand cmd = new OleDbCommand(komut, connect);

            connect.Open();
            cmd.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Gelir/Gider başarıyla kaydedildi!");
        }
    }
}
