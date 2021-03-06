
namespace TP1PBO2021
{
    partial class BarangView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbBarang = new System.Windows.Forms.PictureBox();
            this.lblNamaBarang = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.btnBeli = new System.Windows.Forms.Button();
            this.flpBarang = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarang)).BeginInit();
            this.flpBarang.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbBarang
            // 
            this.pbBarang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flpBarang.SetFlowBreak(this.pbBarang, true);
            this.pbBarang.Location = new System.Drawing.Point(13, 13);
            this.pbBarang.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pbBarang.Name = "pbBarang";
            this.pbBarang.Size = new System.Drawing.Size(100, 100);
            this.pbBarang.TabIndex = 1;
            this.pbBarang.TabStop = false;
            // 
            // lblNamaBarang
            // 
            this.lblNamaBarang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNamaBarang.AutoSize = true;
            this.flpBarang.SetFlowBreak(this.lblNamaBarang, true);
            this.lblNamaBarang.Location = new System.Drawing.Point(27, 121);
            this.lblNamaBarang.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblNamaBarang.Name = "lblNamaBarang";
            this.lblNamaBarang.Size = new System.Drawing.Size(72, 13);
            this.lblNamaBarang.TabIndex = 2;
            this.lblNamaBarang.Text = "Nama Barang";
            this.lblNamaBarang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHarga
            // 
            this.lblHarga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHarga.AutoSize = true;
            this.lblHarga.Location = new System.Drawing.Point(33, 144);
            this.lblHarga.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(60, 13);
            this.lblHarga.TabIndex = 3;
            this.lblHarga.Text = "Rp.100000";
            this.lblHarga.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBeli
            // 
            this.btnBeli.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBeli.Location = new System.Drawing.Point(25, 167);
            this.btnBeli.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(75, 23);
            this.btnBeli.TabIndex = 4;
            this.btnBeli.Text = "Beli";
            this.btnBeli.UseVisualStyleBackColor = true;
            this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);
            // 
            // flpBarang
            // 
            this.flpBarang.Controls.Add(this.pbBarang);
            this.flpBarang.Controls.Add(this.lblNamaBarang);
            this.flpBarang.Controls.Add(this.lblHarga);
            this.flpBarang.Controls.Add(this.btnBeli);
            this.flpBarang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpBarang.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpBarang.Location = new System.Drawing.Point(0, 0);
            this.flpBarang.Name = "flpBarang";
            this.flpBarang.Padding = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.flpBarang.Size = new System.Drawing.Size(128, 213);
            this.flpBarang.TabIndex = 6;
            this.flpBarang.WrapContents = false;
            // 
            // BarangView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpBarang);
            this.Name = "BarangView";
            this.Size = new System.Drawing.Size(128, 213);
            this.Load += new System.EventHandler(this.BarangView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBarang)).EndInit();
            this.flpBarang.ResumeLayout(false);
            this.flpBarang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBarang;
        private System.Windows.Forms.Label lblNamaBarang;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.FlowLayoutPanel flpBarang;
    }
}
