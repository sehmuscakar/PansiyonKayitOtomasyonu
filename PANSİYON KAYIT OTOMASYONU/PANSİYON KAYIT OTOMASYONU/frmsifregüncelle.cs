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
    public partial class frmsifregüncelle : Form
    {
        public frmsifregüncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-O9RRR03;Initial Catalog=pansiyon_otomasyon;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update admingiris set kullanici='" + txtkulaniciadi.Text + "',sifre='" + txtsifre.Text + "'", baglanti);
            komut.ExecuteNonQuery();// komutlar üzerinde ta değişkilik yapmasını sağlar 
            baglanti.Close();

            MessageBox.Show("şifreniz Güncellendi");
        }
        
    }
}
