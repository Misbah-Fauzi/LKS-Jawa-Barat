using asek.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace asek
{
    public partial class AdminLaporan : Form
    {
        Koneksi con;
        List<ModelLaporan> ListTransaksi = new List<ModelLaporan>();
        public void gridMTransaksi()
        {
            gridTransaksi.ColumnCount = 5;
            gridTransaksi.Columns[0].HeaderText = "Nota";
            gridTransaksi.Columns[1].HeaderText = "Tanggal";
            gridTransaksi.Columns[2].HeaderText = "Total";
            gridTransaksi.Columns[3].HeaderText = "Kasir";
            gridTransaksi.Columns[4].HeaderText = "Pelanggan";
            gridTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void getDataTransaksi(string filter)
        {
            if (filter == "")
            {
                con.setQuery("SELECT tb_transaksi.nota, tb_transaksi.tgl, tb_pelanggan.nama, tb_users.nama, (tb_detail_transaksi.jumlah * tb_detail_transaksi.harga) AS total " +
                    "FROM tb_transaksi " +
                    "LEFT JOIN tb_detail_transaksi on tb_transaksi.id = tb_detail_transaksi.id_transaksi " +
                    "LEFT JOIN tb_pelanggan on tb_pelanggan.id = tb_transaksi.id_pelanggan " +
                    "LEFT JOIN tb_users on tb_users.id = tb_transaksi.id_user");
            }
            else
            {
                con.setQuery("SELECT tb_transaksi.nota, tb_transaksi.tgl, tb_pelanggan.nama, tb_users.nama, (tb_detail_transaksi.jumlah * tb_detail_transaksi.harga) AS total " +
                    "FROM tb_transaksi " +
                    "LEFT JOIN tb_detail_transaksi on tb_transaksi.id = tb_detail_transaksi.id_transaksi " +
                    "LEFT JOIN tb_pelanggan on tb_pelanggan.id = tb_transaksi.id_pelanggan " +
                    "LEFT JOIN tb_users on tb_users.id = tb_transaksi.id_user " +
                    "WHERE tb_transaksi.tgl >= @awal AND tb_transaksi.tgl <= @akhir");
                con.parmDate("@awal", awaltgl.Value);
                con.parmDate("@akhir", akhirtgl.Value);
            }
            DataTable dt = con.execTable();
            ListTransaksi.Clear();
            gridTransaksi.Rows.Clear();
            if (dt != null)
            {
                grafik.Series["Omset"].Points.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    gridTransaksi.RowCount += 1;
                    ModelLaporan m = new ModelLaporan()
                    {
                        nota = dt.Rows[i][0].ToString(),
                        tgl = dt.Rows[i][1].ToString(),
                        total = dt.Rows[i][4].ToString(),
                        kasir = dt.Rows[i][3].ToString(),
                        pelanggan = dt.Rows[i][2].ToString()
                    };
                    gridTransaksi.Rows[i].Cells[0].Value = m.nota;
                    gridTransaksi.Rows[i].Cells[1].Value = m.tgl;
                    gridTransaksi.Rows[i].Cells[2].Value = m.total;
                    gridTransaksi.Rows[i].Cells[3].Value = m.kasir;
                    gridTransaksi.Rows[i].Cells[4].Value = m.pelanggan;
                    ListTransaksi.Add(m);
                    grafik.Series["Omset"].Points.AddXY(m.tgl, m.total);
                }
            }

        }
        public AdminLaporan()
        {
            InitializeComponent();
            con = new Koneksi();
            gridMTransaksi();
            getDataTransaksi("");
        }

        private void filter_Click(object sender, EventArgs e)
        {
            getDataTransaksi("filter");
        }
    }
}
