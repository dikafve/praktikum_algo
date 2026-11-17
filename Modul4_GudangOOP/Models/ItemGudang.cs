namespace Modul4_GudangOOP.Models;

public abstract class ItemGudang
{
    public string Kode { get; set; }
    public string Nama { get; set; }

    public ItemGudang(string kode, string nama)
    {
        Kode = kode;
        Nama = nama;
    }

    public void CetakInfo()
    {
        Console.WriteLine($"[{Kode}] {Nama}");
    }

    // Method abstract tanpa body, wajib di-override oleh class turunan
    public abstract string EvaluasiResiko();
}