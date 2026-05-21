namespace asek
{
    partial class InputProduk
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
            this.stok = new System.Windows.Forms.TextBox();
            this.expired = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.TextBox();
            this.apa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kode = new System.Windows.Forms.TextBox();
            this.harga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.batal = new System.Windows.Forms.Button();
            this.Aksi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stok);
            this.panel1.Controls.Add(this.expired);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nama);
            this.panel1.Controls.Add(this.apa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.kode);
            this.panel1.Controls.Add(this.harga);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.batal);
            this.panel1.Controls.Add(this.Aksi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 248);
            this.panel1.TabIndex = 0;
            // 
            // stok
            // 
            this.stok.BackColor = System.Drawing.Color.Silver;
            this.stok.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stok.Location = new System.Drawing.Point(418, 48);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(175, 30);
            this.stok.TabIndex = 31;
            // 
            // expired
            // 
            this.expired.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expired.Location = new System.Drawing.Point(17, 116);
            this.expired.Name = "expired";
            this.expired.Size = new System.Drawing.Size(270, 22);
            this.expired.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nama Produk";
            // 
            // nama
            // 
            this.nama.BackColor = System.Drawing.Color.Silver;
            this.nama.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.Location = new System.Drawing.Point(220, 48);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(175, 30);
            this.nama.TabIndex = 20;
            // 
            // apa
            // 
            this.apa.AutoSize = true;
            this.apa.Location = new System.Drawing.Point(11, 28);
            this.apa.Name = "apa";
            this.apa.Size = new System.Drawing.Size(85, 16);
            this.apa.TabIndex = 19;
            this.apa.Text = "Kode Produk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Stok";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Expired";
            // 
            // kode
            // 
            this.kode.BackColor = System.Drawing.Color.Silver;
            this.kode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kode.Location = new System.Drawing.Point(17, 48);
            this.kode.Name = "kode";
            this.kode.Size = new System.Drawing.Size(175, 30);
            this.kode.TabIndex = 16;
            // 
            // harga
            // 
            this.harga.BackColor = System.Drawing.Color.Silver;
            this.harga.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harga.Location = new System.Drawing.Point(320, 116);
            this.harga.Name = "harga";
            this.harga.Size = new System.Drawing.Size(273, 30);
            this.harga.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Harga";
            // 
            // batal
            // 
            this.batal.BackColor = System.Drawing.Color.OrangeRed;
            this.batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batal.ForeColor = System.Drawing.Color.White;
            this.batal.Location = new System.Drawing.Point(267, 184);
            this.batal.Name = "batal";
            this.batal.Size = new System.Drawing.Size(160, 30);
            this.batal.TabIndex = 29;
            this.batal.Text = "Batal";
            this.batal.UseVisualStyleBackColor = false;
            this.batal.Click += new System.EventHandler(this.batal_Click);
            // 
            // Aksi
            // 
            this.Aksi.BackColor = System.Drawing.Color.LimeGreen;
            this.Aksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aksi.ForeColor = System.Drawing.Color.White;
            this.Aksi.Location = new System.Drawing.Point(433, 184);
            this.Aksi.Name = "Aksi";
            this.Aksi.Size = new System.Drawing.Size(160, 30);
            this.Aksi.TabIndex = 26;
            this.Aksi.Text = "-";
            this.Aksi.UseVisualStyleBackColor = false;
            this.Aksi.Click += new System.EventHandler(this.Aksi_Click);
            // 
            // InputProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 248);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputProduk";
            this.Text = "InputProduk";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label apa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox kode;
        private System.Windows.Forms.TextBox harga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button batal;
        private System.Windows.Forms.Button Aksi;
        private System.Windows.Forms.DateTimePicker expired;
        private System.Windows.Forms.TextBox stok;
    }
}