using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGRENCİBİLSİSYSTEM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string num;

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OgrencıNotlar frm = new OgrencıNotlar();
            frm.numara = textBox1.Text;
            frm.ShowDialog();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmOGRETMENLER frm = new FrmOGRETMENLER();
            frm.Show();
            this.Hide();
        }
    }
}
