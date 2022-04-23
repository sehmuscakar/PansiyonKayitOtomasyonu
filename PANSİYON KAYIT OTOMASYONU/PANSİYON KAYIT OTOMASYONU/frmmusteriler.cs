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
    public partial class frmmusteriler : Form
    {
        public frmmusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-O9RRR03;Initial Catalog=pansiyon_otomasyon;Integrated Security=True");
        private void verilerigoster()
        {
            listView1.Items.Clear();// burda her bastığında temizleyip getirecek eskisini silecel yeni gelecek 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from musteri_ekle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();//okuma işlemi için 
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();// listView e öğe ekleme için  

                ekle.Text = oku["musteriid"].ToString();// bu kök döğüm 
                ekle.SubItems.Add(oku["Adi"].ToString());// bu cocukları gibi düşün 
                ekle.SubItems.Add(oku["soyadi"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["mail"].ToString());
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["odano"].ToString());
                ekle.SubItems.Add(oku["ucret"].ToString());
               // ekle.SubItems.Add(oku["giristarihi"].ToString());
                ekle.SubItems.Add(oku["cikistarihi"].ToString());

                listView1.Items.Add(ekle);// buda bulunan listview e ekler 

            }
            baglanti.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();//erişim belirtecini cağırdık 
        }

        int id = 0;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // burada id basıldığında veriler ekrana gelecek işte 
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);// bu kök döğümün kodu ,burda tür değişimi yaptık  
            txtadi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtsoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboxcinsiyet.Text = listView1.SelectedItems[0].SubItems[3].Text;
            msktelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtmail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtTC.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtodanumara.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtucret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            // dtpgiriştarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
          //  dtpcıkıştarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtodanumara.Text == "101")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda101", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();

            }
            if (txtodanumara.Text == "102")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda102", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (txtodanumara.Text == "103")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda103", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (txtodanumara.Text == "104")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda104", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (txtodanumara.Text == "105")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda105", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (txtodanumara.Text == "106")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda106", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (txtodanumara.Text == "107")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda107", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (txtodanumara.Text == "108")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda108", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
            if (txtodanumara.Text == "109")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from oda109", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                verilerigoster();
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtadi.Clear();
            txtsoyadi.Clear();
            comboxcinsiyet.Text = "";
            msktelefon.Clear();
            txtmail.Clear();
            txtTC.Clear();
            txtodanumara.Clear();
            txtucret.Clear();
           // dtpgiriştarihi.Text = "";
          //  dtpcıkıştarihi.Text = "";

        }

        private void frmmusteriler_Load(object sender, EventArgs e)
        {

        }

        private void btngüncele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update musteri_ekle set Adi='" + txtadi.Text + "',soyadi='" + txtsoyadi.Text + "',cinsiyet='" + comboxcinsiyet.Text + "',telefon='" + msktelefon.Text + "',mail='" + txtmail.Text + "',tc='" + txtTC.Text + "',odano='" + txtodanumara.Text + "',ucret='" + txtucret.Text + "' where musteriid=" + id + "", baglanti);
        komut.ExecuteNonQuery();// komutlar üzerinde ta değişkilik yapmasını sağlar 
            baglanti.Close();
            verilerigoster();
            //,giristarihi='" + dtpgiriştarihi.Value.ToString("yyyy-MM-dd") + "',cikistarihi='" + dtpcıkıştarihi.Value.ToString("yyyy-MM-dd") + "'
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();// burda her bastığında temizleyip getirecek eskisini silecel yeni gelecek 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from musteri_ekle where adi like '%"+textBox1.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();//okuma işlemi için 
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();// listView e öğe ekleme için  

                ekle.Text = oku["musteriid"].ToString();// bu kök döğüm 
                ekle.SubItems.Add(oku["Adi"].ToString());// bu cocukları gibi düşün 
                ekle.SubItems.Add(oku["soyadi"].ToString());
                ekle.SubItems.Add(oku["cinsiyet"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["mail"].ToString());
                ekle.SubItems.Add(oku["tc"].ToString());
                ekle.SubItems.Add(oku["odano"].ToString());
                ekle.SubItems.Add(oku["ucret"].ToString());
               // ekle.SubItems.Add(oku["giristarihi"].ToString());
                ekle.SubItems.Add(oku["cikistarihi"].ToString());

                listView1.Items.Add(ekle);// buda bulunan listview e ekler 

            }
            baglanti.Close();
        }
    }
}
// SqlCommand komut = new SqlCommand("delete from musteri_ekle where musteriid=(" + id + ")", baglanti);