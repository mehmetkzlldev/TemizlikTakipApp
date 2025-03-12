namespace TemizlikTakipApp
{
    partial class FrmYeniOgrenci
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
            label1 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            mtxtNumara = new MaskedTextBox();
            cbSinif = new ComboBox();
            btnKaydet = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(47, 34);
            label1.Name = "label1";
            label1.Size = new Size(32, 18);
            label1.TabIndex = 0;
            label1.Text = "Ad :";
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.FromArgb(255, 192, 128);
            txtAd.Location = new Point(117, 33);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(134, 23);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = Color.FromArgb(255, 192, 128);
            txtSoyad.Location = new Point(117, 79);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(134, 23);
            txtSoyad.TabIndex = 1;
            // 
            // mtxtNumara
            // 
            mtxtNumara.BackColor = Color.FromArgb(255, 192, 128);
            mtxtNumara.Location = new Point(117, 117);
            mtxtNumara.Mask = "00000";
            mtxtNumara.Name = "mtxtNumara";
            mtxtNumara.Size = new Size(134, 23);
            mtxtNumara.TabIndex = 2;
            mtxtNumara.ValidatingType = typeof(int);
            // 
            // cbSinif
            // 
            cbSinif.BackColor = Color.FromArgb(255, 192, 128);
            cbSinif.FormattingEnabled = true;
            cbSinif.Location = new Point(117, 166);
            cbSinif.Name = "cbSinif";
            cbSinif.Size = new Size(134, 23);
            cbSinif.TabIndex = 3;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(255, 128, 0);
            btnKaydet.Location = new Point(176, 209);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(txtAd);
            panel1.Controls.Add(btnKaydet);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbSinif);
            panel1.Controls.Add(mtxtNumara);
            panel1.Controls.Add(txtSoyad);
            panel1.Location = new Point(12, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 273);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(33, 79);
            label2.Name = "label2";
            label2.Size = new Size(56, 18);
            label2.TabIndex = 0;
            label2.Text = "Soyad : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(13, 122);
            label3.Name = "label3";
            label3.Size = new Size(76, 18);
            label3.TabIndex = 0;
            label3.Text = "Numarası :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(36, 167);
            label4.Name = "label4";
            label4.Size = new Size(43, 18);
            label4.TabIndex = 0;
            label4.Text = "Sınıf :";
            // 
            // FrmYeniOgrenci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 325);
            Controls.Add(panel1);
            Name = "FrmYeniOgrenci";
            Text = "FrmYeniOgrenci";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private MaskedTextBox mtxtNumara;
        private ComboBox cbSinif;
        private Button btnKaydet;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}