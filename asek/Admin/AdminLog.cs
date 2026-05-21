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
    public partial class AdminLog : Form
    {
        Koneksi con;
        public List<ModelLog> listLog = new List<ModelLog>();
        private void gridMLog()
        {
            gridLog.ColumnCount = 4;
            gridLog.Columns[0].HeaderText = "Nomor";
            gridLog.Columns[1].HeaderText = "Nama User";
            gridLog.Columns[2].HeaderText = "Aktivitas";
            gridLog.Columns[3].HeaderText = "Tanggal";
            gridLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void getDataLog(string filter)
        {
            if (filter == null) 
                con.setQuery("SELECT tb_log.id, tb_log.waktu, tb_log.aktivitas, tb_users.nama FROM tb_log LEFT JOIN tb_users ON tb_users.id = tb_log.id_user");
            else
            {
                con.setQuery("SELECT tb_log.id, tb_log.waktu, tb_log.aktivitas, tb_users.nama FROM tb_log LEFT JOIN tb_users ON tb_users.id = tb_log.id_user WHERE waktu >= @awal AND waktu <= @akhir");
                con.parmDate("awal", DateTime.Parse(tglAwal.Value.ToShortDateString()));
                con.parmDate("akhir", DateTime.Parse(tglAkhir.Value.ToShortDateString()));
            }
            DataTable dt = con.execTable();
            listLog.Clear();
            gridLog.Rows.Clear();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    gridLog.RowCount += 1;
                    ModelLog m = new ModelLog()
                    {
                        id = int.Parse(dt.Rows[i][0].ToString()),
                        waktu = DateTime.Parse(dt.Rows[i][1].ToString()),
                        aktivitas = dt.Rows[i][2].ToString(),
                        nama = dt.Rows[i][3].ToString()
                    };
                    gridLog.Rows[i].Cells[0].Value = i + 1;
                    gridLog.Rows[i].Cells[1].Value = m.nama;
                    gridLog.Rows[i].Cells[2].Value = m.aktivitas;
                    gridLog.Rows[i].Cells[3].Value = m.waktu;
                    listLog.Add(m);
                }
            }
        }
        public AdminLog()
        {
            InitializeComponent();
            con = new Koneksi();
            gridMLog();
            getDataLog(null);
            tglAkhir.Value = DateTime.Now;
            tglAwal.Value = DateTime.Now.AddDays(-7);
        }

        private void filter_Click(object sender, EventArgs e)
        {
            getDataLog("filter");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getDataLog(null);
            tglAwal.Value = DateTime.Now.AddDays(-7);
            tglAkhir.Value = DateTime.Now;
        }
    }
}
