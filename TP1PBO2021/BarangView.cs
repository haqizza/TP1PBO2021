using System;
using System.Drawing;
using System.Windows.Forms;

namespace TP1PBO2021
{
    public partial class BarangView : UserControl
    {
        private string Nama;
        private string Image;
        private string Jenis;
        private int Harga;
        public string NamaBarang
        {
            get { return Nama; }
            set { Nama = value; }
        }
        public string ImageBarang
        {
            get { return Image; }
            set { Image = value; }
        }
        public string JenisBarang
        {
            get { return Jenis; }
            set { Jenis = value; }
        }
        public int HargaBarang
        {
            get { return Harga; }
            set { Harga = value; }
        }

        public BarangView()
        {
            InitializeComponent();
        }

        public BarangView(string nama, string image, string jenis, int harga)
        {
            InitializeComponent();
            Nama = nama;
            Image = image;
            Jenis = jenis;
            Harga = harga;
        }

        private void BarangView_Load(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;

            pbBarang.ImageLocation = path + "\\"+ Image;
            lblNamaBarang.Text = Nama;
            lblHarga.Text = $"Rp.{Harga}";

            pbBarang.Location = new Point(
                (flpBarang.Size.Width / 2) - (pbBarang.Size.Width / 2),
                pbBarang.Location.Y);
            lblNamaBarang.Location = new Point(
                (flpBarang.Size.Width / 2) - (lblNamaBarang.Width / 2),
                lblNamaBarang.Location.Y);
            lblHarga.Location = new Point(
                (flpBarang.Size.Width / 2) - (lblHarga.Size.Width / 2),
                lblHarga.Location.Y);
            btnBeli.Location = new Point(
                (flpBarang.Size.Width / 2) - (btnBeli.Size.Width / 2),
                btnBeli.Location.Y);
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            MainMenu.pnlDetailBarang.Visible = true;
            MainMenu.flpDetail.Controls.Clear();
            BarangView selectedBarang = new BarangView(Nama, Image, Jenis, Harga);
            MainMenu.flpDetail.Controls.Add(selectedBarang);
        }
    }
}
