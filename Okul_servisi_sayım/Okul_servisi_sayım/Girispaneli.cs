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
    public partial class Girispaneli : Form
    {
        public Girispaneli()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admingirisi git = new Admingirisi();
            git.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Kullanıcıgiriscs git = new Kullanıcıgiriscs();
            git.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kayitpaneli git = new Kayitpaneli();
            git.Show();
            this.Hide();
        }

        private void Girispaneli_Load(object sender, EventArgs e)
        {

        }
    }
}
