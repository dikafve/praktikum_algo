using Modul6_GudangOOP.Exceptions;

namespace Modul6_GudangOOP.Models;

public class Barang
{
    public string KodeBarang { get; set; }
    public string NamaBarang { get; set; }

    private int jumlahStok;
    public int JumlahStok
    {
        get => jumlahStok;
        set
        {
            if (value < 0)
            {
                throw new StokNegatifException("Jumlah stok tidak boleh negatif.");
            }
            jumlahStok = value;
        }
    }

    public Barang(string kode, string nama, int stok)
    {
        KodeBarang = kode;
        NamaBarang = nama;
        JumlahStok = stok;
    }

    public string ToCsv()
    {
        return $"{KodeBarang}|{NamaBarang}|{JumlahStok}";
    }

    public static Barang FromCsv(string csvLine)
    {
        var parts = csvLine.Split('|');
        return new Barang(parts[0], parts[1], int.Parse(parts[2]));
    }
}