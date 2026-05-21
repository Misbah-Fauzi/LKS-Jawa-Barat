namespace asek.Kasir
{
    partial class KasirTransaksi
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.telepon = new System.Windows.Forms.TextBox();
            this.pelanggan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridDTransaksi = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.faktur = new System.Windows.Forms.Label();
            this.cari = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.produk = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.bayar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totalHarga = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDTransaksi)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.telepon);
            this.panel1.Controls.Add(this.pelanggan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 59);
            this.panel1.TabIndex = 9;
            // 
            // telepon
            // 
            this.telepon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.telepon.BackColor = System.Drawing.Color.Silver;
            this.telepon.Location = new System.Drawing.Point(524, 31);
            this.telepon.Name = "telepon";
            this.telepon.Size = new System.Drawing.Size(154, 22);
            this.telepon.TabIndex = 3;
            this.telepon.Text = "-";
            // 
            // pelanggan
            // 
            this.pelanggan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pelanggan.BackColor = System.Drawing.Color.Silver;
            this.pelanggan.Location = new System.Drawing.Point(524, 3);
            this.pelanggan.Name = "pelanggan";
            this.pelanggan.Size = new System.Drawing.Size(154, 22);
            this.pelanggan.TabIndex = 2;
            this.pelanggan.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Transaksi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridDTransaksi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 492);
            this.panel2.TabIndex = 10;
            // 
            // gridDTransaksi
            // 
            this.gridDTransaksi.AllowUserToAddRows = false;
            this.gridDTransaksi.AllowUserToDeleteRows = false;
            this.gridDTransaksi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDTransaksi.Location = new System.Drawing.Point(19, 15);
            this.gridDTransaksi.Name = "gridDTransaksi";
            this.gridDTransaksi.ReadOnly = true;
            this.gridDTransaksi.RowHeadersWidth = 51;
            this.gridDTransaksi.RowTemplate.Height = 24;
            this.gridDTransaksi.Size = new System.Drawing.Size(642, 454);
            this.gridDTransaksi.TabIndex = 5;
            this.gridDTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDTransaksi_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.faktur);
            this.panel3.Controls.Add(this.cari);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(681, 41);
            this.panel3.TabIndex = 11;
            // 
            // faktur
            // 
            this.faktur.AutoSize = true;
            this.faktur.Dock = System.Windows.Forms.DockStyle.Right;
            this.faktur.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faktur.ForeColor = System.Drawing.Color.Crimson;
            this.faktur.Location = new System.Drawing.Point(619, 0);
            this.faktur.Name = "faktur";
            this.faktur.Size = new System.Drawing.Size(62, 23);
            this.faktur.TabIndex = 1;
            this.faktur.Text = "label2";
            this.faktur.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cari
            // 
            this.cari.BackColor = System.Drawing.Color.Silver;
            this.cari.Location = new System.Drawing.Point(19, 10);
            this.cari.Name = "cari";
            this.cari.Size = new System.Drawing.Size(136, 22);
            this.cari.TabIndex = 0;
            this.cari.TextChanged += new System.EventHandler(this.cari_TextChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.produk);
            this.panel4.Location = new System.Drawing.Point(19, 93);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 238);
            this.panel4.TabIndex = 6;
            // 
            // produk
            // 
            this.produk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.produk.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produk.FormattingEnabled = true;
            this.produk.ItemHeight = 21;
            this.produk.Location = new System.Drawing.Point(0, 0);
            this.produk.Name = "produk";
            this.produk.Size = new System.Drawing.Size(304, 238);
            this.produk.TabIndex = 0;
            this.produk.SelectedIndexChanged += new System.EventHandler(this.produk_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.bayar);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.totalHarga);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 592);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(681, 66);
            this.panel5.TabIndex = 6;
            // 
            // bayar
            // 
            this.bayar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bayar.Location = new System.Drawing.Point(19, 13);
            this.bayar.Name = "bayar";
            this.bayar.Size = new System.Drawing.Size(101, 33);
            this.bayar.TabIndex = 2;
            this.bayar.Text = "Bayar";
            this.bayar.UseVisualStyleBackColor = true;
            this.bayar.Click += new System.EventHandler(this.bayar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total";
            // 
            // totalHarga
            // 
            this.totalHarga.AutoSize = true;
            this.totalHarga.Dock = System.Windows.Forms.DockStyle.Right;
            this.totalHarga.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHarga.ForeColor = System.Drawing.Color.Firebrick;
            this.totalHarga.Location = new System.Drawing.Point(614, 14);
            this.totalHarga.Name = "totalHarga";
            this.totalHarga.Size = new System.Drawing.Size(24, 33);
            this.totalHarga.TabIndex = 0;
            this.totalHarga.Text = "-";
            this.totalHarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(638, 14);
            this.panel6.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(638, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(43, 66);
            this.panel7.TabIndex = 4;
            // 
            // KasirTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 658);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KasirTransaksi";
            this.Text = "KasirTransaksi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDTransaksi)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridDTransaksi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox cari;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox produk;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label faktur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalHarga;
        private System.Windows.Forms.Button bayar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox telepon;
        private System.Windows.Forms.TextBox pelanggan;
    }
}