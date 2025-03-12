using TemizlikTakipApp;

namespace TemizlikTakipApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Ýlk açýlýþta verileri yükle 
            KayitYoneticisi.Yukle();

            cbSinif.DisplayMember = "Ad";
            cbSinif.ValueMember = "Id";
            cbSinif.DataSource = KayitYoneticisi.Siniflar;

            lbOgrencıler.DisplayMember = "AdSoyad";
            lbOgrencıler.ValueMember = "Id";
            lbOgrencıler.DataSource = KayitYoneticisi.Ogrenciler;

            Filtrele();
        }

        private void btnYeniSinif_Click(object sender, EventArgs e)
        {
            FrmYeniSınıf form = new();
            var cevap = form.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                MessageBox.Show("Yeni Sýnýf kayýt edildi.");
            }
        }

        private void btnYeniOgrenci_Click(object sender, EventArgs e)
        {
            FrmYeniSınıf form = new();
            var cevap = form.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                Filtrele();
            }
        }

        private void Filtrele()
        {
            if (cbSinif.SelectedValue == null)
            {
                //Sýnýf seçili deðilse
                lbOgrencıler.DataSource = null;
                return;
            }

            //Sýnýf seçili
            string sinifId = cbSinif.SelectedValue.ToString();

            //LINQ ile sorgulama
            //Lambda x => x.....
            var liste = KayitYoneticisi.
                Ogrenciler.Where(x => x.SinifId == sinifId).ToList();

            lbOgrencıler.DisplayMember = "AdSoyad";
            lbOgrencıler.ValueMember = "Id";
            lbOgrencıler.DataSource = liste;
        }

        private void cbSinif_SelectedValueChanged(object sender, EventArgs e)
        {
            Filtrele();
        }
    }
}