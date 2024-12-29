using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace haliYikama
{
    public partial class tamamlandi : Form
    {
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=haliYikama.mdb");

        public tamamlandi()
        {
            InitializeComponent();
        }

        private void geriDonPictureBox_Click(object sender, EventArgs e)
        {
            anaSayfa anaSayfa = new anaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        void veriGoster()
        {
            string komut = "SELECT * FROM siparisler WHERE siparisDurum='Tamamlandi'";

            connect.Open();

            OleDbDataAdapter da=new OleDbDataAdapter(komut,connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            tamamlandiDataGridView.DataSource = dt;

            connect.Close();
        }

        private void tamamlandi_Load(object sender, EventArgs e)
        {
            veriGoster();
        }
    }
}
