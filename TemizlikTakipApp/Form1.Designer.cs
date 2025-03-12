namespace TemizlikTakipApp
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
            cbSinif = new ComboBox();
            lbOgrencıler = new ListBox();
            panel1 = new Panel();
            btnYeniOgrencı = new Button();
            btnYeniSinif = new Button();
            btnOnayla = new Button();
            label1 = new Label();
            btnAta = new Button();
            btnCıkar = new Button();
            panel4 = new Panel();
            lbSeçilenOgrenciler = new ListBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // cbSinif
            // 
            cbSinif.BackColor = SystemColors.InactiveBorder;
            cbSinif.FormattingEnabled = true;
            cbSinif.Location = new Point(3, 14);
            cbSinif.Name = "cbSinif";
            cbSinif.Size = new Size(355, 23);
            cbSinif.TabIndex = 0;
            // 
            // lbOgrencıler
            // 
            lbOgrencıler.BackColor = Color.White;
            lbOgrencıler.FormattingEnabled = true;
            lbOgrencıler.ItemHeight = 15;
            lbOgrencıler.Location = new Point(13, 43);
            lbOgrencıler.Name = "lbOgrencıler";
            lbOgrencıler.Size = new Size(335, 304);
            lbOgrencıler.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnYeniOgrencı);
            panel1.Controls.Add(btnYeniSinif);
            panel1.Controls.Add(cbSinif);
            panel1.Controls.Add(lbOgrencıler);
            panel1.Location = new Point(465, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(361, 420);
            panel1.TabIndex = 2;
            // 
            // btnYeniOgrencı
            // 
            btnYeniOgrencı.BackColor = Color.FromArgb(255, 128, 0);
            btnYeniOgrencı.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYeniOgrencı.Location = new Point(188, 362);
            btnYeniOgrencı.Name = "btnYeniOgrencı";
            btnYeniOgrencı.Size = new Size(173, 26);
            btnYeniOgrencı.TabIndex = 3;
            btnYeniOgrencı.Text = "Yeni Ogrenci  Ekle";
            btnYeniOgrencı.UseVisualStyleBackColor = false;
            btnYeniOgrencı.Click += btnYeniOgrenci_Click;
            // 
            // btnYeniSinif
            // 
            btnYeniSinif.BackColor = Color.FromArgb(255, 128, 0);
            btnYeniSinif.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnYeniSinif.Location = new Point(3, 362);
            btnYeniSinif.Name = "btnYeniSinif";
            btnYeniSinif.Size = new Size(173, 26);
            btnYeniSinif.TabIndex = 3;
            btnYeniSinif.Text = "Yeni Sınıf Ekle";
            btnYeniSinif.UseVisualStyleBackColor = false;
            btnYeniSinif.Click += btnYeniSinif_Click;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.Black;
            btnOnayla.Font = new Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnOnayla.ForeColor = Color.FromArgb(128, 255, 255);
            btnOnayla.Location = new Point(12, 320);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(422, 27);
            btnOnayla.TabIndex = 3;
            btnOnayla.Text = "ONAYLA";
            btnOnayla.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.BackColor = Color.Silver;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(447, 37);
            label1.TabIndex = 1;
            label1.Text = "bu hafta kim temizlik yapcak";
            // 
            // btnAta
            // 
            btnAta.BackColor = Color.Black;
            btnAta.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAta.ForeColor = Color.FromArgb(128, 255, 255);
            btnAta.Location = new Point(12, 357);
            btnAta.Name = "btnAta";
            btnAta.Size = new Size(105, 33);
            btnAta.TabIndex = 1;
            btnAta.Text = "ATA";
            btnAta.UseVisualStyleBackColor = false;
            // 
            // btnCıkar
            // 
            btnCıkar.BackColor = Color.Black;
            btnCıkar.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCıkar.ForeColor = Color.FromArgb(128, 255, 255);
            btnCıkar.Location = new Point(329, 357);
            btnCıkar.Name = "btnCıkar";
            btnCıkar.Size = new Size(105, 33);
            btnCıkar.TabIndex = 1;
            btnCıkar.Text = "ÇIKAR";
            btnCıkar.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(lbSeçilenOgrenciler);
            panel4.Controls.Add(btnOnayla);
            panel4.Controls.Add(btnCıkar);
            panel4.Controls.Add(btnAta);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(447, 420);
            panel4.TabIndex = 4;
            // 
            // lbSeçilenOgrenciler
            // 
            lbSeçilenOgrenciler.FormattingEnabled = true;
            lbSeçilenOgrenciler.ItemHeight = 15;
            lbSeçilenOgrenciler.Location = new Point(34, 33);
            lbSeçilenOgrenciler.Name = "lbSeçilenOgrenciler";
            lbSeçilenOgrenciler.Size = new Size(383, 274);
            lbSeçilenOgrenciler.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(825, 431);
            Controls.Add(panel4);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Temizlik Takip App";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbSinif;
        private ListBox lbOgrencıler;
        private Panel panel1;
        private Button btnYeniSinif;
        private Button btnAta;
        private Button btnCıkar;
        private Label label1;
        private Button btnOnayla;
        private Button btnYeniOgrencı;
        private Panel panel4;
        private ListBox lbSeçilenOgrenciler;
    }
}