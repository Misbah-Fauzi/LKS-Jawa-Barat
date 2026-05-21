using asek.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asek
{
    public partial class InputProduk : Form
    {
        Koneksi con;
        ModelProduk mProduk;
        public bool selesai;
        public InputProduk()
        {
            InitializeComponent();
            con = new Koneksi();
            expired.Value = DateTime.Now.AddYears(1);
            selesai = false;
            Aksi.Text = "Simpan";
        }
        public InputProduk(ModelProduk modelPr)
        {
            InitializeComponent();
            this.mProduk = modelPr;
            con = new Koneksi();
            selesai = false;
            kode.Text = modelPr.kode;
            nama.Text = modelPr.nama;
            expired.Value = modelPr.exp;
            stok.Text = modelPr.stok.ToString();
            harga.Text = modelPr.harga.ToString();
            Aksi.Text = "Update";
        }

        private void Aksi_Click(object sender, EventArgs e)
        {
            if (kode.Text != "" && nama.Text != "" && expired.Value != null && stok.Text != "" && harga.Text != "")
            {
                if (Aksi.Text == "Simpan")
                {
                    con.setQuery("INSERT INTO tb_produk (kode, nama, exp, stok, harga) VALUES(@kode, @nama, @exp, @stok, @harga)");
                    con.parmString("kode", kode.Text);
                    con.parmString("nama", nama.Text);
                    con.parmDate("exp", expired.Value);
                    con.parmInt("stok", int.Parse(stok.Text));
                    con.parmInt("harga", int.Parse(harga.Text));
                    if (con.execQuery())
                    {
                        MessageBox.Show("Data berhasil disimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        selesai = true;
                        this.Close();
                    }
                }
                else if (Aksi.Text == "Update")
                {
                    con.setQuery("UPDATE tb_produk SET kode=@kode, nama=@nama, exp=@exp, stok=@stok, harga=@harga WHERE id=@id");
                    con.parmString("kode", kode.Text);
                    con.parmString("nama", nama.Text);
                    con.parmDate("exp", expired.Value);
                    con.parmInt("stok", int.Parse(stok.Text));
                    con.parmInt("harga", int.Parse(harga.Text));
                    if (con.execQuery())
                    {
                        MessageBox.Show("Data berhasil diupdate", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        selesai = true;
                        this.Close();
                    }
                }
            }
        }

        private void batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
