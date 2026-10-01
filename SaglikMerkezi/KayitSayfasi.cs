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
    public partial class KayitSayfasi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=MUSTAFA\\SQLEXPRESS;Initial Catalog=SS;Integrated Security=True");
        public KayitSayfasi()
        {
            InitializeComponent();
        }

        private void btnKpt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (txtTc.Text == "" || txtIsim.Text == "" || txtSoyisim.Text == "" || txtDT.Text == "" || txtAdres.Text == "" || txtTel.Text == "" || txtMail.Text == "" || txtSifre.Text == "")
            {

                MessageBox.Show("Boş kalan yerleri doldurunuz.");

            }

            else
            {
                if (txtSifre.Text != txtSifreTkr.Text)
                {
                    MessageBox.Show("Şifreler aynı değil!");
                }
                else
                {
                    baglanti.Open(); //öncelikle bağlantının açılması gerekir.
                                     //SqlCommand komutlar = new SqlCommand("insert into hasta(tc,isim,soyisim,dtarihi,adres,tel,mail,sifre) values ('11111111111','ali','veli','1.1.2000','sakarya','5070812565','n@n.com','123456')", baglanti); //Sqlcommand sınıfından komut isminde nesne türetilir. çift tırnak içine sql sorgusu yazılır.

                    SqlCommand komutlar = new SqlCommand("insert into hasta(tc,isim,soyisim,dtarihi,adres,tel,mail,sifre) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti); //Sqlcommand sınıfından komut isminde nesne türetilir. çift tırnak içine sql sorgusu yazılır.
                    komutlar.Parameters.AddWithValue("@p1", txtTc.Text); //komut nesnesinden gelen parametreleri değer olarak ekle.
                    komutlar.Parameters.AddWithValue("@p2", txtIsim.Text);
                    komutlar.Parameters.AddWithValue("@p3", txtSoyisim.Text);
                    komutlar.Parameters.AddWithValue("@p4", txtDT.Text);
                    komutlar.Parameters.AddWithValue("@p5", txtAdres.Text);
                    komutlar.Parameters.AddWithValue("@p6", txtTel.Text);
                    komutlar.Parameters.AddWithValue("@p7", txtMail.Text);
                    komutlar.Parameters.AddWithValue("@p8", txtSifre.Text);

                    komutlar.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("kayıt gerçekleşti");
                    

                }
                this.Close();
            }
        }
    }
}
