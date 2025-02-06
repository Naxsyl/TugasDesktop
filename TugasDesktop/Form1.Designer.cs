namespace TugasDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtAngka1 = new TextBox();
            txtAngka2 = new TextBox();
            label = new Label();
            txtHasil = new TextBox();
            label2 = new Label();
            tblJumlah = new Button();
            tblKurang = new Button();
            tblBagi = new Button();
            tblClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 82);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Angka 1";
            // 
            // txtAngka1
            // 
            txtAngka1.Location = new Point(335, 82);
            txtAngka1.Name = "txtAngka1";
            txtAngka1.Size = new Size(150, 31);
            txtAngka1.TabIndex = 1;
            // 
            // txtAngka2
            // 
            txtAngka2.Location = new Point(335, 131);
            txtAngka2.Name = "txtAngka2";
            txtAngka2.Size = new Size(150, 31);
            txtAngka2.TabIndex = 3;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(240, 131);
            label.Name = "label";
            label.Size = new Size(78, 25);
            label.TabIndex = 2;
            label.Text = "Angka 2";
            // 
            // txtHasil
            // 
            txtHasil.Enabled = false;
            txtHasil.Location = new Point(335, 179);
            txtHasil.Name = "txtHasil";
            txtHasil.Size = new Size(150, 31);
            txtHasil.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 179);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 4;
            label2.Text = "Hasil";
            // 
            // tblJumlah
            // 
            tblJumlah.Location = new Point(240, 229);
            tblJumlah.Name = "tblJumlah";
            tblJumlah.Size = new Size(44, 34);
            tblJumlah.TabIndex = 6;
            tblJumlah.Text = "+";
            tblJumlah.UseVisualStyleBackColor = true;
            tblJumlah.Click += tblJumlah_Click;
            // 
            // tblKurang
            // 
            tblKurang.Location = new Point(290, 229);
            tblKurang.Name = "tblKurang";
            tblKurang.Size = new Size(44, 34);
            tblKurang.TabIndex = 7;
            tblKurang.Text = "-";
            tblKurang.UseVisualStyleBackColor = true;
            tblKurang.Click += tblKurang_Click;
            // 
            // tblBagi
            // 
            tblBagi.Location = new Point(340, 229);
            tblBagi.Name = "tblBagi";
            tblBagi.Size = new Size(44, 34);
            tblBagi.TabIndex = 8;
            tblBagi.Text = "/";
            tblBagi.UseVisualStyleBackColor = true;
            tblBagi.Click += tblBagi_Click;
            // 
            // tblClear
            // 
            tblClear.Location = new Point(441, 229);
            tblClear.Name = "tblClear";
            tblClear.Size = new Size(44, 34);
            tblClear.TabIndex = 9;
            tblClear.Text = "C";
            tblClear.UseVisualStyleBackColor = true;
            tblClear.Click += tblClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblClear);
            Controls.Add(tblBagi);
            Controls.Add(tblKurang);
            Controls.Add(tblJumlah);
            Controls.Add(txtHasil);
            Controls.Add(label2);
            Controls.Add(txtAngka2);
            Controls.Add(label);
            Controls.Add(txtAngka1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Hitung Angka";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAngka1;
        private TextBox txtAngka2;
        private Label label;
        private TextBox txtHasil;
        private Label label2;
        private Button tblJumlah;
        private Button tblKurang;
        private Button tblBagi;
        private Button tblClear;
    }
}
