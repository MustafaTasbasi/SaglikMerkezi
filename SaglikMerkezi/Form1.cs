using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaglikMerkezi
{
    public partial class Form1 : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source=MUSTAFA\\SQLEXPRESS;Initial Catalog=SS;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            KayitSayfasi kayitSayfasi = new KayitSayfasi();
            kayitSayfasi.Show();

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (txtTc.Text.Trim().Length < 11)
            {

                MessageBox.Show("Tcnizi giriniz");
                txtTc.Focus();

            }
            else if (txtSifre.Text.Trim().Length <= 0)
            {
                MessageBox.Show("şifrenizi giriniz");
                txtSifre.Focus();
            }
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * From doktor where tc=@p1 and sifre=@p2", baglan);
            komut.Parameters.AddWithValue("@p1", txtTc.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Doktor frm = new Doktor();
                frm.did = dr.GetInt32(0);
                frm.Show();
                this.Hide();
            }
            dr.Close();
            String sorgu = "Select * From hasta where tc='" + txtTc.Text + "' and sifre='" + txtSifre.Text + "'";
            SqlCommand komut2 = new SqlCommand(sorgu, baglan);
            SqlDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {

                Hasta frm = new Hasta();
                frm.hid = dr2.GetInt32(0);
                frm.Show();
                this.Hide();
            }

            baglan.Close();

        }
    }
}
