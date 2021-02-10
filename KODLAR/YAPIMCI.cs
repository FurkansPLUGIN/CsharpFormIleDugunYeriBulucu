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
    public partial class YAPIMCI : Form
    {
        public YAPIMCI()
        {
            InitializeComponent();
        }
        kullanici_icin kullan;
        private void button1_Click(object sender, EventArgs e)
        {
            kullan = new kullanici_icin();
            kullan.Show();
        }
       Form2 fana;
        private void button2_Click(object sender, EventArgs e)
        {
            fana = new Form2();
            fana.Show();
            MessageBox.Show("DAHA FAZLA SALON EKLENDİKCE SALON ID VE İSMİNE GÖRE SALONLAR ARASI GEZINME OLACAKTIR TABLOSU HAZIRDIR", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        Form1 form1;
        KAYIT_SAYFASI kayıt1;
        SALON_SAHIBI_KAYIT kayıt2;
        //dugun_sahıbı_kayıt kayıt3;
        private void button3_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            form1.Show();
            kayıt1 = new KAYIT_SAYFASI();
            kayıt1.Show();
            kayıt2 = new SALON_SAHIBI_KAYIT();
            kayıt2.Show();
            //kayıt3 = new dugun_sahıbı_kayıt();
            //kayıt3.Show();
        }
        musterı_profılı mus;
       

        private void button4_Click(object sender, EventArgs e)
        {
           
            mus = new musterı_profılı();
            mus.Show();
        }
        onerileri_gor on;
        private void button5_Click(object sender, EventArgs e)
        {
            on = new onerileri_gor();
            on.Show();
        }
        uygulamalarım uygu;
        private void button6_Click(object sender, EventArgs e)
        {
            uygu = new uygulamalarım();
            uygu.Show();
        }
        //haraketler_frm haraket;
        private void button7_Click(object sender, EventArgs e)
        {
            //haraket = new haraketler_frm();
            //haraket.Show();
        }
        salon_ekle_cıkar ekcık;
        private void button8_Click(object sender, EventArgs e)
        {
            ekcık = new salon_ekle_cıkar();
            ekcık.Show();
        }
        musterıları_gor gor;
        private void button9_Click(object sender, EventArgs e)
        {
            gor = new musterıları_gor();
            gor.Show();
        }

        private void YAPIMCI_Load(object sender, EventArgs e)
        {

        }
        SIKAYET sıkayet;
        private void button10_Click(object sender, EventArgs e)
        {
            sıkayet = new SIKAYET();
            sıkayet.Show();
        }
    }
}
