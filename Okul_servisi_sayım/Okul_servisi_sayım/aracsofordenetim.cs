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
    public partial class aracsofordenetim : Form
    {
        public aracsofordenetim()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        SqlCommand cmd;
        SqlDataReader dr;

        private void aracsofordenetim_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM arackontrol  ", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adminpanel git = new Adminpanel();
            this.Hide();
            git.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            cmd = new SqlCommand("TRUNCATE TABLE arackontrol", baglanti);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Tablo Temizlendi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM arackontrol  ", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
