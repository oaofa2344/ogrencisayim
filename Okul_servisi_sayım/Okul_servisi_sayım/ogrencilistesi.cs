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
    public partial class ogrencilistesi : Form
    {
        public ogrencilistesi()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        SqlCommand cmd;
        SqlDataReader dr;

        private void Öğrencilistesi_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adminpanel git = new Adminpanel();
            git.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            cmd = new SqlCommand("TRUNCATE TABLE devamsizlika", baglanti);
            baglanti.Open(); 
            cmd.ExecuteNonQuery();
            baglanti.Close();

            cmd = new SqlCommand("TRUNCATE TABLE devamsizlikb", baglanti);
            baglanti.Open();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Tablo Temizlendi");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM devamsizlika  ", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            SqlDataAdapter db = new SqlDataAdapter("SELECT *FROM devamsizlikb  ", baglanti);
            DataSet dt = new DataSet();
            db.Fill(dt);
            dataGridView2.DataSource = dt.Tables[0];
        }
    }
}
