namespace asek
{
    partial class InputUser
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
            this.nama = new System.Windows.Forms.TextBox();
            this.tipe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tlp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.Aksi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.batal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.alamat = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nama
            // 
            this.nama.BackColor = System.Drawing.Color.Silver;
            this.nama.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.Location = new System.Drawing.Point(38, 45);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(175, 30);
            this.nama.TabIndex = 0;
            // 
            // tipe
            // 
            this.tipe.BackColor = System.Drawing.Color.Silver;
            this.tipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tipe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipe.FormattingEnabled = true;
            this.tipe.Location = new System.Drawing.Point(239, 44);
            this.tipe.Name = "tipe";
            this.tipe.Size = new System.Drawing.Size(175, 31);
            this.tipe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipe User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telepon";
            // 
            // tlp
            // 
            this.tlp.BackColor = System.Drawing.Color.Silver;
            this.tlp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlp.Location = new System.Drawing.Point(439, 44);
            this.tlp.Name = "tlp";
            this.tlp.Size = new System.Drawing.Size(175, 30);
            this.tlp.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email";
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.Silver;
            this.email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(38, 113);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(273, 30);
            this.email.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.Silver;
            this.pass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(341, 113);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(273, 30);
            this.pass.TabIndex = 8;
            // 
            // Aksi
            // 
            this.Aksi.BackColor = System.Drawing.Color.LimeGreen;
            this.Aksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aksi.ForeColor = System.Drawing.Color.White;
            this.Aksi.Location = new System.Drawing.Point(454, 200);
            this.Aksi.Name = "Aksi";
            this.Aksi.Size = new System.Drawing.Size(160, 30);
            this.Aksi.TabIndex = 10;
            this.Aksi.Text = "-";
            this.Aksi.UseVisualStyleBackColor = false;
            this.Aksi.Click += new System.EventHandler(this.Aksi_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.batal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.alamat);
            this.panel1.Controls.Add(this.Aksi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pass);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tlp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tipe);
            this.panel1.Controls.Add(this.nama);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 298);
            this.panel1.TabIndex = 13;
            // 
            // batal
            // 
            this.batal.BackColor = System.Drawing.Color.OrangeRed;
            this.batal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batal.ForeColor = System.Drawing.Color.White;
            this.batal.Location = new System.Drawing.Point(454, 236);
            this.batal.Name = "batal";
            this.batal.Size = new System.Drawing.Size(160, 30);
            this.batal.TabIndex = 15;
            this.batal.Text = "Batal";
            this.batal.UseVisualStyleBackColor = false;
            this.batal.Click += new System.EventHandler(this.batal_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Alamat";
            // 
            // alamat
            // 
            this.alamat.BackColor = System.Drawing.Color.Silver;
            this.alamat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat.Location = new System.Drawing.Point(38, 175);
            this.alamat.Multiline = true;
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(394, 91);
            this.alamat.TabIndex = 13;
            // 
            // InputUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(649, 298);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputUser";
            this.Text = "InputUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.ComboBox tipe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tlp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Button Aksi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.Button batal;
    }
}