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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            mtxtNumara = new MaskedTextBox();
            cbSinif = new ComboBox();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 60);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 94);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 0;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 129);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 0;
            label3.Text = "Numara";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 163);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 0;
            label4.Text = "Sınıf";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(132, 57);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(132, 86);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 1;
            // 
            // mtxtNumara
            // 
            mtxtNumara.Location = new Point(132, 121);
            mtxtNumara.Mask = "00000";
            mtxtNumara.Name = "mtxtNumara";
            mtxtNumara.Size = new Size(100, 23);
            mtxtNumara.TabIndex = 2;
            mtxtNumara.ValidatingType = typeof(int);
            // 
            // cbSinif
            // 
            cbSinif.FormattingEnabled = true;
            cbSinif.Location = new Point(132, 160);
            cbSinif.Name = "cbSinif";
            cbSinif.Size = new Size(100, 23);
            cbSinif.TabIndex = 3;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(199, 231);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "button1";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // FrmYeniOgrenci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 290);
            Controls.Add(btnKaydet);
            Controls.Add(cbSinif);
            Controls.Add(mtxtNumara);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmYeniOgrenci";
            Text = "FrmYeniOgrenci";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private MaskedTextBox mtxtNumara;
        private ComboBox cbSinif;
        private Button btnKaydet;
    }
}