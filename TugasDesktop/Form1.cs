namespace TugasDesktop
{
    public partial class Form1 : Form
    {
        //inisiasi nama variable dan type data
        Double dblAngka1 = 0.0;
        Double dblAngka2 = 0.0;
        Double dblHasil = 0.0;
        public Form1()
        {
            InitializeComponent();
        }

        private void tblJumlah_Click(object sender, EventArgs e)
        {
            dblAngka1 = Double.Parse(txtAngka1.Text);
            dblAngka2 = Double.Parse(txtAngka2.Text);
            dblHasil = (dblAngka1 + dblAngka2);
            txtHasil.Text = dblHasil.ToString("n2");
        }

        private void tblKurang_Click(object sender, EventArgs e)
        {
            dblAngka1 = Double.Parse(txtAngka1.Text);
            dblAngka2 = Double.Parse(txtAngka2.Text);
            dblHasil = (dblAngka1 - dblAngka2);
            txtHasil.Text = dblHasil.ToString("n2");
        }

        private void tblBagi_Click(object sender, EventArgs e)
        {
            dblAngka1 = Double.Parse(txtAngka1.Text);
            dblAngka2 = Double.Parse(txtAngka2.Text);
            dblHasil = (dblAngka1 / dblAngka2);
            txtHasil.Text = dblHasil.ToString("n2");
        }

        private void tblClear_Click(object sender, EventArgs e)
        {
            txtAngka1.Text = "0";
            txtAngka2.Text = "0";
            txtHasil.Text = "0";
        }
    }
}
