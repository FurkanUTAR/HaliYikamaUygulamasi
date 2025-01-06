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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace haliYikama
{
    public partial class kayitEkrani : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public kayitEkrani()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            girisEkrani girisEkrani = new girisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox1.Visible = true;
            parolaTextBox.UseSystemPasswordChar = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox1.Visible = false;
            parolaTextBox.UseSystemPasswordChar = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            parolaDogrulaTextBox.UseSystemPasswordChar = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            parolaDogrulaTextBox.UseSystemPasswordChar = true;
        }

        private void kayitOlButton_Click(object sender, EventArgs e)
        {
            kontrol();
        }

        private void telNoTextBox_Enter(object sender, EventArgs e)
        {
            telNoTextBox.SelectionStart = telNoTextBox.Text.Length;
            telNoTextBox.SelectionLength = 0;
        }

        private void kayitOlButton_MouseEnter(object sender, EventArgs e)
        {
            kayitOlButton.BackColor = Color.FromArgb(200, 220, 240);
        }

        private void kayitOlButton_MouseLeave(object sender, EventArgs e)
        {
            kayitOlButton.BackColor = Color.FromArgb(190, 210, 225);
        }

        private void girisYapLabel_MouseEnter(object sender, EventArgs e)
        {
            girisYapLabel.ForeColor = Color.FromArgb(170, 170, 195);
        }

        private void girisYapLabel_MouseLeave(object sender, EventArgs e)
        {
            girisYapLabel.ForeColor = Color.FromArgb(34, 34, 34);
        }

        void ekle()
        {
            string komut = "INSERT INTO kullanicilar (firmaAdi,kullaniciAdi,parola,ePosta,telNo) VALUES ('" + firmaAdiTextBox.Text + "','" + kullaniciAdiTextBox.Text + "','" + parolaTextBox.Text + "','" + ePostaTextBox.Text + "','" + telNoTextBox.Text + "') ";

            connect.Open();

            OleDbCommand ekle = new OleDbCommand(komut, connect);
            ekle.ExecuteNonQuery();

            connect.Close();
        }

        void kontrol()
        {
            if (string.IsNullOrEmpty(firmaAdiTextBox.Text) || string.IsNullOrEmpty(kullaniciAdiTextBox.Text) || string.IsNullOrEmpty(ePostaTextBox.Text) || string.IsNullOrEmpty(parolaTextBox.Text) || string.IsNullOrEmpty(parolaDogrulaTextBox.Text))
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız!!!");
            }
            else
            {
                if (kullaniciAdiTextBox.Text == parolaTextBox.Text || firmaAdiTextBox.Text == parolaTextBox.Text) MessageBox.Show("Parolanız kulanıcı adıyla veya firma adıyla aynı olamaz!!!");
                else
                {
                    if (ePostaTextBox.Text.EndsWith("@"))
                    {
                        if (telNoTextBox.Text.StartsWith("05"))
                        {
                            if (telNoTextBox.Text.Length != 14)
                            {
                                MessageBox.Show("Telefon numarasının arasına boşluk koyarak yazınız(0555 555 55 55) ve\n" +
                                                "Telefon numarasının 11 karakter olduğundan emin olun!!!");
                            }
                            else
                            {
                                if (parolaTextBox.Text == parolaDogrulaTextBox.Text)
                                {
                                    if (!string.IsNullOrEmpty(parolaTextBox.Text)) ekle();
                                }
                                else MessageBox.Show("Parolalar Uyuşmuyor");
                            }
                        }
                        else MessageBox.Show("Telefon Numarası " + 05 + " ile başlamalıdır!!!");
                    }
                    else MessageBox.Show("e-Posta Adresini doğru girdiğinizden emin olun!!!");
                }
            }
        }
    }
}
