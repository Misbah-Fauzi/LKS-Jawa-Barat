using System;
using System.Data;
using System.Windows.Forms;

namespace asek
{
    public partial class LoginPage : Form
    {
        Koneksi con;
        public static ModelUsers mUsr {  get; set; }
        public bool berhasil = false;
        public LoginPage()
        {
            InitializeComponent();
            con = new Koneksi();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtemail.Text != "" && txtpass.Text != "")
            {
                con.setQuery("SELECT * FROM tb_users WHERE email=@email AND password=@password");
                con.parmString("email", txtemail.Text);
                con.parmString("password", txtpass.Text);
                DataTable dt = con.execTable();
                if (dt != null && dt.Rows.Count > 0)
                {
                    mUsr = new ModelUsers()
                    {
                        id = int.Parse(dt.Rows[0][0].ToString()),
                        nama = dt.Rows[0][4].ToString(),
                        tipe = dt.Rows[0][1].ToString(),
                    };
                    berhasil = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email atau Password salah!", "GAGAL",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Email dan Password tidak boleh kosong!", "GAGAL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtpass.Text != "")
            {
                if (e.KeyChar == 13)
                {
                    button1_Click(null, e);
                }
            }
        }
    }
}
