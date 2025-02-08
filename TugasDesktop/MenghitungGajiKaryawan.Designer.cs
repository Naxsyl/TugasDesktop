namespace TugasDesktop
{
    partial class MenghitungGajiKaryawan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtJml_Hari = new TextBox();
            label6 = new Label();
            txtJml_Jam = new TextBox();
            label5 = new Label();
            txtUpah_Lembur = new TextBox();
            label4 = new Label();
            txtUpah_Harian = new TextBox();
            label3 = new Label();
            txtNama = new TextBox();
            label2 = new Label();
            txtNopeg = new TextBox();
            label1 = new Label();
            tblClose = new Button();
            tblClear = new Button();
            tblHitung = new Button();
            groupBox2 = new GroupBox();
            txtJml_Diterima = new TextBox();
            label13 = new Label();
            txtJml_Gaji = new TextBox();
            label7 = new Label();
            txtPotongan = new TextBox();
            label8 = new Label();
            txtJml_Jam_Out = new TextBox();
            label9 = new Label();
            txtJml_Hari_Out = new TextBox();
            label10 = new Label();
            txtNama_Out = new TextBox();
            label11 = new Label();
            txtNopeg_Out = new TextBox();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtJml_Hari);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtJml_Jam);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtUpah_Lembur);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtUpah_Harian);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNama);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNopeg);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(22, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(467, 331);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data Karyawan";
            // 
            // txtJml_Hari
            // 
            txtJml_Hari.Location = new Point(198, 238);
            txtJml_Hari.Name = "txtJml_Hari";
            txtJml_Hari.Size = new Size(227, 31);
            txtJml_Hari.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 241);
            label6.Name = "label6";
            label6.Size = new Size(152, 25);
            label6.TabIndex = 17;
            label6.Text = "Jumlah Hari Kerja ";
            // 
            // txtJml_Jam
            // 
            txtJml_Jam.Location = new Point(198, 284);
            txtJml_Jam.Name = "txtJml_Jam";
            txtJml_Jam.Size = new Size(227, 31);
            txtJml_Jam.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 287);
            label5.Name = "label5";
            label5.Size = new Size(173, 25);
            label5.TabIndex = 15;
            label5.Text = "Jumlah Jam Lembur ";
            // 
            // txtUpah_Lembur
            // 
            txtUpah_Lembur.Location = new Point(198, 190);
            txtUpah_Lembur.Name = "txtUpah_Lembur";
            txtUpah_Lembur.Size = new Size(227, 31);
            txtUpah_Lembur.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 193);
            label4.Name = "label4";
            label4.Size = new Size(189, 25);
            label4.TabIndex = 9;
            label4.Text = "Upah Lembur Per Jam ";
            // 
            // txtUpah_Harian
            // 
            txtUpah_Harian.Location = new Point(198, 138);
            txtUpah_Harian.Name = "txtUpah_Harian";
            txtUpah_Harian.Size = new Size(227, 31);
            txtUpah_Harian.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 138);
            label3.Name = "label3";
            label3.Size = new Size(110, 25);
            label3.TabIndex = 4;
            label3.Text = "Upah Harian";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(198, 90);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(227, 31);
            txtNama.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 90);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 2;
            label2.Text = "Nama Pegawai";
            // 
            // txtNopeg
            // 
            txtNopeg.Location = new Point(198, 40);
            txtNopeg.Name = "txtNopeg";
            txtNopeg.Size = new Size(227, 31);
            txtNopeg.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 40);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "No Pegawai";
            // 
            // tblClose
            // 
            tblClose.Location = new Point(415, 370);
            tblClose.Name = "tblClose";
            tblClose.Size = new Size(74, 34);
            tblClose.TabIndex = 14;
            tblClose.Text = "Close";
            tblClose.UseVisualStyleBackColor = true;
            tblClose.Click += tblClose_Click;
            // 
            // tblClear
            // 
            tblClear.Location = new Point(326, 370);
            tblClear.Name = "tblClear";
            tblClear.Size = new Size(74, 34);
            tblClear.TabIndex = 13;
            tblClear.Text = "Clear";
            tblClear.UseVisualStyleBackColor = true;
            tblClear.Click += tblClear_Click;
            // 
            // tblHitung
            // 
            tblHitung.Location = new Point(30, 370);
            tblHitung.Name = "tblHitung";
            tblHitung.Size = new Size(74, 34);
            tblHitung.TabIndex = 12;
            tblHitung.Text = "Hitung";
            tblHitung.UseVisualStyleBackColor = true;
            tblHitung.Click += tblHitung_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtJml_Diterima);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(txtJml_Gaji);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtPotongan);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtJml_Jam_Out);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtJml_Hari_Out);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtNama_Out);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtNopeg_Out);
            groupBox2.Controls.Add(label12);
            groupBox2.Location = new Point(508, 23);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(467, 381);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hitung Gaji";
            // 
            // txtJml_Diterima
            // 
            txtJml_Diterima.Enabled = false;
            txtJml_Diterima.Location = new Point(198, 337);
            txtJml_Diterima.Name = "txtJml_Diterima";
            txtJml_Diterima.Size = new Size(227, 31);
            txtJml_Diterima.TabIndex = 20;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 340);
            label13.Name = "label13";
            label13.Size = new Size(139, 25);
            label13.TabIndex = 19;
            label13.Text = "Jumlah Diterima";
            // 
            // txtJml_Gaji
            // 
            txtJml_Gaji.Enabled = false;
            txtJml_Gaji.Location = new Point(198, 238);
            txtJml_Gaji.Name = "txtJml_Gaji";
            txtJml_Gaji.Size = new Size(227, 31);
            txtJml_Gaji.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 241);
            label7.Name = "label7";
            label7.Size = new Size(106, 25);
            label7.TabIndex = 17;
            label7.Text = "Jumlah Gaji ";
            // 
            // txtPotongan
            // 
            txtPotongan.Enabled = false;
            txtPotongan.Location = new Point(198, 284);
            txtPotongan.Name = "txtPotongan";
            txtPotongan.Size = new Size(227, 31);
            txtPotongan.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 287);
            label8.Name = "label8";
            label8.Size = new Size(89, 25);
            label8.TabIndex = 15;
            label8.Text = "Potongan";
            // 
            // txtJml_Jam_Out
            // 
            txtJml_Jam_Out.Location = new Point(198, 190);
            txtJml_Jam_Out.Name = "txtJml_Jam_Out";
            txtJml_Jam_Out.Size = new Size(227, 31);
            txtJml_Jam_Out.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 193);
            label9.Name = "label9";
            label9.Size = new Size(173, 25);
            label9.TabIndex = 9;
            label9.Text = "Jumlah Jam Lembur ";
            // 
            // txtJml_Hari_Out
            // 
            txtJml_Hari_Out.Location = new Point(198, 138);
            txtJml_Hari_Out.Name = "txtJml_Hari_Out";
            txtJml_Hari_Out.Size = new Size(227, 31);
            txtJml_Hari_Out.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 138);
            label10.Name = "label10";
            label10.Size = new Size(147, 25);
            label10.TabIndex = 4;
            label10.Text = "Jumlah Hari Kerja";
            // 
            // txtNama_Out
            // 
            txtNama_Out.Location = new Point(198, 90);
            txtNama_Out.Name = "txtNama_Out";
            txtNama_Out.Size = new Size(227, 31);
            txtNama_Out.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(15, 90);
            label11.Name = "label11";
            label11.Size = new Size(128, 25);
            label11.TabIndex = 2;
            label11.Text = "Nama Pegawai";
            // 
            // txtNopeg_Out
            // 
            txtNopeg_Out.Location = new Point(198, 40);
            txtNopeg_Out.Name = "txtNopeg_Out";
            txtNopeg_Out.Size = new Size(227, 31);
            txtNopeg_Out.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 40);
            label12.Name = "label12";
            label12.Size = new Size(105, 25);
            label12.TabIndex = 0;
            label12.Text = "No Pegawai";
            // 
            // MenghitungGajiKaryawan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 504);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(tblClose);
            Controls.Add(tblHitung);
            Controls.Add(tblClear);
            Name = "MenghitungGajiKaryawan";
            Text = "Hitung Gaji Karyawan";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtJml_Hari;
        private Label label6;
        private TextBox txtJml_Jam;
        private Label label5;
        private Button tblClose;
        private TextBox txtUpah_Lembur;
        private Button tblClear;
        private Button tblHitung;
        private Label label4;
        private TextBox txtUpah_Harian;
        private Label label3;
        private TextBox txtNama;
        private Label label2;
        private TextBox txtNopeg;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtJml_Gaji;
        private Label label7;
        private TextBox txtPotongan;
        private Label label8;
        private TextBox txtJml_Jam_Out;
        private Label label9;
        private TextBox txtJml_Hari_Out;
        private Label label10;
        private TextBox txtNama_Out;
        private Label label11;
        private TextBox txtNopeg_Out;
        private Label label12;
        private TextBox txtJml_Diterima;
        private Label label13;
    }
}