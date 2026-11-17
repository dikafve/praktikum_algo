namespace Modul5_GudangOOP.Models;

public class Barang
{
    public string KodeBarang { get; set; }
    public string NamaBarang { get; set; }
    public int JumlahStok { get; set; }
    public string Kategori { get; set; }

    public Barang(string kode, string nama, int stok, string kategori)
    {
        KodeBarang = kode;
        NamaBarang = nama;
        JumlahStok = stok;
        Kategori = kategori;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine($"[{KodeBarang}] {NamaBarang} - Stok: {JumlahStok}, Kategori: {Kategori}");
    }
}