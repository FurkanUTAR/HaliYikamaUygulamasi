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
    public partial class gelirGiderTablo : Form
    {

        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public gelirGiderTablo()
        {
            InitializeComponent();
        }

        private void gelirGiderTablo_Load(object sender, EventArgs e)
        {
            yukle();
            goster();
            hesap();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            gelirGiderTakip gelirGiderTakip = new gelirGiderTakip();
            gelirGiderTakip.Show();
            this.Hide();
        }

        private void filtreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filtreComboBox.SelectedIndex == 0) tarihAzalan();
            else if (filtreComboBox.SelectedIndex == 1) tarihArtan();
            else if (filtreComboBox.SelectedIndex == 2) fiyatAzalan();
            else if (filtreComboBox.SelectedIndex == 3) fiyatArtan();
            else if (filtreComboBox.SelectedIndex == 4) gelirGoster();
            else if (filtreComboBox.SelectedIndex == 5) giderGoster();
            else goster();
        }

        private void silButton_Click(object sender, EventArgs e) 
        {
            sil();
        }

        void yukle()
        {
            filtreComboBox.Items.Add("Tarih Azalan");
            filtreComboBox.Items.Add("Tarih Artan");
            filtreComboBox.Items.Add("Fiyat Azalan");
            filtreComboBox.Items.Add("Fiyat Artan");
            filtreComboBox.Items.Add("Sadece Gelir");
            filtreComboBox.Items.Add("Sadece Gider");
        }

        void hesap()
        {
            string toplamGelirkomut = "SELECT SUM(miktar) FROM gelirGiderTakip WHERE tur = 'Gelir'";
            string toplamGiderkomut = "SELECT SUM(miktar) FROM gelirGiderTakip WHERE tur = 'Gider'";

            connect.Open();

            OleDbCommand cmdGelir = new OleDbCommand(toplamGelirkomut, connect);
            OleDbCommand cmdGider = new OleDbCommand(toplamGiderkomut, connect);

            object gelirSonuc = cmdGelir.ExecuteScalar();
            double toplamGelir = gelirSonuc != DBNull.Value ? Convert.ToDouble(gelirSonuc) : 0;

            object giderSonuc = cmdGider.ExecuteScalar();
            double toplamGider = giderSonuc != DBNull.Value ? Convert.ToDouble(giderSonuc) : 0;

            connect.Close();

            double netkazanc = toplamGelir - toplamGider;

            gelirLabel.Text = gelirSonuc.ToString();
            giderLabel.Text = giderSonuc.ToString();
            karLabel.Text = netkazanc.ToString();
        }

        void sil()
        {
            string kimlik = gelirGiderDataGridView.CurrentRow.Cells[0].Value.ToString();

            string komut = "DELETE FROM gelirGiderTakip WHERE Kimlik=" + kimlik;

            connect.Open();

            OleDbCommand cmd = new OleDbCommand(komut, connect);
            cmd.ExecuteNonQuery();

            connect.Close();
            goster();
        }

        void goster()
        {
            string komut = "SELECT * FROM gelirGiderTakip";
            OleDbCommand cmd = new OleDbCommand(komut, connect);

            connect.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();

            gelirGiderDataGridView.DataSource = dt;
            gelirGiderDataGridView.Columns["Kimlik"].Visible = false;
        }

        void tarihAzalan()
        {
            string komut = "SELECT * FROM gelirGiderTakip ORDER BY tarih DESC";
            OleDbCommand cmd = new OleDbCommand(komut, connect);

            connect.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();

            gelirGiderDataGridView.DataSource = dt;
            gelirGiderDataGridView.Columns["Kimlik"].Visible = false;
        }

        void tarihArtan()
        {
            string komut = "SELECT * FROM gelirGiderTakip ORDER BY tarih ASC";
            OleDbCommand cmd = new OleDbCommand(komut, connect);

            connect.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();

            gelirGiderDataGridView.DataSource = dt;
            gelirGiderDataGridView.Columns["Kimlik"].Visible = false;
        }

        void fiyatAzalan()
        {
            string komut = "SELECT * FROM gelirGiderTakip ORDER BY miktar DESC";
            OleDbCommand cmd = new OleDbCommand(komut, connect);

            connect.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();

            gelirGiderDataGridView.DataSource = dt;
            gelirGiderDataGridView.Columns["Kimlik"].Visible = false;
        }

        void fiyatArtan()
        {
            string komut = "SELECT * FROM gelirGiderTakip ORDER BY miktar ASC";
            OleDbCommand cmd = new OleDbCommand(komut, connect);

            connect.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();

            gelirGiderDataGridView.DataSource = dt;
            gelirGiderDataGridView.Columns["Kimlik"].Visible = false;

        }

        void gelirGoster()
        {
            string komut = "SELECT * FROM gelirGiderTakip WHERE tur='Gelir'";
            OleDbCommand cmd = new OleDbCommand(komut, connect);

            connect.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();

            gelirGiderDataGridView.DataSource = dt;
            gelirGiderDataGridView.Columns["Kimlik"].Visible = false;
        }

        void giderGoster()
        {
            string komut = "SELECT * FROM gelirGiderTakip WHERE tur='Gider'";
            OleDbCommand cmd = new OleDbCommand(komut, connect);

            connect.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connect.Close();

            gelirGiderDataGridView.DataSource = dt;
            gelirGiderDataGridView.Columns["Kimlik"].Visible = false;
        }
    }
}
