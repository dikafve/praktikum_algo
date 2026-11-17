namespace Modul3_GudangOOP.Models;

public class Barang
{
    public string KodeBarang;
    public string NamaBarang;
    private int jumlahStok;
    public string Kategori { get; set; }

    public int JumlahStok
    {
        get => jumlahStok;
        set { if (value >= 0) jumlahStok = value; }
    }

    public string Status => JumlahStok > 50 ? "Aman" : "Perlu Reorder";

    public Barang() { }

    public Barang(string kode, string nama, int jumlah, string kategori)
    {
        KodeBarang = kode;
        NamaBarang = nama;
        JumlahStok = jumlah;
        Kategori = kategori;
    }

    public virtual void TampilkanInfo()
    {
        Console.WriteLine($"[{KodeBarang}] {NamaBarang} - Stok: {JumlahStok}, Kategori: {Kategori}");
    }
}