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
    public partial class frmstoklar : Form
    {
        public frmstoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-O9RRR03;Initial Catalog=pansiyon_otomasyon;Integrated Security=True");
        // erşim belirleyici
        private void veriler1()
        {
            listView1.Items.Clear();// bu verilerin tekrarını ünler 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from stoklar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["gıda"].ToString();// kök diğerleri cocukları 
                ekle.SubItems.Add(oku["icecek"].ToString());
                ekle.SubItems.Add(oku["cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
            
        }
        private void veriler2()
        {
            listView1.Items.Clear();// bu verilerin tekrarını ünler 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from faturalar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["elektirik"].ToString();// kök diğerleri cocukları 
                ekle.SubItems.Add(oku["su"].ToString());
                ekle.SubItems.Add(oku["internet"].ToString());
                listView2.Items.Add(ekle);
            }
            baglanti.Close();

        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            //veriler(); kaydete basınca değilde 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into stoklar(gıda,icecek,cerezler) values ('" + txtgıdalar.Text + "','" + txticecekler.Text + "','" + txtatıştırmalıklar.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler1();
        }

        private void frmstoklar_Load(object sender, EventArgs e)
        {
            veriler1();// form yüklendiğinde direk gelsin 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into faturalar(elektirik,su,internet) values ('" + txtelektirk.Text + "','" + txtsu.Text + "','" + txtinternet.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veriler2();
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            veriler2();
        }
    }
}
