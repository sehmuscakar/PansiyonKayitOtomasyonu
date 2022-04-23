using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PANSİYON_KAYIT_OTOMASYONU
{
    public partial class frmgelirgider : Form
    {
        public frmgelirgider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-O9RRR03;Initial Catalog=pansiyon_otomasyon;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            lblpersonelmaas.Text = (personel * 1500).ToString();

            int sonuc;
            sonuc = Convert.ToInt32(lblkasatoplam.Text) - (Convert.ToInt32(lblpersonelmaas.Text) + Convert.ToInt32(lblalinanürünler1.Text) + Convert.ToInt32(lblalinanürünler2.Text) + Convert.ToInt32(lblalinanürünler3.Text) + Convert.ToInt32(lblfaturalar1.Text) + Convert.ToInt32(lblfaturalar2.Text) + Convert.ToInt32(lblfaturalar3.Text));
            lblsonuc.Text = sonuc.ToString();
        }

        private void frmgelirgider_Load(object sender, EventArgs e)
        {
            //kasadaki toplam tutar
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" select sum(ucret) as toplam from musteri_ekle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblkasatoplam.Text = oku["toplam"].ToString();
            }
            baglanti.Close();
            //Gıdalar
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand(" select sum(gıda) as toplam1 from stoklar", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblalinanürünler1.Text = oku2["toplam1"].ToString();
            }
            baglanti.Close();
            //icecekler
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand(" select sum(icecek) as toplam2 from stoklar", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblalinanürünler2.Text = oku3["toplam2"].ToString();
            }
            baglanti.Close();
            //atıştırmalıklar
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand(" select sum(cerezler) as toplam3 from stoklar", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblalinanürünler3.Text = oku4["toplam3"].ToString();
            }
            baglanti.Close();

            // elektirik
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand(" select sum(elektirik) as toplam4 from faturalar", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                lblfaturalar1.Text= oku5["toplam4"].ToString();
            }
            baglanti.Close();

            // su
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand(" select sum(su) as toplam5 from faturalar", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                lblfaturalar2.Text = oku6["toplam5"].ToString();
            }
            baglanti.Close();

            // internet
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand(" select sum(internet) as toplam6 from faturalar", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                lblfaturalar3.Text = oku7["toplam6"].ToString();
            }
            baglanti.Close();
          
            /*//personel hesabı hesaplama 
            int personel;
            personel = Convert.ToInt32(textBox1.Text);
            lblpersonelmaas.Text = (personel * 1500).ToString();
            */

        }
    }
}
