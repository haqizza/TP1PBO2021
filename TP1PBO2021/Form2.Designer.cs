
namespace TP1PBO2021
{
    partial class MainMenu
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
            this.pnlCari = new System.Windows.Forms.Panel();
            this.btnCari = new System.Windows.Forms.Button();
            this.cmbHarga = new System.Windows.Forms.ComboBox();
            this.cmbJenisBarang = new System.Windows.Forms.ComboBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlDetailBarang = new System.Windows.Forms.Panel();
            this.panelBarang = new System.Windows.Forms.Panel();
            this.flpBarang1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBarang = new System.Windows.Forms.Label();
            this.btnDetailBeli = new System.Windows.Forms.Button();
            this.lblDetailHarga = new System.Windows.Forms.Label();
            this.lblDetailNamaBarang = new System.Windows.Forms.Label();
            this.pbDetail = new System.Windows.Forms.PictureBox();
            this.lblDetailBarang = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.Label();
            this.lblHome = new System.Windows.Forms.Label();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWebCatalog = new System.Windows.Forms.LinkLabel();
            this.pnlDataDiri = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.pbWebCatalog = new System.Windows.Forms.PictureBox();
            this.pnlKembali = new System.Windows.Forms.Panel();
            this.btnKembali = new System.Windows.Forms.Button();
            this.pnlCari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlDetailBarang.SuspendLayout();
            this.panelBarang.SuspendLayout();
            this.flpBarang1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlDataDiri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebCatalog)).BeginInit();
            this.pnlKembali.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCari
            // 
            this.pnlCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCari.Controls.Add(this.btnCari);
            this.pnlCari.Controls.Add(this.cmbHarga);
            this.pnlCari.Controls.Add(this.cmbJenisBarang);
            this.pnlCari.Location = new System.Drawing.Point(-1, 62);
            this.pnlCari.Name = "pnlCari";
            this.pnlCari.Size = new System.Drawing.Size(150, 395);
            this.pnlCari.TabIndex = 1;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(14, 120);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(121, 23);
            this.btnCari.TabIndex = 5;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // cmbHarga
            // 
            this.cmbHarga.FormattingEnabled = true;
            this.cmbHarga.Items.AddRange(new object[] {
            "100rb - 200rb",
            "200rb - 500rb",
            "500rb - 1jt"});
            this.cmbHarga.Location = new System.Drawing.Point(14, 74);
            this.cmbHarga.Name = "cmbHarga";
            this.cmbHarga.Size = new System.Drawing.Size(121, 21);
            this.cmbHarga.TabIndex = 4;
            this.cmbHarga.Text = "Harga";
            // 
            // cmbJenisBarang
            // 
            this.cmbJenisBarang.Items.AddRange(new object[] {
            "Elektronik",
            "Baju",
            "Makanan"});
            this.cmbJenisBarang.Location = new System.Drawing.Point(14, 32);
            this.cmbJenisBarang.Name = "cmbJenisBarang";
            this.cmbJenisBarang.Size = new System.Drawing.Size(121, 21);
            this.cmbJenisBarang.TabIndex = 3;
            this.cmbJenisBarang.Text = "Jenis Barang";
            this.cmbJenisBarang.SelectedIndexChanged += new System.EventHandler(this.cmbJenisBarang_SelectedIndexChanged);
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLogo.ImageLocation = "";
            this.pbLogo.Location = new System.Drawing.Point(13, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(121, 44);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // pnlDetailBarang
            // 
            this.pnlDetailBarang.Controls.Add(this.panelBarang);
            this.pnlDetailBarang.Controls.Add(this.btnDetailBeli);
            this.pnlDetailBarang.Controls.Add(this.lblDetailHarga);
            this.pnlDetailBarang.Controls.Add(this.lblDetailNamaBarang);
            this.pnlDetailBarang.Controls.Add(this.pbDetail);
            this.pnlDetailBarang.Controls.Add(this.lblDetailBarang);
            this.pnlDetailBarang.Location = new System.Drawing.Point(155, 80);
            this.pnlDetailBarang.Name = "pnlDetailBarang";
            this.pnlDetailBarang.Size = new System.Drawing.Size(647, 369);
            this.pnlDetailBarang.TabIndex = 2;
            // 
            // panelBarang
            // 
            this.panelBarang.Controls.Add(this.flpBarang1);
            this.panelBarang.Controls.Add(this.lblBarang);
            this.panelBarang.Location = new System.Drawing.Point(0, 0);
            this.panelBarang.Name = "panelBarang";
            this.panelBarang.Size = new System.Drawing.Size(647, 369);
            this.panelBarang.TabIndex = 5;
            // 
            // flpBarang1
            // 
            this.flpBarang1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flpBarang1.Controls.Add(this.pictureBox1);
            this.flpBarang1.Controls.Add(this.label3);
            this.flpBarang1.Controls.Add(this.label2);
            this.flpBarang1.Controls.Add(this.button1);
            this.flpBarang1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpBarang1.Location = new System.Drawing.Point(22, 67);
            this.flpBarang1.Name = "flpBarang1";
            this.flpBarang1.Size = new System.Drawing.Size(109, 206);
            this.flpBarang1.TabIndex = 5;
            this.flpBarang1.WrapContents = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.flpBarang1.SetFlowBreak(this.label3, true);
            this.label3.Location = new System.Drawing.Point(18, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Barang";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 101);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rp.100000";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(16, 158);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Beli";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblBarang
            // 
            this.lblBarang.AutoSize = true;
            this.lblBarang.Location = new System.Drawing.Point(19, 18);
            this.lblBarang.Name = "lblBarang";
            this.lblBarang.Size = new System.Drawing.Size(80, 13);
            this.lblBarang.TabIndex = 0;
            this.lblBarang.Text = "Semua Barang:";
            // 
            // btnDetailBeli
            // 
            this.btnDetailBeli.Location = new System.Drawing.Point(285, 233);
            this.btnDetailBeli.Name = "btnDetailBeli";
            this.btnDetailBeli.Size = new System.Drawing.Size(75, 23);
            this.btnDetailBeli.TabIndex = 4;
            this.btnDetailBeli.Text = "Beli";
            this.btnDetailBeli.UseVisualStyleBackColor = true;
            // 
            // lblDetailHarga
            // 
            this.lblDetailHarga.AutoSize = true;
            this.lblDetailHarga.Location = new System.Drawing.Point(290, 206);
            this.lblDetailHarga.Name = "lblDetailHarga";
            this.lblDetailHarga.Size = new System.Drawing.Size(60, 13);
            this.lblDetailHarga.TabIndex = 3;
            this.lblDetailHarga.Text = "Rp.100000";
            this.lblDetailHarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDetailNamaBarang
            // 
            this.lblDetailNamaBarang.AutoSize = true;
            this.lblDetailNamaBarang.Location = new System.Drawing.Point(287, 178);
            this.lblDetailNamaBarang.Name = "lblDetailNamaBarang";
            this.lblDetailNamaBarang.Size = new System.Drawing.Size(72, 13);
            this.lblDetailNamaBarang.TabIndex = 2;
            this.lblDetailNamaBarang.Text = "Nama Barang";
            this.lblDetailNamaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDetailNamaBarang.Click += new System.EventHandler(this.lblDetailNamaBarang_Click);
            // 
            // pbDetail
            // 
            this.pbDetail.Location = new System.Drawing.Point(260, 49);
            this.pbDetail.Name = "pbDetail";
            this.pbDetail.Size = new System.Drawing.Size(122, 122);
            this.pbDetail.TabIndex = 1;
            this.pbDetail.TabStop = false;
            // 
            // lblDetailBarang
            // 
            this.lblDetailBarang.AutoSize = true;
            this.lblDetailBarang.Location = new System.Drawing.Point(19, 18);
            this.lblDetailBarang.Name = "lblDetailBarang";
            this.lblDetailBarang.Size = new System.Drawing.Size(77, 13);
            this.lblDetailBarang.TabIndex = 0;
            this.lblDetailBarang.Text = "Detail Barang :";
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.Location = new System.Drawing.Point(503, 26);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(59, 20);
            this.lblLogout.TabIndex = 3;
            this.lblLogout.Text = "Logout";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(174, 26);
            this.lblHome.Margin = new System.Windows.Forms.Padding(0);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(52, 20);
            this.lblHome.TabIndex = 1;
            this.lblHome.Text = "Home";
            this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // pbHome
            // 
            this.pbHome.ImageLocation = "";
            this.pbHome.Location = new System.Drawing.Point(156, 26);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(20, 20);
            this.pbHome.TabIndex = 0;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlHeader.Controls.Add(this.lblWebCatalog);
            this.pnlHeader.Controls.Add(this.pnlDataDiri);
            this.pnlHeader.Controls.Add(this.pbLogo);
            this.pnlHeader.Controls.Add(this.pbLogout);
            this.pnlHeader.Controls.Add(this.pbWebCatalog);
            this.pnlHeader.Controls.Add(this.lblLogout);
            this.pnlHeader.Controls.Add(this.lblHome);
            this.pnlHeader.Controls.Add(this.pbHome);
            this.pnlHeader.Location = new System.Drawing.Point(-3, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(803, 74);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblWebCatalog
            // 
            this.lblWebCatalog.AutoSize = true;
            this.lblWebCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWebCatalog.LinkColor = System.Drawing.Color.Black;
            this.lblWebCatalog.Location = new System.Drawing.Point(318, 26);
            this.lblWebCatalog.Name = "lblWebCatalog";
            this.lblWebCatalog.Size = new System.Drawing.Size(101, 20);
            this.lblWebCatalog.TabIndex = 7;
            this.lblWebCatalog.TabStop = true;
            this.lblWebCatalog.Text = "Web Catalog";
            this.lblWebCatalog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblWebCatalog_LinkClicked);
            // 
            // pnlDataDiri
            // 
            this.pnlDataDiri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataDiri.Controls.Add(this.label1);
            this.pnlDataDiri.Controls.Add(this.lblNama);
            this.pnlDataDiri.Location = new System.Drawing.Point(603, 0);
            this.pnlDataDiri.Name = "pnlDataDiri";
            this.pnlDataDiri.Size = new System.Drawing.Size(200, 74);
            this.pnlDataDiri.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NIM    : 1904618";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(14, 42);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(155, 13);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama : Muhammad Izzatul Haq";
            // 
            // pbLogout
            // 
            this.pbLogout.ImageLocation = "";
            this.pbLogout.Location = new System.Drawing.Point(482, 26);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(20, 20);
            this.pbLogout.TabIndex = 5;
            this.pbLogout.TabStop = false;
            this.pbLogout.Click += new System.EventHandler(this.pbLogout_Click);
            // 
            // pbWebCatalog
            // 
            this.pbWebCatalog.ImageLocation = "";
            this.pbWebCatalog.Location = new System.Drawing.Point(297, 26);
            this.pbWebCatalog.Name = "pbWebCatalog";
            this.pbWebCatalog.Size = new System.Drawing.Size(20, 20);
            this.pbWebCatalog.TabIndex = 4;
            this.pbWebCatalog.TabStop = false;
            this.pbWebCatalog.Click += new System.EventHandler(this.pbWebCatalog_Click);
            // 
            // pnlKembali
            // 
            this.pnlKembali.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlKembali.Controls.Add(this.btnKembali);
            this.pnlKembali.Location = new System.Drawing.Point(-1, 61);
            this.pnlKembali.Name = "pnlKembali";
            this.pnlKembali.Size = new System.Drawing.Size(150, 395);
            this.pnlKembali.TabIndex = 6;
            this.pnlKembali.Visible = false;
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(14, 30);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(121, 23);
            this.btnKembali.TabIndex = 5;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlKembali);
            this.Controls.Add(this.pnlDetailBarang);
            this.Controls.Add(this.pnlCari);
            this.Name = "MainMenu";
            this.Text = "Menu Utama";
            this.pnlCari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlDetailBarang.ResumeLayout(false);
            this.pnlDetailBarang.PerformLayout();
            this.panelBarang.ResumeLayout(false);
            this.panelBarang.PerformLayout();
            this.flpBarang1.ResumeLayout(false);
            this.flpBarang1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlDataDiri.ResumeLayout(false);
            this.pnlDataDiri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebCatalog)).EndInit();
            this.pnlKembali.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCari;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ComboBox cmbJenisBarang;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.ComboBox cmbHarga;
        private System.Windows.Forms.Panel pnlDetailBarang;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.PictureBox pbWebCatalog;
        private System.Windows.Forms.Panel pnlDataDiri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Panel pnlKembali;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label lblDetailNamaBarang;
        private System.Windows.Forms.PictureBox pbDetail;
        private System.Windows.Forms.Label lblDetailBarang;
        private System.Windows.Forms.Button btnDetailBeli;
        private System.Windows.Forms.Label lblDetailHarga;
        private System.Windows.Forms.LinkLabel lblWebCatalog;
        private System.Windows.Forms.Panel panelBarang;
        private System.Windows.Forms.FlowLayoutPanel flpBarang1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBarang;
    }
}