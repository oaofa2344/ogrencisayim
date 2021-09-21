using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okul_servisi_sayım
{
    public partial class Adminpanel : Form
    {
        public Adminpanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullaniciislemleri git = new Kullaniciislemleri();
            git.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ogrencikayit git = new Ogrencikayit();
            git.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ogrencibilgileri git = new ogrencibilgileri();
            git.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ceaziislemler git = new ceaziislemler();
            git.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult mesaj = MessageBox.Show("Çıkış yapmak istediğinize eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (mesaj == DialogResult.Yes)
            {
                Girispaneli git = new Girispaneli();
                git.Show();
                this.Hide();
                
            }
            else if (mesaj == DialogResult.No)
            {
                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            aracsofor git = new aracsofor();
            git.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ogrencilistesi git = new ogrencilistesi();
            this.Hide();
            git.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            aracsofordenetim git = new aracsofordenetim();
            this.Hide();
            git.Show();
        }

        private void Adminpanel_Load(object sender, EventArgs e)
        {

        }
    }
}
