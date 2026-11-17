namespace Modul3_GudangOOP.Models;

public class BarangMakanan : Barang
{
    public DateTime TanggalKadaluarsa { get; set; }

    public BarangMakanan(string kode, string nama, int stok, string kategori, DateTime kadaluarsa)
        : base(kode, nama, stok, kategori)
    {
        TanggalKadaluarsa = kadaluarsa;
    }

    public override void TampilkanInfo()
    {
        base.TampilkanInfo();
        Console.WriteLine($"Kadaluarsa: {TanggalKadaluarsa:dd-MM-yyyy}");
    }
}