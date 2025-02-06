using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasDesktop
{
    public partial class HitungVolume : Form
    {
        public HitungVolume()
        {
            InitializeComponent();
        }

        private void tblHitung_Click(object sender, EventArgs e)
        {
            //inisiasi variabel dan type data
            Double panjang = 0.0;
            Double lebar = 0.0;
            Double tinggi = 0.0;
            Double volume = 0.0;
            //input data dan menyimpan kedalam variabel
            panjang = Double.Parse(txtPanjang.Text);
            lebar = Double.Parse(txtLebar.Text);
            tinggi = Double.Parse(txtTinggi.Text);
            //menghitung volume
            volume = (panjang * lebar * tinggi);
            //menampilkan volume
            txtVolume.Text = volume.ToString("n2");
        }

        private void tblClear_Click(object sender, EventArgs e)
        {
            txtPanjang.Text = "";
            txtLebar.Text = "";
            txtTinggi.Text = "";
            txtVolume.Text = "";
        }

        private void tblClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
