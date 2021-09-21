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
    public partial class Ogrencikayit : Form
    {
        public Ogrencikayit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adminpanel git = new Adminpanel();
            git.Show();
            this.Hide();
        }
        Baglanti bgl = new Baglanti();
        SqlCommand cmd;
        SqlDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            cmd = new SqlCommand("Select * from beylikduzu", baglanti);
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            cmd = new SqlCommand("Select * from avcılar", baglanti);
            baglanti.Open();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            baglanti.Close();
            
        
            string adres = txt_adres.Text + " " + comboBox1.Text;
            if (comboBox1.Text=="Beylikdüzü")
            {
                string ad = txt_ad.Text + " " + txt_soyad.Text;
                if (dt.Rows.Count<=3)
                {
                    cmd = new SqlCommand("INSERT INTO beylikduzu (konum, ad_soyad, veli_tel, ogrenci_no) values (@konum, @ad_soyad, @veli_tel, @ogrenci_no) ", baglanti);
                    baglanti.Open();
                    cmd.Parameters.AddWithValue("konum", adres);
                    cmd.Parameters.AddWithValue("ad_soyad", ad);
                    cmd.Parameters.AddWithValue("veli_tel", txt_veli_tel.Text);
                    cmd.Parameters.AddWithValue("ogrenci_no", txt_ogrenci_no.Text);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();

                    baglanti.Open();
                    cmd = new SqlCommand("INSERT INTO ogrencikayit (ad, soyad, ogrenci_no, veli_ad_soyad, veli_tel,adres) values (@ad, @soyad, @ogrenci_no, @veli_ad_soyad, @veli_tel, @adres) ", baglanti);
                    cmd.Parameters.AddWithValue("ad", txt_ad.Text);
                    cmd.Parameters.AddWithValue("soyad", txt_soyad.Text);
                    cmd.Parameters.AddWithValue("ogrenci_no", txt_ogrenci_no.Text.ToString());
                    cmd.Parameters.AddWithValue("veli_ad_soyad", txt_veli_ad.Text);
                    cmd.Parameters.AddWithValue("veli_tel", txt_veli_tel.Text);
                    cmd.Parameters.AddWithValue("adres", adres);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt işleminiz Başarılı");
                }
                else
                {
                    MessageBox.Show("Servis mevcudu dolmuştur");
                }     
            }

            if (comboBox1.Text == "Avcılar")
                {
                    if (dt2.Rows.Count<=3)
                    {
                        string ad = txt_ad.Text + " " + txt_soyad.Text;

                        cmd = new SqlCommand("INSERT INTO avcılar (konum, ad_soyad, veli_tel, ogrenci_no) values (@konum, @ad_soyad, @veli_tel, @ogrenci_no) ", baglanti);
                        baglanti.Open();
                        cmd.Parameters.AddWithValue("konum", adres);
                        cmd.Parameters.AddWithValue("ad_soyad", ad);
                        cmd.Parameters.AddWithValue("veli_tel", txt_veli_tel.Text);
                        cmd.Parameters.AddWithValue("ogrenci_no", txt_ogrenci_no.Text);
                        cmd.ExecuteNonQuery();
                        baglanti.Close();

                        baglanti.Open();
                        cmd = new SqlCommand("INSERT INTO ogrencikayit (ad, soyad, ogrenci_no, veli_ad_soyad, veli_tel,adres) values (@ad, @soyad, @ogrenci_no, @veli_ad_soyad, @veli_tel, @adres) ", baglanti);
                        cmd.Parameters.AddWithValue("ad", txt_ad.Text);
                        cmd.Parameters.AddWithValue("soyad", txt_soyad.Text);
                        cmd.Parameters.AddWithValue("ogrenci_no", txt_ogrenci_no.Text.ToString());
                        cmd.Parameters.AddWithValue("veli_ad_soyad", txt_veli_ad.Text);
                        cmd.Parameters.AddWithValue("veli_tel", txt_veli_tel.Text);
                        cmd.Parameters.AddWithValue("adres", adres);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt işleminiz Başarılı");
                        baglanti.Close();
                    }
                    else
                    {
                        MessageBox.Show("Servis mevcudu dolmuştur");
                    }
                }
            }
        

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            cmd = new SqlCommand("Update ogrencikayit set ad=@ad, soyad=@soyad, veli_ad_soyad=@veli_ad_soyad, veli_tel=@veli_tel,adres=@adres where ogrenci_no=@ogrenci_no", baglanti);
            cmd.Parameters.AddWithValue("ad", txt_ad.Text);
            cmd.Parameters.AddWithValue("soyad", txt_soyad.Text);
            cmd.Parameters.AddWithValue("ogrenci_no", txt_ogrenci_no.Text.ToString());
            cmd.Parameters.AddWithValue("veli_ad_soyad", txt_veli_ad.Text);
            cmd.Parameters.AddWithValue("veli_tel", txt_veli_tel.Text);
            cmd.Parameters.AddWithValue("adres", txt_adres.Text+""+comboBox1.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Başarı İle Gerçekleşti");
         
            string ad = txt_ad.Text + " " + txt_soyad.Text;
            string adres = txt_adres.Text + " " + comboBox1.Text;

            cmd = new SqlCommand("SELECT * FROM beylikduzu where ogrenci_no=@ogrenci_no",baglanti);
            baglanti.Open();
                cmd.Parameters.AddWithValue("ogrenci_no", txt_ogrenci_no.Text.ToString());
                dr = cmd.ExecuteReader();
                string konum = "";
                if (dr.Read())
                {
                    konum = dr["konum"].ToString();
                    dr.Close();
                }
                int deger = string.Compare(comboBox1.Text, konum);
                baglanti.Close();
                if (deger == -1)
                {
                    cmd = new SqlCommand("Update beylikduzu set  veli_tel=@veli_tel, konum=@konum where ogrenci_no=@ogrenci_no ", baglanti);
                    baglanti.Open();
                    cmd.Parameters.AddWithValue("konum", adres);
                    cmd.Parameters.AddWithValue("veli_tel", txt_veli_tel.Text);
                    baglanti.Close();
                }
                if (deger == 1)
                {
                    cmd = new SqlCommand("DELETE from beylikduzu where ogrenci_no=@ogrenci_no ", baglanti);
                    baglanti.Open();
                    cmd.Parameters.AddWithValue("ogrenci_no", txt_ogrenci_no.Text.ToString());
                    cmd.ExecuteNonQuery();
                    baglanti.Close();

                    cmd = new SqlCommand("INSERT INTO avcılar (konum, ad_soyad, veli_tel, ogrenci_no) values (@konum, @ad_soyad, @veli_tel, @ogrenci_no) ", baglanti);
                    baglanti.Open();
                    cmd.Parameters.AddWithValue("konum", adres);
                    cmd.Parameters.AddWithValue("ad_soyad", ad);
                    cmd.Parameters.AddWithValue("veli_tel", txt_veli_tel.Text);
                    cmd.Parameters.AddWithValue("ogrenci_no", txt_ogrenci_no.Text);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();

                    cmd = new SqlCommand("Update ogrencikayit set ad=@ad, soyad=@soyad, veli_ad_soyad=@veli_ad_soyad, veli_tel=@veli_tel,adres=@adres where ogrenci_no=@ogrenci_no", baglanti);
                    baglanti.Open();
                    cmd.Parameters.AddWithValue("ad", txt_ad.Text);
                    cmd.Parameters.AddWithValue("soyad", txt_soyad.Text);
                    cmd.Parameters.AddWithValue("ogrenci_no", txt_ogrenci_no.Text.ToString());
                    cmd.Parameters.AddWithValue("veli_ad_soyad", txt_veli_ad.Text);
                    cmd.Parameters.AddWithValue("veli_tel", txt_veli_tel.Text);
                    cmd.Parameters.AddWithValue("adres", txt_adres.Text+""+comboBox1.Text);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Güncelleme İşlemi Başarı İle Gerçekleşti");
                }
                
                cmd = new SqlCommand("SELECT * FROM avcılar where ogrenci_no=@ogrenci_no", baglanti);
                baglanti.Open();
                cmd.Parameters.AddWithValue("ogrenci_no", txt_ogrenci_no.Text.ToString());
                dr = cmd.ExecuteReader();
                string ogrenci2="";
                if (dr.Read())
                {
                    ogrenci2 = dr["konum"].ToString();
                    dr.Close();
                }
                int deger2 = string.Compare(comboBox1.Text, ogrenci2);
                baglanti.Close();
                if (deger2 == -1)
                {
                    cmd = new SqlCommand("Update avcıar set  veli_tel=@veli_tel, konum=@konum where ogrenci_no=@ogrenci_no ", baglanti);
                    baglanti.Open();
                    cmd.Parameters.AddWithValue("konum", adres);
                    cmd.Parameters.AddWithValue("veli_tel", txt_veli_tel.Text);
                    baglanti.Close();
                }
                if (deger2 == 1)
                {
                    cmd = new SqlCommand("DELETE from avcılar where ogrenci_no=@ogrenci_no ", baglanti);
                    baglanti.Open();
                    cmd.Parameters.AddWithValue("ogrenci_no", txt_ogrenci_no.Text.ToString());
                    cmd.ExecuteNonQuery();
                    baglanti.Close();

                    cmd = new SqlCommand("INSERT INTO beylikduzu (konum, ad_soyad, veli_tel, ogrenci_no) values (@konum, @ad_soyad, @veli_tel, @ogrenci_no) ", baglanti);
                    baglanti.Open();
                    cmd.Parameters.AddWithValue("konum", adres);
                    cmd.Parameters.AddWithValue("ad_soyad", ad);
                    cmd.Parameters.AddWithValue("veli_tel", txt_veli_tel.Text);
                    cmd.Parameters.AddWithValue("ogrenci_no", txt_ogrenci_no.Text);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();

                    cmd = new SqlCommand("Update ogrencikayit set ad=@ad, soyad=@soyad, veli_ad_soyad=@veli_ad_soyad, veli_tel=@veli_tel,adres=@adres where ogrenci_no=@ogrenci_no",baglanti);
                    baglanti.Open();
                    cmd.Parameters.AddWithValue("ad", txt_ad.Text);
                    cmd.Parameters.AddWithValue("soyad", txt_soyad.Text);
                    cmd.Parameters.AddWithValue("ogrenci_no", txt_ogrenci_no.Text.ToString());
                    cmd.Parameters.AddWithValue("veli_ad_soyad", txt_veli_ad.Text);
                    cmd.Parameters.AddWithValue("veli_tel", txt_veli_tel.Text);
                    cmd.Parameters.AddWithValue("adres", txt_adres.Text + "" + comboBox1.Text);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Güncelleme İşlemi Başarı İle Gerçekleşti");
                    
                }

               
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            cmd = new SqlCommand("SELECT * FROM ogrencikayit where ogrenci_no=@ogrenci_no", baglanti);
            cmd.Parameters.AddWithValue("ogrenci_no", txt_ogrenci_no.Text.ToString());
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string ogrenci = dr["ad"].ToString();
                dr.Close();
                if (DialogResult.Yes == MessageBox.Show(ogrenci.ToString()+ " isimli öğrenciyi silmek istediğinize eminmisiniz?",  "UYARI", MessageBoxButtons.YesNo))
                {

                    cmd = new SqlCommand("DELETE from ogrencikayit where ogrenci_no=@ogrenci_no ", baglanti);
                    cmd.Parameters.AddWithValue("ogrenci_no", txt_ogrenci_no.Text.ToString());
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("DELETE from beylikduzu where ogrenci_no=@ogrenci_no ", baglanti);
                    cmd.Parameters.AddWithValue("ogrenci_no", txt_ogrenci_no.Text.ToString());
                    cmd.ExecuteNonQuery();
                    cmd = new SqlCommand("DELETE from avcılar where ogrenci_no=@ogrenci_no ", baglanti);
                    cmd.Parameters.AddWithValue("ogrenci_no", txt_ogrenci_no.Text.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci Silindi");
                }
                else
                {
                    MessageBox.Show("Silme işleminizi iptal ettiniz");
                }
            }
            else
            {
                MessageBox.Show("Öğrenci Bulunamadı");
            }

            baglanti.Close();
           
            
        }

        private void Ogrencikayit_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            cmd = new SqlCommand("SELECT * FROM aracsofor", baglanti);
            baglanti.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["servis_konum"]);
            }
            baglanti.Close();

            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM ogrencikayit  ", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtg_ogrenci.DataSource = ds.Tables[0];
        }

        private void dtg_ogrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            cmd = new SqlCommand("Select * from ogrencikayit where ad like '" + textBox1.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(ds, "ogrencikayit");
            dtg_ogrenci.DataSource = ds.Tables["ogrencikayit"];
            baglanti.Close();
        }
    }
}
