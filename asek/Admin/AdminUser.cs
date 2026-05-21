using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace asek
{
    public partial class AdminUser : Form
    {
        Koneksi con;
        List<ModelUsers> listUsers = new List<ModelUsers>();
        public void gridMUser()
        {
            gridUser.ColumnCount = 5;
            gridUser.Columns[0].HeaderText = "Nomor";
            gridUser.Columns[1].HeaderText = "Tipe User";
            gridUser.Columns[2].HeaderText = "Nama User";
            gridUser.Columns[3].HeaderText = "Alamat";
            gridUser.Columns[4].HeaderText = "Telepon";
            gridUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            gridUser.Columns.Add(edit);
            gridUser.Columns.Add(hapus);
        }
        private void getDataUser(string filter)
        {
            if (filter == "")
                con.setQuery("SELECT * FROM tb_users");
            else
            {
                con.setQuery("SELECT * FROM tb_users WHERE nama LIKE @nama");
                con.parmString("nama", "%" + filter + "%");
            }
            DataTable dt = con.execTable();
            listUsers.Clear();
            gridUser.Rows.Clear();
            if (dt != null)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    gridUser.RowCount += 1;
                    ModelUsers m = new ModelUsers()
                    {
                        id = int.Parse(dt.Rows[i][0].ToString()),
                        tipe = dt.Rows[i][1].ToString(),
                        nama = dt.Rows[i][2].ToString(),
                        alamat = dt.Rows[i][3].ToString(),
                        telepon = dt.Rows[i][5].ToString(),
                        email = dt.Rows[i][4].ToString(),
                        password = dt.Rows[i][6].ToString()
                    };
                    gridUser.Rows[i].Cells[0].Value = i + 1;
                    gridUser.Rows[i].Cells[1].Value = m.tipe;
                    gridUser.Rows[i].Cells[2].Value = m.nama;
                    gridUser.Rows[i].Cells[3].Value = m.alamat;
                    gridUser.Rows[i].Cells[4].Value = m.telepon;
                    listUsers.Add(m);
                }
            }
        }
        public AdminUser()
        {
            InitializeComponent();
            con = new Koneksi();
            gridMUser();
            getDataUser("");
            panel4.Visible = false;
        }
        public void normal(ModelUsers model)
        {
            panel4.Visible = true;
            panel4.Controls.Clear();

            InputUser a;
            if (model == null)
                a = new InputUser();
            else
                a = new InputUser(model);

            a.TopLevel = false;
            panel4.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            a.Show();
            a.FormClosed += (s, args) =>
            {
                if (a.selesai)
                    getDataUser("");
                panel4.Visible = false;
            };
        }
        private void tambah_Click(object sender, EventArgs e)
        {
            normal(null);
        }

        private void gridUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUser.Rows.Count > 0)
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    if (e.ColumnIndex == 5)
                    {
                        normal(listUsers[e.RowIndex]);
                    }
                    else if (e.ColumnIndex == 6)
                    {
                        if (MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            con.setQuery("DELETE FROM tb_users WHERE id = " + listUsers[e.RowIndex].id);
                            if (con.execQuery())
                                getDataUser("");
                            else
                                MessageBox.Show("Gagal menghapus data!");
                        }
                    }
                }
            }
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            if(cari.Text != "")
                getDataUser(cari.Text);
            else
                getDataUser("");
        }
    }
}
