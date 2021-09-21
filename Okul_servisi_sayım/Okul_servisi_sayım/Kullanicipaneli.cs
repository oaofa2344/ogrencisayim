using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Okul_servisi_sayım
{
    public partial class Kullanicipaneli : Form
    {
        public Kullanicipaneli()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        SqlCommand cmd;
        SqlDataReader dr;
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult mesaj = MessageBox.Show("Çıkış yapmak istediğinize eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (mesaj == DialogResult.Yes)
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                cmd = new SqlCommand("TRUNCATE TABLE kullanici", baglanti);
                baglanti.Open();
                cmd.ExecuteNonQuery();
                baglanti.Close();

                Girispaneli git = new Girispaneli();
                git.Show();
                this.Hide();

            }
            else if (mesaj == DialogResult.No)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ogrencirapor git = new ogrencirapor();
            this.Hide();
            git.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aracsoforrapor git = new aracsoforrapor();
            this.Hide();
            git.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kullaniciguncelle git = new Kullaniciguncelle();
            this.Hide();
            git.Show();
        }

        private void Kullanicipaneli_Load(object sender, EventArgs e)
        {

        }  

    }
}
