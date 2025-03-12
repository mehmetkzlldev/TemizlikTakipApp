namespace TemizlikTakipApp
{
    partial class OgrenciEkle
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtSinif = new TextBox();
            txtNumara = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(txtNumara);
            panel1.Controls.Add(txtSinif);
            panel1.Controls.Add(txtSoyad);
            panel1.Controls.Add(txtAd);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 203);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(9, 10);
            label1.Name = "label1";
            label1.Size = new Size(188, 18);
            label1.TabIndex = 0;
            label1.Text = "ÖGRENCİ BİLGİLERİ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 192);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(31, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 38);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(17, 63);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 2;
            label2.Text = "Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 95);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 2;
            label3.Text = "Soyadı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 126);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 2;
            label4.Text = "Sinif :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 162);
            label5.Name = "label5";
            label5.Size = new Size(65, 17);
            label5.TabIndex = 2;
            label5.Text = "Numara :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(88, 63);
            txtAd.Multiline = true;
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(156, 19);
            txtAd.TabIndex = 3;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(88, 95);
            txtSoyad.Multiline = true;
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(156, 19);
            txtSoyad.TabIndex = 3;
            // 
            // txtSinif
            // 
            txtSinif.Location = new Point(88, 126);
            txtSinif.Multiline = true;
            txtSinif.Name = "txtSinif";
            txtSinif.Size = new Size(156, 19);
            txtSinif.TabIndex = 3;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(88, 162);
            txtNumara.Multiline = true;
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(156, 19);
            txtNumara.TabIndex = 3;
            // 
            // OgrenciEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 235);
            Controls.Add(panel1);
            Name = "OgrenciEkle";
            Text = "OgrenciEkle";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private TextBox txtNumara;
        private TextBox txtSinif;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}