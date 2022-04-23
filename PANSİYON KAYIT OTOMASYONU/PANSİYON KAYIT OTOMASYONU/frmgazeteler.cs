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
    public partial class frmgazeteler : Form
    {
        public frmgazeteler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("https://www.hurriyetdailynews.com/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("https://www.milliyet.com.tr/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("https://www.sozcu.com.tr/");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("https://www.fanatik.com.tr/");
        }
    }
}
