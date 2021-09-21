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
    public partial class aracsoforrapor : Form
    {
        public aracsoforrapor()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        SqlCommand cmd;
        SqlDataReader dr;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kullanicipaneli git = new Kullanicipaneli();
            this.Hide();
            git.Show();
        }
        SqlCommand cmd2;
        SqlDataReader dr2;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            cmd2 = new SqlCommand("select * from aracsofor where sofor_ad='" + comboBox1.Text + "'", baglanti);
            baglanti.Open();
            dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {
                comboBox2.Items.Add(dr2["arac_plaka"].ToString());

            }

            baglanti.Close();
        }

        private void aracsoforrapor_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            cmd = new SqlCommand("SELECT * FROM aracsofor", baglanti);
            baglanti.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["sofor_ad"]);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                cmd = new SqlCommand("insert into arackontrol  (sofor_ad, arac_plaka,denetim)  VALUES (@sofor_ad, @arac_plaka,@denetim)", baglanti);
                baglanti.Open();
                cmd.Parameters.AddWithValue("sofor_ad", comboBox1.Text);
                cmd.Parameters.AddWithValue("denetim", radioButton1.Text);
                cmd.Parameters.AddWithValue("arac_plaka", comboBox2.Text.ToString());
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("İşlem Başarılı");

            }
            else
            {
                SqlConnection baglanti = new SqlConnection(bgl.Adres);
                cmd = new SqlCommand("insert into arackontrol  (sofor_ad, arac_plaka,denetim)  VALUES (@sofor_ad, @arac_plaka,@denetim)", baglanti);
                baglanti.Open();
                cmd.Parameters.AddWithValue("sofor_ad", comboBox1.Text);
                cmd.Parameters.AddWithValue("denetim", radioButton2.Text);
                cmd.Parameters.AddWithValue("arac_plaka", comboBox2.Text.ToString());
                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("İşlem Başarılı");

            }
        }
    }
}
