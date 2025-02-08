namespace TugasDesktop
{
    partial class KalkulatorDenganComboBox
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
            txtAngka1 = new TextBox();
            cbOpsi = new ComboBox();
            txtAngka2 = new TextBox();
            label1 = new Label();
            txtHasil = new TextBox();
            tblHitung = new Button();
            SuspendLayout();
            // 
            // txtAngka1
            // 
            txtAngka1.Location = new Point(50, 46);
            txtAngka1.Name = "txtAngka1";
            txtAngka1.Size = new Size(150, 31);
            txtAngka1.TabIndex = 0;
            // 
            // cbOpsi
            // 
            cbOpsi.FormattingEnabled = true;
            cbOpsi.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOpsi.Location = new Point(206, 44);
            cbOpsi.Name = "cbOpsi";
            cbOpsi.Size = new Size(46, 33);
            cbOpsi.TabIndex = 1;
            // 
            // txtAngka2
            // 
            txtAngka2.Location = new Point(258, 46);
            txtAngka2.Name = "txtAngka2";
            txtAngka2.Size = new Size(150, 31);
            txtAngka2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(414, 49);
            label1.Name = "label1";
            label1.Size = new Size(24, 25);
            label1.TabIndex = 3;
            label1.Text = "=";
            // 
            // txtHasil
            // 
            txtHasil.Enabled = false;
            txtHasil.Location = new Point(444, 46);
            txtHasil.Name = "txtHasil";
            txtHasil.Size = new Size(150, 31);
            txtHasil.TabIndex = 4;
            // 
            // tblHitung
            // 
            tblHitung.Location = new Point(641, 43);
            tblHitung.Name = "tblHitung";
            tblHitung.Size = new Size(88, 34);
            tblHitung.TabIndex = 13;
            tblHitung.Text = "Hitung";
            tblHitung.UseVisualStyleBackColor = true;
            tblHitung.Click += tblHitung_Click;
            // 
            // KalkulatorDenganComboBox
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 115);
            Controls.Add(tblHitung);
            Controls.Add(txtHasil);
            Controls.Add(label1);
            Controls.Add(txtAngka2);
            Controls.Add(cbOpsi);
            Controls.Add(txtAngka1);
            Name = "KalkulatorDenganComboBox";
            Text = "Calculator dengan ComboBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAngka1;
        private ComboBox cbOpsi;
        private TextBox txtAngka2;
        private Label label1;
        private TextBox txtHasil;
        private Button tblHitung;
    }
}