using asek.Main;
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
    public partial class KasirTransaksi : Form
    {
        Koneksi con;
        List<ModelDetailTransaksi> ListDTransaksi = new List<ModelDetailTransaksi>();
        List<ModelProduk> ListProduk = new List<ModelProduk>();
        ModelTransaksi mTransaksi;
        ModelPelanggan mPelanggan;
        string idPelanggan;
        private void gridKeranjang()
        {
            gridDTransaksi.ColumnCount = 6;
            gridDTransaksi.Columns[0].HeaderText = "Nomor";
            gridDTransaksi.Columns[1].HeaderText = "Kode Produk";
            gridDTransaksi.Columns[2].HeaderText = "Nama Produk";
            gridDTransaksi.Columns[3].HeaderText = "Harga";
            gridDTransaksi.Columns[4].HeaderText = "Jumlah";
            gridDTransaksi.Columns[5].HeaderText = "Subtotal";
            gridDTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void getDataKeranjang()
        {
            con.setQuery("SELECT tb_detail_transaksi.id, tb_produk.kode, tb_produk.nama, tb_detail_transaksi.harga," +
                " tb_detail_transaksi.jumlah, (tb_detail_transaksi.harga * tb_detail_transaksi.jumlah) AS subtotal, " +
                " tb_produk.id AS id_produk " +
                " FROM tb_detail_transaksi " +
                " LEFT JOIN tb_produk ON tb_produk.id = tb_detail_transaksi.id_produk" +
                " LEFT JOIN tb_transaksi ON tb_transaksi.id = tb_detail_transaksi.id_transaksi WHERE tb_transaksi.nota = @nota");
            con.parmString("@nota", faktur.Text);
            DataTable dt = con.execTable();
            ListDTransaksi.Clear();
            gridDTransaksi.Rows.Clear();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    gridDTransaksi.RowCount += 1;
                    ModelDetailTransaksi m = new ModelDetailTransaksi()
                    {
                        id = int.Parse(dt.Rows[i][0].ToString()),
                        kode = dt.Rows[i][1].ToString(),
                        nama = dt.Rows[i][2].ToString(),
                        harga = long.Parse(dt.Rows[i][3].ToString()),
                        jumlah = int.Parse(dt.Rows[i][4].ToString()),
                        id_produk = int.Parse(dt.Rows[i][6].ToString())
                    };
                    reloadGrid(m, i);
                    ListDTransaksi.Add(m);
                }
            }
            total();
        }
        private void reloadGrid(ModelDetailTransaksi m, int i)
        {
            gridDTransaksi.Rows[i].Cells[0].Value = i + 1;
            gridDTransaksi.Rows[i].Cells[1].Value = m.kode;
            gridDTransaksi.Rows[i].Cells[2].Value = m.nama;
            gridDTransaksi.Rows[i].Cells[3].Value = Properti.stringkenum(m.harga.ToString());
            gridDTransaksi.Rows[i].Cells[4].Value = m.jumlah;
            gridDTransaksi.Rows[i].Cells[5].Value = Properti.stringkenum((m.harga * m.jumlah).ToString());
        }
        public KasirTransaksi()
        {
            InitializeComponent();
            con = new Koneksi();
            panel4.Visible = false;
            faktur.Text = Properti.kodefaktur();
            notaTransaksi();
            gridKeranjang();
            getDataKeranjang();
        }
        public void notaTransaksi()
        {
            con.setQuery("INSERT INTO tb_transaksi (nota, tgl, id_user) VALUES (@nota, @tgl, @id_user)");
            con.parmString("@nota", faktur.Text);
            con.parmDate("@tgl", DateTime.Now);
            con.parmInt("@id_user", LoginPage.mUsr.id);
            con.execQuery();
        }
        private string idTransaksi()
        {
            con.setQuery("SELECT id FROM tb_transaksi WHERE nota = @nota");
            con.parmString("@nota", faktur.Text);
            DataTable dt = con.execTable();
            return dt.Rows[0][0].ToString();
        }
        private void tambahPlgn()
        {
            if (pelanggan.Text != "" && telepon.Text != "")
            {
                con.setQuery("INSERT INTO tb_pelanggan (nama, telepon) VALUES (@nama, @telepon)");
                con.parmString("@nama", pelanggan.Text);
                con.parmString("@telepon", telepon.Text);
                if (con.execQuery())
                {
                    con.setQuery("SELECT MAX(id) FROM tb_pelanggan");
                    DataTable dt = con.execTable();
                    idPelanggan = dt.Rows[0][0].ToString();
                    con.setQuery("UPDATE tb_transaksi SET id_pelanggan = @id_pelanggan WHERE nota = @nota");
                    con.parmInt("@id_pelanggan", int.Parse(idPelanggan));
                    con.parmString("@nota", faktur.Text);
                    if (con.execQuery())
                    {
                        pelanggan.Enabled = false;
                        telepon.Enabled = false;
                    }
                }
            }
        }
        private void total()
        {
            long total = 0;
            for (int i = 0; i < ListDTransaksi.Count; i++)
            {
                total += ListDTransaksi[i].harga * ListDTransaksi[i].jumlah;
            }
            totalHarga.Text = Properti.stringkenum(total.ToString());
        }
        private void updateStok()
        {
            for (int i = 0; i < ListDTransaksi.Count; i++)
            {
                con.setQuery("UPDATE tb_produk SET stok = stok - @jumlah WHERE id = @id");
                con.parmInt("@jumlah", ListDTransaksi[i].jumlah);
                con.parmInt("@id", ListDTransaksi[i].id_produk);
                con.execQuery();
            }
        }
        public void getDataPelanggan()
        {
            con.setQuery("SELECT id, nama, telepon FROM tb_pelanggan WHERE id = @id");
            con.parmInt("@id", int.Parse(idPelanggan));
            DataTable dt = con.execTable();
            if (dt != null)
            {
                mPelanggan = new ModelPelanggan()
                {
                    id = int.Parse(dt.Rows[0][0].ToString()),
                    nama = dt.Rows[0][1].ToString(),
                    telepon = dt.Rows[0][2].ToString()
                };
            }
        }
        public void getDataTransaksi()
        {
            con.setQuery("SELECT id, nota, tgl, id_user, id_pelanggan FROM tb_transaksi WHERE nota = @nota");
            con.parmString("@nota", faktur.Text);
            DataTable dt = con.execTable();
            if (dt != null)
            {
                mTransaksi = new ModelTransaksi()
                {
                    id = int.Parse(dt.Rows[0][0].ToString()),
                    nota = dt.Rows[0][1].ToString(),
                    tgl = DateTime.Parse(dt.Rows[0][2].ToString()),
                    id_user = int.Parse(dt.Rows[0][3].ToString()),
                    id_pelanggan = int.Parse(dt.Rows[0][4].ToString())
                };
            }
        }
        private void cari_TextChanged(object sender, EventArgs e)
        {
            if (cari.Text != "")
            {
                panel4.Visible = true;
                con.setQuery("SELECT id, kode, nama, harga, stok FROM tb_produk WHERE nama LIKE @cari AND stok > 0");
                con.parmString("@cari", "%" + cari.Text + "%");
                DataTable dt = con.execTable();
                ListProduk.Clear();
                produk.Items.Clear();
                if (dt != null)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ModelProduk m = new ModelProduk()
                        {
                            id = int.Parse(dt.Rows[i][0].ToString()),
                            kode = dt.Rows[i][1].ToString(),
                            nama = dt.Rows[i][2].ToString(),
                            harga = long.Parse(dt.Rows[i][3].ToString()),
                            stok = int.Parse(dt.Rows[i][4].ToString())
                        };
                        produk.Items.Add(m.kode + " - " + m.nama);
                        ListProduk.Add(m);
                    }
                }
            }
            else
                panel4.Visible = false;
        }
        private void produk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (produk.SelectedIndex != -1)
            {
                int idT = int.Parse(idTransaksi());
                int index = produk.SelectedIndex;
                con.setQuery("INSERT INTO tb_detail_transaksi (id_transaksi,id_produk, harga, jumlah) VALUES (@id_transaksi, @id_produk, @harga, @jumlah)");
                con.parmInt("@id_transaksi", idT);
                con.parmInt("@id_produk", ListProduk[index].id);
                con.parmBigint("@harga", ListProduk[index].harga);
                con.parmInt("@jumlah", 1);
                if (con.execQuery())
                {
                    getDataKeranjang();
                    panel4.Visible = false;
                    cari.Text = "";
                    this.ActiveControl = cari;
                }
            }
        }

        private void gridDTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                if (e.ColumnIndex == 4)
                {
                    InputJumlah a = new InputJumlah(Cursor.Position.X, Cursor.Position.Y);
                    blank b = new blank();
                    b.Show();
                    a.ShowDialog();
                    b.Close();
                    if (a.aksi)
                    {
                        con.setQuery("SELECT stok FROM tb_produk WHERE id = @id");
                        con.parmInt("@id", ListDTransaksi[e.RowIndex].id_produk);
                        DataTable dt = con.execTable();
                        if (int.Parse(dt.Rows[0][0].ToString()) < int.Parse(a.jumlah))
                        {
                            MessageBox.Show("Sisa stok " + dt.Rows[0][0].ToString(), "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        con.setQuery("UPDATE tb_detail_transaksi SET jumlah = @jumlah WHERE id = @id");
                        con.parmInt("@jumlah", int.Parse(a.jumlah));
                        con.parmInt("@id", ListDTransaksi[e.RowIndex].id);
                        if (con.execQuery())
                        {
                            ListDTransaksi[e.RowIndex].jumlah = int.Parse(a.jumlah);
                            reloadGrid(ListDTransaksi[e.RowIndex], e.RowIndex);
                            total();
                        }
                        //if (int.Parse(dt.Rows[0][0].ToString()) >= int.Parse(a.jumlah))
                        //{
                        //    con.setQuery("UPDATE tb_detail_transaksi SET jumlah = @jumlah WHERE id = @id");
                        //    con.parmInt("@jumlah", int.Parse(a.jumlah));
                        //    con.parmInt("@id", ListDTransaksi[e.RowIndex].id);
                        //    if (con.execQuery())
                        //    {
                        //        ListDTransaksi[e.RowIndex].jumlah = int.Parse(a.jumlah);
                        //        reloadGrid(ListDTransaksi[e.RowIndex], e.RowIndex);
                        //        total();
                        //    }
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Stok tidak mencukupi", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                    }
                }
            }
        }

        private void bayar_Click(object sender, EventArgs e)
        {
            if (pelanggan.Text == "" || telepon.Text == "")
            {
                MessageBox.Show("Data pelanggan tidak boleh kosong", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (gridDTransaksi.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada orderan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            tambahPlgn();
            getDataTransaksi();
            getDataPelanggan();
            KasirStruk s = new KasirStruk(ListDTransaksi, mTransaksi, mPelanggan, LoginPage.mUsr, double.Parse(totalHarga.Text));
            blank b = new blank(); 
            b.Show();
            s.ShowDialog();
            b.Close();
            if (s.berhasil)
            {
                updateStok();
                panel4.Visible = false;
                faktur.Text = Properti.kodefaktur();
                notaTransaksi();
                gridKeranjang();
                getDataKeranjang();
                pelanggan.Enabled = true;
                telepon.Enabled = true;
                pelanggan.Text = "";
                telepon.Text = "";
            }
        }
    }
}
