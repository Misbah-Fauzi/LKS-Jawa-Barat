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

namespace asek.Kasir
{
    public partial class KasirStruk : Form
    {
        List<ModelDetailTransaksi> listDetailTransaksi = new List<ModelDetailTransaksi>();
        ModelTransaksi transaksi;
        ModelPelanggan pelanggan;
        ModelUsers user;
        double total;
        public bool berhasil = false;
        public KasirStruk(List<ModelDetailTransaksi> mdt, ModelTransaksi mt, ModelPelanggan mp, ModelUsers mu, double total)
        {
            InitializeComponent();
            listDetailTransaksi = mdt;
            transaksi = mt;
            pelanggan = mp;
            user = mu;
            this.total = total;
        }

        private void KasirStruk_Load(object sender, EventArgs e)
        {
            Kasir.Text = "Kasir: " + user.nama;
            if (pelanggan == null)
                plgn.Text = "Pelanggan: Umum";
            else
                plgn.Text = pelanggan.telepon + "-" + pelanggan.nama;
            tgl.Text = DateTime.Now.ToShortDateString();
            waktu.Text = DateTime.Now.ToShortTimeString();
            nota.Text = transaksi.nota;
            totalHrg.Text = total.ToString("N0");
            namaPr.Text = hargaPr.Text = "";
            foreach (var item in listDetailTransaksi)
            {
                namaPr.Text += item.nama + " x " + item.jumlah + "\n\n";
                hargaPr.Text += (item.harga * item.jumlah).ToString("N0") + "\n\n";
            }
        }

        private void bayar_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(bayar.Text, out double bayarValue))
            {
                kembalian.Text = (bayarValue - total).ToString("N0");
            }
            else
            {
                kembalian.Text = "0";
            }
        }

        private void bayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (double.TryParse(bayar.Text, out double bayarValue))
                {
                    if (bayarValue >= total)
                    {
                        berhasil = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Pembayaran tidak cukup!", "GAGAL",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Masukkan jumlah pembayaran yang valid!", "GAGAL",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
