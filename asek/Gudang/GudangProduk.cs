using asek.Kasir;
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
    public partial class GudangProduk : Form
    {
        Koneksi con;
        List<ModelProduk> listProduk = new List<ModelProduk>();
        private void gridMProduk()
        {
            gridProduk.ColumnCount = 6;
            gridProduk.Columns[0].HeaderText = "Nomor";
            gridProduk.Columns[1].HeaderText = "Kode";
            gridProduk.Columns[2].HeaderText = "Nama";
            gridProduk.Columns[3].HeaderText = "Exp";
            gridProduk.Columns[4].HeaderText = "Stok";
            gridProduk.Columns[5].HeaderText = "Harga";
            gridProduk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewButtonColumn edit = new DataGridViewButtonColumn()
            {
                HeaderText = "Edit",
                Name = "edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            DataGridViewButtonColumn hapus = new DataGridViewButtonColumn()
            {
                HeaderText = "Hapus",
                Name = "hapus",
                Text = "Hapus",
                UseColumnTextForButtonValue = true
            };
            gridProduk.Columns.Add(edit);
            gridProduk.Columns.Add(hapus);
        }
        private void getDataProduk(string filter)
        {
            if (filter == "")
                con.setQuery("SELECT id,kode,nama,exp,stok,harga FROM tb_produk");
            else
            {
                con.setQuery("SELECT id,kode,nama,exp,stok,harga FROM tb_produk WHERE nama LIKE @nama");
                con.parmString("nama", "%" + filter + "%");
            }
            DataTable dt = con.execTable();
            listProduk.Clear();
            gridProduk.Rows.Clear();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    gridProduk.RowCount += 1;
                    ModelProduk m = new ModelProduk()
                    {
                        id = int.Parse(dt.Rows[i][0].ToString()),
                        kode = dt.Rows[i][1].ToString(),
                        nama = dt.Rows[i][2].ToString(),
                        exp = DateTime.Parse(dt.Rows[i][3].ToString()),
                        stok = int.Parse(dt.Rows[i][4].ToString()),
                        harga = long.Parse(dt.Rows[i][5].ToString())
                    };
                    reloadGrid(m, i);
                    listProduk.Add(m);
                }
            }
        }
        private void reloadGrid(ModelProduk m, int index)
        {
            gridProduk.Rows[index].Cells[0].Value = index + 1;
            gridProduk.Rows[index].Cells[1].Value = m.kode;
            gridProduk.Rows[index].Cells[2].Value = m.nama;
            gridProduk.Rows[index].Cells[3].Value = m.exp.ToShortDateString();
            gridProduk.Rows[index].Cells[4].Value = Main.Properti.stringkenum(m.stok.ToString());
            gridProduk.Rows[index].Cells[5].Value = Main.Properti.stringkenum(m.harga.ToString());
        }
        public GudangProduk()
        {
            InitializeComponent();
            con = new Koneksi();
            gridMProduk();
            getDataProduk("");
            panel4.Visible = false;
        }
        public void InputUpdate(ModelProduk model)
        {
            panel4.Visible = true;
            panel4.Controls.Clear();

            InputProduk a;
            if (model == null)
                a = new InputProduk();
            else
                a = new InputProduk(model);

            a.TopLevel = false;
            panel4.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            a.Show();
            a.FormClosed += (s, args) =>
            {
                if (a.selesai)
                    getDataProduk("");
                panel4.Visible = false;
            };
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            InputUpdate(null);
        }

        private void gridProduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridProduk.Rows.Count > 0)
            {
                if (e.ColumnIndex != -1 && e.RowIndex != -1)
                {
                    if (e.ColumnIndex == 6)
                    {
                        InputUpdate(listProduk[e.RowIndex]);
                    }
                    else if (e.ColumnIndex == 7)
                    {
                        if (MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            con.setQuery("DELETE FROM tb_produk WHERE id=" + listProduk[e.RowIndex].id);
                            if (con.execQuery())
                                getDataProduk("");
                            else
                                MessageBox.Show("Gagal menghapus data!", "GAGAL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (e.ColumnIndex == 4)
                    {
                        InputJumlah a = new InputJumlah(Cursor.Position.X, Cursor.Position.Y);
                        blank b = new blank();
                        b.Show();
                        a.ShowDialog();
                        b.Close();
                        if (a.aksi)
                        {
                            con.setQuery("UPDATE tb_produk SET stok = @jumlah WHERE id = @id");
                            con.parmInt("@jumlah", int.Parse(a.jumlah));
                            con.parmInt("@id", listProduk[e.RowIndex].id);
                            if (con.execQuery())
                            {
                                listProduk[e.RowIndex].stok = int.Parse(a.jumlah);
                                reloadGrid(listProduk[e.RowIndex], e.RowIndex);
                            }
                        }
                    }
                }
            }
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            if (cari.Text != "")
                getDataProduk(cari.Text);
            else
                getDataProduk("");
        }
    }
}
