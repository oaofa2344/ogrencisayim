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
    public partial class aracsofor : Form
    {
        public aracsofor()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        
        
        SqlCommand cmd;
        SqlDataReader dr;

        private void button1_Click(object sender, EventArgs e)
        {
            Adminpanel git = new Adminpanel();
            git.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            cmd = new SqlCommand("INSERT INTO aracsofor(sofor_ad,sofor_tc,arac_plaka,servis_konum) VALUES('" + txt_ad.Text + "','" + txt_tc.Text + "','" + txt_plaka.Text + "','"+txt_konum.Text+"')", baglanti);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıt Başarılı");
            baglanti.Close();
            
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            cmd = new SqlCommand("SELECT * FROM aracsofor where arac_plaka=@arac_plaka", baglanti);
            cmd.Parameters.AddWithValue("arac_plaka", txt_plaka.Text);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string arac = dr["arac_plaka"].ToString();
                dr.Close();
                if (DialogResult.Yes == MessageBox.Show(arac.ToString() + " plakalı aracı ve şoförünü silmek istediğinize eminmisiniz?", "UYARI", MessageBoxButtons.YesNo))
                {

                    cmd = new SqlCommand("DELETE from aracsofor where arac_plaka=@arac_plaka ", baglanti);
                    cmd.Parameters.AddWithValue("arac_plaka",txt_plaka.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Silme işlemi başarılı");
                }
                else
                {
                    MessageBox.Show("Silme işleminizi iptal ettiniz");
                }
            }
            else
            {
                MessageBox.Show("Kayıt bulunamadı");
            }

            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            baglanti.Open();
            cmd = new SqlCommand("Update aracsofor set sofor_ad=@sofor_ad, sofor_tc=@sofor_tc, servis_konum=@servis_konum where arac_plaka=@arac_plaka", baglanti);
            cmd.Parameters.AddWithValue("sofor_ad", txt_ad.Text);
            cmd.Parameters.AddWithValue("sofor_tc", txt_tc.Text);
            cmd.Parameters.AddWithValue("arac_plaka", txt_plaka.Text);
            cmd.Parameters.AddWithValue("servis_konum", txt_konum.Text);
            
            cmd.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Başarı İle Gerçekleşti");
        }

        private void aracsofor_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(bgl.Adres);
            SqlDataAdapter da = new SqlDataAdapter("SELECT *FROM aracsofor  ", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtg_aracsofor.DataSource = ds.Tables[0];
        }

      
    }
}
