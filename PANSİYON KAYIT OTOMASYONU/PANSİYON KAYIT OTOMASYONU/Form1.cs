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
    public partial class FrmAdminGirişi : Form
    {
        public FrmAdminGirişi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-O9RRR03;Initial Catalog=pansiyon_otomasyon;Integrated Security=True");
        private void btngirişyap_Click(object sender, EventArgs e)
        {
            // try catch blogu : deneme ve yakalama yöntemi kulanır eğer doğru ise try olur 
            // yanliş ise catch içinde uyarı verir nasıl doğru yapacahını süyler gibisinden// iki defa tab yap try yazdıktan sonra  
            try
            {
                baglanti.Open();
                string sql = "select * from admingiris where kullanici=@kullaniciadi AND sifre=@sifresi";
                SqlParameter prm1 = new SqlParameter("kullaniciadi", txtkulaniciadi.Text.Trim());//trim paremetre olrak girilen değerlerin başındaki ve sonundaki boşlukları siliyor 
                SqlParameter prm2 = new SqlParameter("sifresi", txtsifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);// burda ilşk,,ilendirme yaptık 
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);// bunları 

                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("HATALI GİRİŞ");
            }
        }

        private void FrmAdminGirişi_Load(object sender, EventArgs e)
        {

        }
    }
}

