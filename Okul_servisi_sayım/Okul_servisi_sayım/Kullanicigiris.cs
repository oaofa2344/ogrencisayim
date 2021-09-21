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
    public partial class Kullanıcıgiriscs : Form
    {
        public Kullanıcıgiriscs()
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
            cmd = new SqlCommand("SELECT * FROM Kayitol where kullanici_adi='" + textBox1.Text + "'and sifre='" + textBox2.Text + "'", baglanti);
            baglanti.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Kullanicipaneli git = new Kullanicipaneli();
                git.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatatalı şifre yada kullanıcı adı");
            }
            baglanti.Close();

            cmd = new SqlCommand("INSERT INTO kullanici (kullanici_adi) values (@kullanici_adi) ", baglanti);
            baglanti.Open();
            cmd.Parameters.AddWithValue("kullanici_adi", textBox1.Text);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void Kullanıcıgiriscs_Load(object sender, EventArgs e)
        {

        }
    }
}
