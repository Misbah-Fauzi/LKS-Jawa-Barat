using System;

namespace asek.Model
{
    public class ModelProduk
    {
        public int id { get; set; }
        public string kode { get; set; }
        public string nama { get; set; }
        public DateTime exp { get; set; }
        public int stok { get; set; }
        public long harga { get; set; }
    }
}
