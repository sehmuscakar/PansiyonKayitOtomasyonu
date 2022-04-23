using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PANSİYON_KAYIT_OTOMASYONU
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-O9RRR03;Initial Catalog=pansiyon_otomasyon;Integrated Security=True");
        private void btnoda101_Click(object sender, EventArgs e)
        {
            txtodanumara.Text = "101";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda101 (adi,soyadi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnoda102_Click(object sender, EventArgs e)
        {
            txtodanumara.Text = "102";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda102 (adi,soyadi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btnoda103_Click(object sender, EventArgs e)
        {
            txtodanumara.Text = "103";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda103 (adi,soyadi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnoda104_Click(object sender, EventArgs e)
        {
            txtodanumara.Text = "104";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda104 (adi,soyadi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnoda105_Click(object sender, EventArgs e)
        {
            txtodanumara.Text = "105";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda105 (adi,soyadi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnoda106_Click(object sender, EventArgs e)
        {
            txtodanumara.Text = "106";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda106 (adi,soyadi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnoda107_Click(object sender, EventArgs e)
        {
            txtodanumara.Text = "107";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda107 (adi,soyadi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnoda108_Click(object sender, EventArgs e)
        {
            txtodanumara.Text = "108";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda108 (adi,soyadi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btnoda109_Click(object sender, EventArgs e)
        {
            txtodanumara.Text = "109";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into oda109 (adi,soyadi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void btndoluoda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Butonlar Dolu Odaları Güsterir ");
        }

        private void btnboşoda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Butonlar Boş Odaları Güsterir ");
        }

        private void dtpgiriştarihi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpcıkıştarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kucuktarih = Convert.ToDateTime(dtpgiriştarihi.Text);
            DateTime buyuktarih = Convert.ToDateTime(dtpcıkıştarihi.Text);
            // timespaniki tarih arası farkı verir
            TimeSpan sonuc;
            sonuc = buyuktarih - kucuktarih;
            label11.Text = sonuc.TotalDays.ToString();//TotalDays bu toplam günü yazdırır 

            ucret = Convert.ToInt32(label11.Text) * 50;// burda label11 zman cinsinden bir veri olduğu için int e dünüştürdük 
            txtucret.Text = ucret.ToString();


        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();// bağlantı yolumuzu açtık 
            SqlCommand komut = new SqlCommand("insert into musteri_ekle (Adi,soyadi,cinsiyet,telefon,mail,tc,odano,ucret,gidistarihi,cikistarihi) values ('" + txtadi.Text + "','" + txtsoyadi.Text + "','" + comboxcinsiyet.Text + "','" + msktelefon.Text + "','" + txtmail.Text + "','" + txtTC.Text + "','" + txtodanumara.Text + "','" + txtucret.Text + "','" + dtpgiriştarihi.Value.ToString("yyyy-MM-dd") + "','" + dtpcıkıştarihi.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı");
        }

        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select * from oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            while (oku1.Read())
            {
                btnoda101.Text = oku1["adi"].ToString() + " " + oku1["soyadi"].ToString();
            }
            baglanti.Close();
            // buda oda numarası dışında bişey yazıyorsa renk değiştirecek
            if (btnoda101.Text != "101")
            {
                btnoda101.BackColor = Color.Red;
                btnoda101.Enabled = false;
            }

            //--------------
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from oda102", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                btnoda102.Text = oku2["adi"].ToString() + " " + oku2["soyadi"].ToString();
            }
            baglanti.Close();
            // buda oda numarası dışında bişey yazıyorsa renk değiştirecek
            if (btnoda102.Text != "102")
            {
                btnoda102.BackColor = Color.Red;
                btnoda102.Enabled = false;
            }
            //--------
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select * from oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            while (oku3.Read())
            {
                btnoda103.Text = oku3["adi"].ToString() + " " + oku3["soyadi"].ToString();
            }
            baglanti.Close();
            // buda oda numarası dışında bişey yazıyorsa renk değiştirecek
            if (btnoda103.Text != "103")
            {
                btnoda103.BackColor = Color.Red;
                btnoda103.Enabled = false;
            }
            //----------------------
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select * from oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            while (oku4.Read())
            {
                btnoda104.Text = oku4["adi"].ToString() + " " + oku4["soyadi"].ToString();
            }
            baglanti.Close();
            // buda oda numarası dışında bişey yazıyorsa renk değiştirecek
            if (btnoda104.Text != "104")
            {
                btnoda104.BackColor = Color.Red;
                btnoda104.Enabled = false;
            }
            //-------------------------
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select * from oda105", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();

            while (oku5.Read())
            {
                btnoda105.Text = oku5["adi"].ToString() + " " + oku5["soyadi"].ToString();
            }
            baglanti.Close();
            // buda oda numarası dışında bişey yazıyorsa renk değiştirecek
            if (btnoda105.Text != "105")
            {
                btnoda105.BackColor = Color.Red;
                btnoda105.Enabled = false;
            }
            //--------------------------------------
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from oda106", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();

            while (oku6.Read())
            {
                btnoda106.Text = oku6["adi"].ToString() + " " + oku6["soyadi"].ToString();
            }
            baglanti.Close();
            // buda oda numarası dışında bişey yazıyorsa renk değiştirecek
            if (btnoda106.Text != "106")
            {
                btnoda106.BackColor = Color.Red;
                btnoda106.Enabled = false;
            }
            //---------------
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select * from oda107", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();

            while (oku7.Read())
            {
                btnoda107.Text = oku7["adi"].ToString() + " " + oku7["soyadi"].ToString();
            }
            baglanti.Close();
            // buda oda numarası dışında bişey yazıyorsa renk değiştirecek
            if (btnoda107.Text != "107")
            {
                btnoda107.BackColor = Color.Red;
                btnoda107.Enabled = false;
            }
            //------------------
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select * from oda108", baglanti);
            SqlDataReader oku8 = komut8.ExecuteReader();

            while (oku8.Read())
            {
                btnoda108.Text = oku8["adi"].ToString() + " " + oku8["soyadi"].ToString();
            }
            baglanti.Close();
            // buda oda numarası dışında bişey yazıyorsa renk değiştirecek
            if (btnoda108.Text != "108")
            {
                btnoda108.BackColor = Color.Red;
                btnoda108.Enabled = false;
            }
            //--------------------
            baglanti.Open();
            SqlCommand komut9 = new SqlCommand("select * from oda109", baglanti);
            SqlDataReader oku9 = komut9.ExecuteReader();

            while (oku9.Read())
            {
                btnoda109.Text = oku9["adi"].ToString() + " " + oku9["soyadi"].ToString();
            }
            baglanti.Close();
            // buda oda numarası dışında bişey yazıyorsa renk değiştirecek
            if (btnoda109.Text != "109")
            {
                btnoda109.BackColor = Color.Red;
                btnoda109.Enabled = false;
            }
        }

     
    }
}

