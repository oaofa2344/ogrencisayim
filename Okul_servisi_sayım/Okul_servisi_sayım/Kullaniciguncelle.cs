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
    public partial class Kullaniciguncelle : Form
    {
        public Kullaniciguncelle()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        
        SqlCommand cmd;
        SqlDataReader dr;
        private void Kullaniciguncelle_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            cmd = new SqlCommand("SELECT * FROM kullanici", baglanti);
            baglanti.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txt_kullaniciislemleri_kullanici_ad.Text=dr["kullanici_adi"].ToString();
            }
             baglanti.Close();
            SqlCommand cmd2;
            SqlDataReader dr2;
            cmd2 = new SqlCommand("select * from Kayitol where kullanici_adi='" + txt_kullaniciislemleri_kullanici_ad.Text + "'",  baglanti);
             baglanti.Open();
            dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                txt_kullaniciislemleri_tc.Text = dr2["tc_no"].ToString();
                txt_kullaniciislemleri_ad.Text = dr2["ad"].ToString();
                txt_kullaniciislemler_soyad.Text = dr2["soyad"].ToString();
                txt_kullaniciislelmeri_sifre.Text = dr2["sifre"].ToString();
            }

             baglanti.Close();
            
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
             baglanti.Open();
            cmd = new SqlCommand("Update Kayitol set ad=@ad, soyad=@soyad, tc_no=@tc_no, sifre=@sifre where kullanici_adi=@kullanici_adi", baglanti);
            cmd.Parameters.AddWithValue("ad", txt_kullaniciislemleri_ad.Text);
            cmd.Parameters.AddWithValue("soyad", txt_kullaniciislemler_soyad.Text);
            cmd.Parameters.AddWithValue("tc_no", txt_kullaniciislemleri_tc.Text.ToString());
            cmd.Parameters.AddWithValue("kullanici_adi", txt_kullaniciislemleri_kullanici_ad.Text);
            cmd.Parameters.AddWithValue("sifre", txt_kullaniciislelmeri_sifre.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Başarı İle Gerçekleşti");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kullanicipaneli git = new Kullanicipaneli();
            this.Hide();
            git.Show();
        }

        private void txt_kullaniciislemleri_kullanici_ad_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
