using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SaglikMerkezi
{
    public partial class Hasta : Form
    {
        public int hid = -1;
        SqlConnection baglan = new SqlConnection("Data Source=MUSTAFA\\SQLEXPRESS;Initial Catalog=SS;Integrated Security=True");
        public Hasta()
        {
            InitializeComponent();
        }
        DDoktorTableAdapters.doktorTableAdapter dt = new DDoktorTableAdapters.doktorTableAdapter();
        private void Hasta_Load(object sender, EventArgs e)
        {
            doktorgrid.DataSource = dt.GetData();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From hasta where hid='" + hid + "'", baglan);
            SqlDataReader dr = komut.ExecuteReader();
            dr.Read();
            lblIsim.Text = dr.GetString(2);
            lblSoyisim.Text = dr.GetString(3);
            dr.Close();
            /*SqlDataAdapter da = new SqlDataAdapter("SELECT hasta.tc, hasta.isim, hasta.soyisim, randevu.tarih, randevu.saat FROM hasta INNER JOIN randevu ON hasta.hid = randevu.hid where randevu.did = '" + did + "' order by tarih desc", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds, "randevu");
            dataGridView1.DataSource = ds.Tables[0];*/
            String ay = DateTime.Now.Month.ToString();
            String gun = DateTime.Now.Day.ToString();
            String yil = DateTime.Now.Year.ToString();
            txtTarih.Text = ay+"."+gun+"."+yil;

            baglan.Close();
            calistir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = doktorgrid.SelectedCells[0].RowIndex;
            txtDid.Text = doktorgrid.Rows[x].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tarih = txtTarih.Text;
            String saat = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            string did = txtDid.Text;
            baglan.Open(); //öncelikle bağlantının açılması gerekir.
                           //SqlCommand komutlar = new SqlCommand("insert into hasta(tc,isim,soyisim,dtarihi,adres,tel,mail,sifre) values ('11111111111','ali','veli','1.1.2000','sakarya','5070812565','n@n.com','123456')", baglanti); //Sqlcommand sınıfından komut isminde nesne türetilir. çift tırnak içine sql sorgusu yazılır.
            String sorgu = "insert into randevu(did,hid,tarih,saat) values ('" + did + "','" + hid + "','" + tarih + "','" + saat + "')";
            
            SqlCommand komutlar = new SqlCommand(sorgu, baglan); //Sqlcommand sınıfından komut isminde nesne türetilir. çift tırnak içine sql sorgusu yazılır.
 

            komutlar.ExecuteNonQuery();
            txtTarih.Text = sorgu;
            baglan.Close();
            MessageBox.Show("kayıt gerçekleşti");
            calistir();
        }
        public void calistir()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT rid,doktor.tc, doktor.isim, doktor.soyisim, randevu.tarih, randevu.saat FROM doktor INNER JOIN randevu ON doktor.did = randevu.did where randevu.hid = '" + hid + "' order by tarih desc", baglan);
            DataSet ds = new DataSet();
            da.Fill(ds, "randevu");
            Grandevu.DataSource = ds.Tables[0];
        }

        private void Grandevu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = Grandevu.SelectedCells[0].RowIndex;
            txtrid.Text = Grandevu.Rows[x].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.Open(); //öncelikle bağlantının açılması gerekir.
            String sorgu = "delete from randevu where rid =  '" + txtrid.Text + "'";

            SqlCommand komutlar = new SqlCommand(sorgu, baglan); //Sqlcommand sınıfından komut isminde nesne türetilir. çift tırnak içine sql sorgusu yazılır.


            komutlar.ExecuteNonQuery();
            txtTarih.Text = sorgu;
            baglan.Close();
            MessageBox.Show("kayıt silindi");
            calistir();
        }

        private void txtDid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
