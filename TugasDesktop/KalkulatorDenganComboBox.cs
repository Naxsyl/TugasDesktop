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
    public partial class KalkulatorDenganComboBox : Form
    {
        public KalkulatorDenganComboBox()
        {
            InitializeComponent();
        }

        private void tblHitung_Click(object sender, EventArgs e)
        {
            Double angka1, angka2, hasil;

            if ((txtAngka1.Text == "") || (txtAngka2.Text == ""))
                MessageBox.Show("Angka Kosong");
            else
            {
                if (cbOpsi.SelectedIndex == -1)
                    MessageBox.Show("Operator Tidak Dipilih");
                else if (cbOpsi.SelectedIndex == 0)
                {
                    angka1 = Double.Parse(txtAngka1.Text);
                    angka2 = Double.Parse(txtAngka2.Text);
                    hasil = angka1 + angka2;
                    txtHasil.Text = hasil.ToString();
                }
                else if (cbOpsi.SelectedIndex == 1)
                {
                    angka1 = Double.Parse(txtAngka1.Text);
                    angka2 = Double.Parse(txtAngka2.Text);
                    hasil = angka1 - angka2;
                    txtHasil.Text = hasil.ToString();
                }
                else if (cbOpsi.SelectedIndex == 2)
                {
                    angka1 = Double.Parse(txtAngka1.Text);
                    angka2 = Double.Parse(txtAngka2.Text);
                    hasil = angka1 * angka2;
                    txtHasil.Text = hasil.ToString();
                }
                else if (cbOpsi.SelectedIndex == 3)
                {
                    angka1 = Double.Parse(txtAngka1.Text);
                    angka2 = Double.Parse(txtAngka2.Text);
                    hasil = angka1 / angka2;
                    txtHasil.Text = hasil.ToString();

                }
            }
        }
    }
}
