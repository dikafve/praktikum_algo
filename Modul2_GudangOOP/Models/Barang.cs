namespace Modul2_GudangOOP.Models;

public class Barang
{
    public string KodeBarang;
    public string NamaBarang;
    private int jumlahStok;                    // Langkah 1: field jadi private
    public string Kategori { get; set; }       // Langkah 2: auto-property

    public int JumlahStok                      // Langkah 1: property + validasi
    {
        get => jumlahStok;
        set
        {
            if (value >= 0) jumlahStok = value;
        }
    }

    public string Status => JumlahStok > 50 ? "Aman" : "Perlu Reorder";  // Langkah 5: read-only

    public Barang(string kode, string nama, int jumlah, string kategori)
    {
        KodeBarang = kode;
        NamaBarang = nama;
        JumlahStok = jumlah;                   // PENTING: pakai property (huruf J besar), bukan field
        Kategori = kategori;
    }

    public void TampilkanInfo()
    {
        Console.WriteLine($"Kode    : {KodeBarang}");
        Console.WriteLine($"Nama    : {NamaBarang}");
        Console.WriteLine($"Stok    : {JumlahStok}");   // Langkah 4: pakai property
        Console.WriteLine($"Kategori: {Kategori}");
        Console.WriteLine($"Status  : {Status}");
        Console.WriteLine();
    }
}