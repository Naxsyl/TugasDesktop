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
    public partial class MenghitungGajiKaryawan : Form
    {
        public MenghitungGajiKaryawan()
        {
            InitializeComponent();
        }

        private void tblHitung_Click(object sender, EventArgs e)
        {
            //inisiasi variabel dan type data

            Double upah_harian, upah_lembur, total_gaji, potongan, jml_diterima;
            int jml_hari, jml_jam;
            //input data
            upah_harian = Double.Parse(txtUpah_Harian.Text);
            upah_lembur = Double.Parse(txtUpah_Lembur.Text);
            jml_hari = int.Parse(txtJml_Hari.Text);
            jml_jam = int.Parse(txtJml_Jam.Text);
            //menghitung gaji
            total_gaji = (upah_harian * jml_hari) + (upah_lembur * jml_jam);
            potongan = total_gaji * 0.25;
            jml_diterima = total_gaji - potongan;

            //menampilkan data
            txtNopeg_Out.Text = txtNopeg.Text;
            txtNama_Out.Text = txtNama.Text;
            txtJml_Hari_Out.Text = txtJml_Hari.Text;
            txtJml_Jam_Out.Text = txtJml_Jam.Text;
            txtJml_Gaji.Text = total_gaji.ToString("n0");
            txtPotongan.Text = potongan.ToString("n0");
            txtJml_Diterima.Text = jml_diterima.ToString("n0");
        }

        private void tblClear_Click(object sender, EventArgs e)
        {
            txtNopeg.Text = "";
            txtNopeg_Out.Text = "";
            txtNama.Text = "";
            txtNama_Out.Text = "";
            txtUpah_Harian.Text = "";
            txtUpah_Lembur.Text = "";
            txtJml_Hari.Text = "";
            txtJml_Jam.Text = "";
            txtJml_Hari_Out.Text = "";
            txtJml_Jam_Out.Text = "";
            txtJml_Gaji.Text = "";
            txtPotongan.Text = "";
            txtJml_Diterima.Text = "";
        }

        private void tblClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
