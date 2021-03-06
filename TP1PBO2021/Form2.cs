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
        public MainMenu()
        {
            InitializeComponent();
            pbHome.ImageLocation = path + "\\home-solid.png";
            pbLogo.ImageLocation = path + "\\tatsu.png";
            pbWebCatalog.ImageLocation = path + "\\globe-solid.png";
            pbLogout.ImageLocation = path + "\\sign-out-alt-solid.png";
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
            
        }

        private void pbLogout_Click(object sender, EventArgs e)
        {
            lblLogout_Click(sender, e);
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            int indexHarga = cmbHarga.SelectedIndex;
            int[] harga = { 0, 0 };

            switch (indexHarga)
            {
                case 0:
                    harga[0] = 100000;
                    harga[1] = 200000;
                    break;
                case 1:
                    harga[0] = 200000;
                    harga[1] = 500000;
                    break;
                case 2:
                    harga[0] = 500000;
                    harga[1] = 1000000;
                    break;
                default:
                    break;
            }


            
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            pnlKembali.Visible = false;
        }

        private void lblDetailNamaBarang_Click(object sender, EventArgs e)
        {
            lblDetailNamaBarang.Location = new Point(
                pnlDetailBarang.Width / 2 - lblDetailNamaBarang.Size.Width / 2,
                lblDetailNamaBarang.Location.Y);
            pbDetail.Location = new Point(
                pnlDetailBarang.Width / 2 - pbDetail.Size.Width / 2,
                pbDetail.Location.Y);
            lblDetailHarga.Location = new Point(
                pnlDetailBarang.Width / 2 - lblDetailHarga.Size.Width / 2,
                lblDetailHarga.Location.Y);
            btnDetailBeli.Location = new Point(
                pnlDetailBarang.Width / 2 - btnDetailBeli.Size.Width / 2,
                btnDetailBeli.Location.Y);
        }

        private void lblWebCatalog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.tokopedia.com/");
        }

    }
}
