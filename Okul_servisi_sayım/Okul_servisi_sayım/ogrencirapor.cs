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
    public partial class ogrencirapor : Form
    {
        public ogrencirapor()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        Baglanti bgl = new Baglanti();
        SqlCommand cmd;
        SqlDataReader dr;
        private void ogrencirapor_Load(object sender, EventArgs e)
        {
           
           
        }

          private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            if (radioButton3.Checked == true)
             {
                 if (radioButton1.Checked == true)
                 {
                     
                     cmd = new SqlCommand("insert into devamsizlika  (ogrenci_no, devam,ad_soyad)  VALUES (@ogrenci_no, @devam, @ad_soyad)", baglanti);
                     baglanti.Open();
                     cmd.Parameters.AddWithValue("ogrenci_no", comboBox1.Text.ToString());
                     cmd.Parameters.AddWithValue("devam", radioButton1.Text);
                     cmd.Parameters.AddWithValue("ad_soyad", comboBox2.Text);
                     cmd.ExecuteNonQuery();
                     baglanti.Close();
                     
                 }
                 else
                 {
                     cmd = new SqlCommand("insert into devamsizlika  (ogrenci_no, devam,ad_soyad)  VALUES (@ogrenci_no, @devam,@ad_soyad)", baglanti);
                     baglanti.Open();
                     cmd.Parameters.AddWithValue("ogrenci_no", comboBox1.Text.ToString());
                     cmd.Parameters.AddWithValue("devam", radioButton2.Text);
                     cmd.Parameters.AddWithValue("ad_soyad", comboBox2.Text);
                     cmd.ExecuteNonQuery();
                     baglanti.Close();

                 }
             }

            if (radioButton4.Checked == true)
             {
                 if (radioButton1.Checked == true)
                 {
                     cmd = new SqlCommand("insert into devamsizlikb  (ogrenci_no, devam,ad_soyad)  VALUES (@ogrenci_no, @devam, @ad_soyad)", baglanti);
                     baglanti.Open();
                     cmd.Parameters.AddWithValue("ogrenci_no", comboBox1.Text.ToString());
                     cmd.Parameters.AddWithValue("devam", radioButton1.Text);
                     cmd.Parameters.AddWithValue("ad_soyad", comboBox2.Text);
                     cmd.ExecuteNonQuery();
                     baglanti.Close();

                 }
                 else
                 {
                     cmd = new SqlCommand("insert into devamsizlikb  (ogrenci_no, devam,ad_soyad)  VALUES (@ogrenci_no, @devam,@ad_soyad)", baglanti);
                     baglanti.Open();
                     cmd.Parameters.AddWithValue("ogrenci_no", comboBox1.Text.ToString());
                     cmd.Parameters.AddWithValue("devam", radioButton2.Text);
                     cmd.Parameters.AddWithValue("ad_soyad", comboBox2.Text);
                     cmd.ExecuteNonQuery();
                     baglanti.Close();

                 }
             }
           
           
         }
         SqlCommand cmd2;
         SqlDataReader dr2;
         private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
         {
             SqlConnection baglanti = new SqlConnection(bgl.Adres);
             if (radioButton3.Checked == true)
             {
                 comboBox2.Items.Clear();
                 cmd2 = new SqlCommand("select * from avcılar where ogrenci_no='" + comboBox1.Text + "'", baglanti);
                 baglanti.Open();
                 dr2 = cmd2.ExecuteReader();
                 if (dr2.Read())
                 {
                     comboBox2.Items.Add(dr2["ad_soyad"].ToString());
                 }

                 baglanti.Close();
             }
             if (radioButton4.Checked == true)
             {
                 comboBox2.Items.Clear();

                 cmd2 = new SqlCommand("select * from beylikduzu where ogrenci_no='" + comboBox1.Text + "'", baglanti);
                 baglanti.Open();
                 dr2 = cmd2.ExecuteReader();
                 if (dr2.Read())
                 {
                     comboBox2.Items.Add(dr2["ad_soyad"].ToString());
                 }
             }
             baglanti.Close();
         }

         private void button2_Click(object sender, EventArgs e)
         {
             Kullanicipaneli git = new Kullanicipaneli();
             git.Show();
             this.Hide();
         }

       

         private void radioButton4_CheckedChanged(object sender, EventArgs e)
         {
             SqlConnection baglanti = new SqlConnection(bgl.Adres);
             if (radioButton4.Checked == true)
             {
                 comboBox1.Items.Clear();
                 cmd = new SqlCommand("SELECT * FROM beylikduzu", baglanti);
                 baglanti.Open();
                 dr = cmd.ExecuteReader();
                 while (dr.Read())
                 {
                     comboBox1.Items.Add(dr["ogrenci_no"]);
                 }
                 baglanti.Close();
             }
         }

         private void radioButton3_CheckedChanged(object sender, EventArgs e)
         {
             SqlConnection baglanti = new SqlConnection(bgl.Adres);
             if (radioButton3.Checked == true)
             {
                 comboBox1.Items.Clear();
                 cmd = new SqlCommand("SELECT * FROM avcılar", baglanti);
                 baglanti.Open();
                 dr = cmd.ExecuteReader();
                 while (dr.Read())
                 {
                     comboBox1.Items.Add(dr["ogrenci_no"]);
                 }
                 baglanti.Close();
             }
         }

        
       
    }
}
