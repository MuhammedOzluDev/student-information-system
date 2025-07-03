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

namespace OGRENCİBİLSİSYSTEM
{
    public partial class OgrencıNotlar : Form
    {
        public OgrencıNotlar()
        {
            InitializeComponent();
        }

        SqlConnection baglanti= new SqlConnection("Data Source=MATEBOOK-D16\\SQLEXPRESS01;Initial Catalog=OkulDB;Integrated Security=True");
        public string numara;


        private void OgrencıNotlar_Load(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("Select DERSAD,SINAV1,SINAV2,SINAV3,PROJE, ORTALAMA, DURUM from dbo.NOTLAR INNER JOIN dbo.DERSLER ON dbo.NOTLAR.DERSID=dbo.DERSLER.DERSID where OGRID=@P1", baglanti);
            cmd.Parameters.AddWithValue("@p1", numara);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt= new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("Select OGRAD from dbo.OGRENCILER where OGRID=@p2", baglanti);
            cmd2.Parameters.AddWithValue("@p2", numara);
            SqlDataReader dr = cmd2.ExecuteReader();
            while (dr.Read()) { this.Text = dr[0].ToString(); }
            baglanti.Close();
        }
    }
}
