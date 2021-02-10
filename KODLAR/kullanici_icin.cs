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
    public partial class kullanici_icin : Form
    {
        public kullanici_icin()
        {
            InitializeComponent();
        }
        SALONLARIN_İÇİ salon1;
        private void button4_Click(object sender, EventArgs e)
        {
            salon1 = new SALONLARIN_İÇİ();
            salon1.Show();
        }
        uygulamalarım uygu;
        private void button3_Click(object sender, EventArgs e)
        {
            uygu = new uygulamalarım();
            uygu.Show();
        }
        onerı ON;
        private void button1_Click(object sender, EventArgs e)
        {
            ON = new onerı();
            ON.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        musterı_profılı musus;
        private void button9_Click(object sender, EventArgs e)
        {
            musus = new musterı_profılı();
            musus.Show();
        }

        private void kullanici_icin_Load(object sender, EventArgs e)
        {

        }
        SIKAYET_ET sıka;
        private void button11_Click(object sender, EventArgs e)
        {
            //ŞİKAYET ET
            sıka = new SIKAYET_ET();
            sıka.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            

        }
    }
}
