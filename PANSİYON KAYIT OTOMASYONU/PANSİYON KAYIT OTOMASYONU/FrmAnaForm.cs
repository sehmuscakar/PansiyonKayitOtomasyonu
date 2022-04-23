using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PANSİYON_KAYIT_OTOMASYONU
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdminGirişi fr = new FrmAdminGirişi();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr = new FrmYeniMusteri();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmmusteriler fr = new frmmusteriler();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PANSİYON OTOMASYON SİSTEMİ /2022- MERSİN //*01-03-2022 *//");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmodalar fr = new frmodalar();
            fr.Show();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();// form yüklendiğinde çlışır 
           // label1.Text = DateTime.Now.ToLongDateString();// tarihi veriri şimdiki 
           // label2.Text = DateTime.Now.ToLongTimeString();//simdiki saati verir

        }

        private void timer1_Tick(object sender, EventArgs e) //
        {
            label1.Text = DateTime.Now.ToLongDateString();// tarihi veriri şimdiki 
            label2.Text = DateTime.Now.ToLongTimeString();//simdiki saati verir
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();// buyle uygulamadan çıkar 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmgelirgider fr = new frmgelirgider();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmstoklar fr = new frmstoklar();
            fr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmradiodinle fr = new frmradiodinle();
            fr.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmgazeteler fr = new frmgazeteler();
            fr.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmsifregüncelle fr = new frmsifregüncelle();
            fr.Show();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmmesajlar fr = new frmmesajlar();
            fr.Show();
        }
    }
}
