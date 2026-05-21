namespace asek.Model
{
    public class ModelDetailTransaksi
    {
        public int id { get; set; }
        public int id_transaksi { get; set; }
        public string kode { get; set; }
        public string nama { get; set; }
        public int jumlah { get; set; }
        public long harga { get; set; }
        public int id_produk { get; set; }
    }
}
