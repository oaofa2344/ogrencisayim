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
    public partial class Kayitpaneli : Form
    {
        public Kayitpaneli()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Girispaneli git = new Girispaneli();
            git.Show();
            this.Hide();
        }
        Baglanti bgl = new Baglanti();
        SqlCommand cmd;
        SqlDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            cmd = new SqlCommand("INSERT INTO Kayitol(ad,soyad,tc_no,kullanici_adi,sifre) VALUES('" + txt_ad.Text + "','" + txt_soyad.Text + "','" + txt_tc.Text + "','" + txt_kullanici_adi.Text + "','" + txt_sifre.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarılı");
            baglanti.Close();
        }

        private void Kayitpaneli_Load(object sender, EventArgs e)
        {

        }
    }
}
