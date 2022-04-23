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
    public partial class frmmesajlar : Form
    {
        public frmmesajlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-O9RRR03;Initial Catalog=pansiyon_otomasyon;Integrated Security=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();// burda her bastığında temizleyip getirecek eskisini silecel yeni gelecek 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from mesajlar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();//okuma işlemi için 
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();// listView e öğe ekleme için  

                ekle.Text = oku["mesajid"].ToString();// bu kök döğüm 
                ekle.SubItems.Add(oku["Adsoyad"].ToString());// bu cocukları gibi düşün 
                ekle.SubItems.Add(oku["mesaj"].ToString());


                listView1.Items.Add(ekle);// buda bulunan listview e ekler 

            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into mesajlar (adsoyad,mesaj) values('" + textBox1.Text + "','" + richTextBox1.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void frmmesajlar_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }
        // bu kısım id ye tıklandığında  mesaj ve adsoyad gürüntülemesini yapar 
        int id = 0;
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox1.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }
    }
}
