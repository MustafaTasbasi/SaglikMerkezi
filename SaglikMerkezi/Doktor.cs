using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaglikMerkezi
{
    public partial class Doktor : Form
    {
        public int did = -1;
        SqlConnection baglan = new SqlConnection("Data Source=MUSTAFA\\SQLEXPRESS;Initial Catalog=SS;Integrated Security=True");
        public Doktor()
        {
            InitializeComponent();
        }

        private void Doktor_Load(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From doktor where did='" + did + "'", baglan);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            lblIsim.Text = dr.GetString(2);
            lblSoyisim.Text = dr.GetString(3);
            dr.Close();
            SqlDataAdapter da = new SqlDataAdapter("SELECT hasta.tc, hasta.isim, hasta.soyisim, randevu.tarih, randevu.saat FROM hasta INNER JOIN randevu ON hasta.hid = randevu.hid where randevu.did = '" + did + "' order by tarih desc", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds, "randevu");
            dataGridView1.DataSource = ds.Tables[0];

            baglan.Close();

        }
    }
}
