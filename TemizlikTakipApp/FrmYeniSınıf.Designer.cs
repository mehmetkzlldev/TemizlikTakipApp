namespace TemizlikTakipApp
{
    partial class FrmYeniSınıf
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
            btnKaydet = new Button();
            label1 = new Label();
            txtSinifAd = new TextBox();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(128, 255, 128);
            btnKaydet.Location = new Point(109, 58);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(148, 28);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 31);
            label1.Name = "label1";
            label1.Size = new Size(73, 16);
            label1.TabIndex = 1;
            label1.Text = "Yenı sınıf";
            // 
            // txtSinifAd
            // 
            txtSinifAd.BackColor = Color.FromArgb(255, 128, 128);
            txtSinifAd.Location = new Point(109, 31);
            txtSinifAd.Name = "txtSinifAd";
            txtSinifAd.Size = new Size(148, 23);
            txtSinifAd.TabIndex = 2;
            // 
            // FrmYeniSınıf
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(306, 157);
            Controls.Add(txtSinifAd);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Name = "FrmYeniSınıf";
            Text = "FrmYeniSınıf";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private Label label1;
        private TextBox txtSinifAd;
    }
}