using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices.ActiveDirectory;
using System.Data.SqlClient;

namespace Okul_servisi_sayım
{
    public partial class ceaziislemler : Form
    {
        public ceaziislemler()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adminpanel git = new Adminpanel();
            git.Show();
            this.Hide();
        }
        Bitmap bmp;
        Baglanti bgl = new Baglanti();
        SqlCommand cmd;
        SqlDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
           
        }



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 40, 40, 700, 700);
        }
        private void ceaziislemler_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            cmd = new SqlCommand("select sofor_ad from aracsofor ", baglanti);
            baglanti.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["sofor_ad"].ToString());
            }

            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            comboBox2.Items.Clear();
            cmd = new SqlCommand("select arac_plaka from aracsofor where sofor_ad='" + comboBox1.Text + "'", baglanti);
            baglanti.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["arac_plaka"].ToString());
            }

            baglanti.Close();
        }

       

    }
}

