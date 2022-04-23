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
    public partial class frmradiodinle : Form
    {
        public frmradiodinle()
        {
            InitializeComponent();
        }

        private void frmradiodinle_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = " http://yayin.turkiletisim.com.tr:9207/;";
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = " http://yayin1.yayindakiler.com:3046/;";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            axWindowsMediaPlayer1.URL = " http://RADYOiLAHi.ORG:9200";
        }
    }
}
