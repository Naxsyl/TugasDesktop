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
    public partial class HitungRerataPercabangan : Form
    {
        public HitungRerataPercabangan()
        {
            InitializeComponent();
        }

        private void tblHitung_Click(object sender, EventArgs e)
        {
            //inisiasi variabel dan type data 
            Double nilai1 = 0.0;
            Double nilai2 = 0.0;
            Double nilai3 = 0.0;
            Double rerata = 0.0;

            //input data dan menyimpan kedalam variabel 
            nilai1 = Double.Parse(txtNilai1.Text);
            nilai2 = Double.Parse(txtNilai2.Text);
            nilai3 = Double.Parse(txtNilai3.Text);

            //menghitung rerata 
            rerata = (nilai1 + nilai2 + nilai3) / 3;

            //menampilkan rerata 
            txtRerata.Text = rerata.ToString("n2");

            //menampilkan pesan keterangan 
            if (rerata > 90)
                txtKeterangan.Text = "Selamat anda berhasil";
            else
                txtKeterangan.Text = "Tetap semangat";
        }

        private void tblClear_Click(object sender, EventArgs e)
        {
            txtNilai1.Text = "";
            txtNilai2.Text = "";
            txtNilai3.Text = "";
            txtRerata.Text = "";
            txtKeterangan.Text = "";
        }

        private void tblClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
