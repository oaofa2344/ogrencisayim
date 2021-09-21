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
    public partial class Kullaniciislemleri : Form
    {
        public Kullaniciislemleri()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Adminpanel git = new Adminpanel();
            git.Show();
            this.Hide();
        }
        Baglanti bgl = new Baglanti();
        SqlCommand cmd;
        SqlDataReader dr;


       

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

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            cmd = new SqlCommand("SELECT * FROM Kayitol where kullanici_adi=@kullanici_adi", baglanti);
            cmd.Parameters.AddWithValue("kullanici_adi", txt_kullaniciislemleri_kullanici_ad.Text);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string kullanici = dr["kullanici_adi"].ToString();
                dr.Close();
                if (DialogResult.Yes == MessageBox.Show(kullanici.ToString() + " kullanıcısını silmek istediğinize eminmisiniz?", "UYARI", MessageBoxButtons.YesNo))
                {

                    cmd = new SqlCommand("DELETE from Kayitol where kullanici_adi=@kullanici_adi ", baglanti);
                    cmd.Parameters.AddWithValue("kullanici_adi", txt_kullaniciislemleri_kullanici_ad.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kullanıcı Silindi");
                }
                else
                {
                    MessageBox.Show("Silme işleminizi iptal ettiniz");
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Bulunamadı!");
            }

              baglanti.Close();                      
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            cmd = new SqlCommand("INSERT INTO Kayitol(ad,soyad,tc_no,kullanici_adi,sifre) VALUES('" + txt_kullaniciislemleri_ad.Text + "','" + txt_kullaniciislemler_soyad + "','" + txt_kullaniciislemleri_tc.Text + "','" + txt_kullaniciislemleri_kullanici_ad.Text + "','" + txt_kullaniciislelmeri_sifre.Text + "')", baglanti);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarılı");
            baglanti.Close();
        }

        private void Kullaniciislemleri_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM Kayitol  ", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtg_kullanici.DataSource = ds.Tables[0];
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
