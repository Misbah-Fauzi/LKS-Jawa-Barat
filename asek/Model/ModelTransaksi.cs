using System;

namespace asek.Model
{
    public class ModelTransaksi
    {
        public int id { get; set; }
        public string nota { get; set; }
        public DateTime tgl { get; set; }
        public int id_user { get; set; }
        public int id_pelanggan { get; set; }
    }
}
