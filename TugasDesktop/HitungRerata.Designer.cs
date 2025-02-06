namespace TugasDesktop
{
    partial class HitungRerata
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
            txtRerata = new TextBox();
            tblClear = new Button();
            tblHitung = new Button();
            label4 = new Label();
            txtNilai3 = new TextBox();
            label3 = new Label();
            txtNilai2 = new TextBox();
            label2 = new Label();
            txtNilai1 = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tblClose);
            groupBox1.Controls.Add(txtRerata);
            groupBox1.Controls.Add(tblClear);
            groupBox1.Controls.Add(tblHitung);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNilai3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNilai2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNilai1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(172, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(411, 320);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menghitung Nilai Rerata";
            // 
            // tblClose
            // 
            tblClose.Location = new Point(254, 260);
            tblClose.Name = "tblClose";
            tblClose.Size = new Size(74, 34);
            tblClose.TabIndex = 14;
            tblClose.Text = "Close";
            tblClose.UseVisualStyleBackColor = true;
            tblClose.Click += tblClose_Click;
            // 
            // txtRerata
            // 
            txtRerata.Enabled = false;
            txtRerata.Location = new Point(165, 190);
            txtRerata.Name = "txtRerata";
            txtRerata.Size = new Size(199, 31);
            txtRerata.TabIndex = 10;
            // 
            // tblClear
            // 
            tblClear.Location = new Point(165, 260);
            tblClear.Name = "tblClear";
            tblClear.Size = new Size(74, 34);
            tblClear.TabIndex = 13;
            tblClear.Text = "Clear";
            tblClear.UseVisualStyleBackColor = true;
            tblClear.Click += tblClear_Click;
            // 
            // tblHitung
            // 
            tblHitung.Location = new Point(74, 260);
            tblHitung.Name = "tblHitung";
            tblHitung.Size = new Size(74, 34);
            tblHitung.TabIndex = 12;
            tblHitung.Text = "Hitung";
            tblHitung.UseVisualStyleBackColor = true;
            tblHitung.Click += tblHitung_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 193);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 9;
            label4.Text = "Rerata";
            // 
            // txtNilai3
            // 
            txtNilai3.Location = new Point(165, 138);
            txtNilai3.Name = "txtNilai3";
            txtNilai3.Size = new Size(199, 31);
            txtNilai3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 138);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 4;
            label3.Text = "Nilai Agama";
            // 
            // txtNilai2
            // 
            txtNilai2.Location = new Point(165, 90);
            txtNilai2.Name = "txtNilai2";
            txtNilai2.Size = new Size(199, 31);
            txtNilai2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 90);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 2;
            label2.Text = "Nilai Bahasa";
            // 
            // txtNilai1
            // 
            txtNilai1.Location = new Point(165, 40);
            txtNilai1.Name = "txtNilai1";
            txtNilai1.Size = new Size(199, 31);
            txtNilai1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 40);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 0;
            label1.Text = "Nilai Matematika";
            // 
            // HitungRerata
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "HitungRerata";
            Text = "Hitung Rerata";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNilai2;
        private Label label2;
        private TextBox txtNilai1;
        private Label label1;
        private TextBox txtNilai3;
        private Label label3;
        private TextBox txtRerata;
        private Label label4;
        private Button tblClose;
        private Button tblClear;
        private Button tblHitung;
    }
}