using System.Reflection;
using System.Windows.Forms;

namespace asek.Kasir
{
    public partial class InputJumlah : Form
    {
        public string jumlah { get; set; }
        public bool aksi { get; set; }
        public InputJumlah(int x, int y)
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point(x, y);
            aksi = false;
        }

        private void ini_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == (char)Keys.Escape || e.KeyChar == 13 || e.KeyChar == (char)Keys.Back)
                e.Handled = false;
            else
                e.Handled = true;
            if (ini.Text != "")
            {
                if (e.KeyChar == 13)
                {
                    jumlah = ini.Text;
                    aksi = true;
                    this.Close();
                }
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        private void InputJumlah_Load(object sender, System.EventArgs e)
        {
            this.Size = new System.Drawing.Size(125, 23);
        }
    }
}
