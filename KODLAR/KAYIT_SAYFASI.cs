using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomasyon
{
    public partial class KAYIT_SAYFASI : Form
    {
        public KAYIT_SAYFASI()
        {
            InitializeComponent();
        }

        private void KAYIT_SAYFASI_Load(object sender, EventArgs e)
        {

        }
        kullanici_icin sahip;
        private void button2_Click(object sender, EventArgs e)
        {
            sahip = new kullanici_icin();
            sahip.Show();
        }
        SALON_SAHIBI_KAYIT sahıp;
        private void button1_Click(object sender, EventArgs e)
        {
            sahıp = new SALON_SAHIBI_KAYIT();
            sahıp.Show();
        }
        Form1 frm1;
        private void button3_Click(object sender, EventArgs e)
        {
            frm1 = new Form1();
            frm1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
