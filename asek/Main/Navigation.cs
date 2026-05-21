using asek.Kasir;
using System;
using System.Windows.Forms;

namespace asek
{
    public partial class Navigation : Form
    {
        Koneksi con;
        public Navigation()
        {
            InitializeComponent();
            con = new Koneksi();
        }
        private void Navigation_Load(object sender, EventArgs e)
        { 
            panel7.Visible = false;
            panel3.Controls.Clear();
            LoginPage l = new LoginPage();
            blank b = new blank();
            b.Show();
            l.ShowDialog();
            b.Close();

            if (l.berhasil)
            {
                if (LoginPage.mUsr.tipe == "Admin")
                {
                    panel7.Visible = true;
                    infologin.Text = "Admin";
                }
                else if (LoginPage.mUsr.tipe == "Gudang")
                {
                    infologin.Text = "Gudang";
                    panel3.Controls.Clear();
                    GudangProduk a = new GudangProduk();
                    a.TopLevel = false;
                    panel3.Controls.Add(a);
                    a.Dock = DockStyle.Fill;
                    a.Show();

                }
                else if (LoginPage.mUsr.tipe == "Kasir")
                {
                    infologin.Text = "Kasir";
                    panel3.Controls.Clear();
                    KasirTransaksi a = new KasirTransaksi();
                    a.TopLevel = false;
                    panel3.Controls.Add(a);
                    a.Dock = DockStyle.Fill;
                    a.Show();
                }
                tambahlog("Login");
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            tambahlog("Logout");
            Navigation_Load(this, EventArgs.Empty);
        }
        public void tambahlog(string aktivitas)
        {
            con.setQuery("INSERT INTO tb_log(waktu, aktivitas, id_user) VALUES (@waktu, @aktivitas, @id_user)");
            con.parmDate("waktu", DateTime.Now);
            con.parmString("aktivitas", aktivitas);
            con.parmInt("id_user", LoginPage.mUsr.id);
            con.execQuery();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            AdminLog a = new AdminLog();
            a.TopLevel = false;
            panel3.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            a.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            AdminUser a = new AdminUser();
            a.TopLevel = false;
            panel3.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            AdminLaporan a = new AdminLaporan
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            panel3.Controls.Add(a);
            a.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            waktu.Text = DateTime.Now.ToLongDateString() + "\n" + DateTime.Now.ToLongTimeString();
        }
    }
}
