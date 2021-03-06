using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1PBO2021
{
    public partial class MainMenu : Form
    {
        public string path = AppDomain.CurrentDomain.BaseDirectory;
        public bool IsClosed { get; private set; }

        private BarangView[] listBarang = new BarangView[5];
        public MainMenu()
        {
            InitializeComponent();
            pbHome.ImageLocation = path + "\\home-solid.png";
            pbLogo.ImageLocation = path + "\\tatsu.png";
            pbWebCatalog.ImageLocation = path + "\\globe-solid.png";
            pbLogout.ImageLocation = path + "\\sign-out-alt-solid.png";

            addBarang();
            showAllBarangList();
        }

        private void cmbJenisBarang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            pnlKembali.Visible = false;
            pnlDetailBarang.Visible = false;
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            lblHome_Click(sender, e);
        }


        private void pbWebCatalog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tokopedia.com/");
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            IsClosed = true;
            Close();
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            lblLogout_Click(sender, e);
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            flpBarang.Controls.Clear();
            string jenis = cmbJenisBarang.Text;

            string harga = cmbHarga.Text;
            int min = 0;
            int max = 0;

            if (harga.Contains("100rb"))
            {
                min = 100000;
                max = 200000;
            }
            else if (harga.Contains("200rb"))
            {
                min = 200000;
                max = 500000;
            }
            else if (harga.Contains("500rb"))
            {
                min = 500000;
                max = 1000000;
            }
            else
            {
                min = 0;
                max = 10000000;
            }

            foreach (BarangView item in listBarang)
            {
                if (item.JenisBarang.Contains(jenis) &&
                    (item.HargaBarang >= min && item.HargaBarang <= max))
                {
                    flpBarang.Controls.Add(item);
                }
            }
            if(flpBarang.Controls.Count == 0)
            {
                MessageBox.Show("Tidak Ditemukan", "Peringatan");
                showAllBarangList();
            }

            cmbHarga.Text = "Harga";
            cmbJenisBarang.Text = "Jenis Barang";
        }


        private void btnKembali_Click(object sender, EventArgs e)
        {
            pnlKembali.Visible = false;
            pnlDetailBarang.Visible = false;
        }

        private void lblWebCatalog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tokopedia.com/");
        }

        private void addBarang()
        {
            listBarang[0] = new BarangView("Kamera SLR", "barang1.jpg", "Elektronik", 3000000);
            listBarang[1] = new BarangView("Tumbuhan Hijau", "barang2.jpg", "Makanan", 10000);
            listBarang[2] = new BarangView("Tomat", "barang3.jpg", "Makanan", 30000);
            listBarang[3] = new BarangView("Webcam", "barang4.jpg", "Elektronik", 240000);
            listBarang[4] = new BarangView("Baju Kopi", "barang5.jpg", "Baju", 110000);
        }

        private void showAllBarangList()
        {
            flpBarang.Controls.Clear();
            foreach(BarangView item in listBarang)
            {
                flpBarang.Controls.Add(item);
            }
        }

        private void pnlDetailBarang_Paint(object sender, PaintEventArgs e)
        {
            pnlKembali.Visible = true;
        }
    }
}
