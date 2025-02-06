namespace TugasDesktop
{
    partial class HitungVolume
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
            tblClose = new Button();
            tblClear = new Button();
            tblHitung = new Button();
            txtVolume = new TextBox();
            label4 = new Label();
            txtTinggi = new TextBox();
            label3 = new Label();
            txtLebar = new TextBox();
            label2 = new Label();
            txtPanjang = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(tblClose);
            groupBox1.Controls.Add(tblClear);
            groupBox1.Controls.Add(tblHitung);
            groupBox1.Controls.Add(txtVolume);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtTinggi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtLebar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtPanjang);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(208, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 296);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menghitung Volume Balok";
            // 
            // tblClose
            // 
            tblClose.Location = new Point(201, 238);
            tblClose.Name = "tblClose";
            tblClose.Size = new Size(74, 34);
            tblClose.TabIndex = 11;
            tblClose.Text = "Close";
            tblClose.UseVisualStyleBackColor = true;
            tblClose.Click += tblClose_Click;
            // 
            // tblClear
            // 
            tblClear.Location = new Point(112, 238);
            tblClear.Name = "tblClear";
            tblClear.Size = new Size(74, 34);
            tblClear.TabIndex = 10;
            tblClear.Text = "Clear";
            tblClear.UseVisualStyleBackColor = true;
            tblClear.Click += tblClear_Click;
            // 
            // tblHitung
            // 
            tblHitung.Location = new Point(21, 238);
            tblHitung.Name = "tblHitung";
            tblHitung.Size = new Size(74, 34);
            tblHitung.TabIndex = 9;
            tblHitung.Text = "Hitung";
            tblHitung.UseVisualStyleBackColor = true;
            tblHitung.Click += tblHitung_Click;
            // 
            // txtVolume
            // 
            txtVolume.Enabled = false;
            txtVolume.Location = new Point(101, 179);
            txtVolume.Name = "txtVolume";
            txtVolume.Size = new Size(192, 31);
            txtVolume.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 185);
            label4.Name = "label4";
            label4.Size = new Size(72, 25);
            label4.TabIndex = 7;
            label4.Text = "Volume";
            // 
            // txtTinggi
            // 
            txtTinggi.Location = new Point(101, 131);
            txtTinggi.Name = "txtTinggi";
            txtTinggi.Size = new Size(192, 31);
            txtTinggi.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 137);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 5;
            label3.Text = "Tinggi";
            // 
            // txtLebar
            // 
            txtLebar.Location = new Point(101, 83);
            txtLebar.Name = "txtLebar";
            txtLebar.Size = new Size(192, 31);
            txtLebar.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 89);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 3;
            label2.Text = "Lebar";
            // 
            // txtPanjang
            // 
            txtPanjang.Location = new Point(101, 36);
            txtPanjang.Name = "txtPanjang";
            txtPanjang.Size = new Size(192, 31);
            txtPanjang.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 36);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 1;
            label1.Text = "Panjang";
            // 
            // HitungVolume
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "HitungVolume";
            Text = "Hitung Volume";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtPanjang;
        private TextBox txtVolume;
        private Label label4;
        private TextBox txtTinggi;
        private Label label3;
        private TextBox txtLebar;
        private Label label2;
        private Button tblClose;
        private Button tblClear;
        private Button tblHitung;
    }
}