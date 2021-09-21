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
    public partial class ogrencibilgileri : Form
    {
        Baglanti bgl = new Baglanti();
        public ogrencibilgileri()
        {
            InitializeComponent();
        }
        private void ogrencibilgileri_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM avcılar  ",baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtg_avcılar.DataSource = ds.Tables[0];

            SqlDataAdapter dt = new SqlDataAdapter("SELECT *FROM beylikduzu  ", baglanti);
            DataSet dk = new DataSet();
            dt.Fill(dk);
            dtg_beylikduzu.DataSource = dk.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adminpanel git = new Adminpanel();
            git.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
