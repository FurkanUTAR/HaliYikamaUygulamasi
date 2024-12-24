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
            goster();
            hesap();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            gelirGiderTakip gelirGiderTakip = new gelirGiderTakip();
            gelirGiderTakip.Show();
            this.Hide();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            sil();
        }

        void goster()
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
            MessageBox.Show($"Toplam Gelir: {toplamGelir}\nToplam Gider: {toplamGider}\nNet Kazanç: {netkazanc}");
        }

        void sil()
        { 
            string kimlik=gelirGiderDataGridView.CurrentRow.Cells[0].Value.ToString();

            string komut = "DELETE FROM gelirGiderTakip WHERE Kimlik=" + kimlik;

            connect.Open();

            OleDbCommand cmd=new OleDbCommand(komut,connect);
            cmd.ExecuteNonQuery();

            connect.Close();
            goster();
        }
    }
}
