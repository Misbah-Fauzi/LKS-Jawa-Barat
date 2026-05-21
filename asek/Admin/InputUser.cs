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
    public partial class InputUser : Form
    {
        Koneksi con;
        ModelUsers mUser;
        public bool selesai;
        public InputUser()
        {
            InitializeComponent();
            con = new Koneksi();
            tipe.Items.Clear();
            tipe.Items.Add("Admin");
            tipe.Items.Add("Gudang");
            tipe.Items.Add("Kasir");
            tipe.SelectedIndex = 0;
            selesai = false;
            Aksi.Text = "Simpan";
        }
        public InputUser(ModelUsers modelUs)
        {
            InitializeComponent();
            this.mUser = modelUs;
            con = new Koneksi();
            tipe.Items.Clear();
            tipe.Items.Add("Admin");
            tipe.Items.Add("Gudang");
            tipe.Items.Add("Kasir");
            tipe.SelectedIndex = 0;
            selesai = false;
            nama.Text = modelUs.nama;
            tipe.Text = modelUs.tipe;
            tlp.Text = modelUs.telepon;
            email.Text = modelUs.email;
            pass.Text = modelUs.password;
            alamat.Text = modelUs.alamat;
            Aksi.Text = "Update";
        }

        private void Aksi_Click(object sender, EventArgs e)
        {
            if (nama.Text != "" && tipe.Text != "" && tlp.Text != "" && email.Text != "" && pass.Text != "" && alamat.Text != "")
            {
                if (Aksi.Text == "Simpan")
                {
                    con.setQuery("INSERT INTO tb_users(nama, tipe, telepon, email, password, alamat) VALUES(@nama, @tipe, @telepon, @email, @password, @alamat)");
                    con.parmString("nama", nama.Text);
                    con.parmString("tipe", tipe.Text);
                    con.parmString("telepon", tlp.Text);
                    con.parmString("email", email.Text);
                    con.parmString("password", pass.Text);
                    con.parmString("alamat", alamat.Text);
                    if (con.execQuery())
                    {
                        MessageBox.Show("Data berhasil disimpan", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        selesai = true;
                        this.Close();
                    }
                }
                if (Aksi.Text == "Update")
                {
                    con.setQuery("UPDATE tb_users SET nama=@nama, tipe=@tipe, telepon=@telepon, email=@email, password=@password, alamat=@alamat WHERE id=" + mUser.id);
                    con.parmString("nama", nama.Text);
                    con.parmString("tipe", tipe.Text);
                    con.parmString("telepon", tlp.Text);
                    con.parmString("email", email.Text);
                    con.parmString("password", pass.Text);
                    con.parmString("alamat", alamat.Text);
                    if (con.execQuery())
                    {
                        MessageBox.Show("Data telah berubah", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        selesai = true;
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Data tidak boleh kosong", "PERINGATAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void batal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
