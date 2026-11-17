using System;
using System.Collections.Generic;
using Modul5_GudangOOP.Models;

class Program
{
    // Implementation Method Generic AmbilPertama<T> (Jawaban Nomor 1)
    public static T? AmbilKedua<T>(List<T> list)
    {
        // Pengecekan jika list null atau kosong untuk keamanan
        if (list == null || list.Count < 3)
        {
            return default(T); // Mengembalikan nilai default dari tipe T
        }

        // Mengembalikan elemen kedua (indeks 2)
        return list[2]; // Mengembalikan elemen kedua
    }

    static void Main()
    {
        Console.WriteLine("=== UJI COBA METHOD GENERIC AmbilKedua<T> ===\n");

        // 1. Pengujian pada List<Barang>
        List<Barang> daftarBarang = new List<Barang>
        {
            new Barang("BRG001", "Karton Kemasan", 100, "Kemasan"),
            new Barang("BRG002", "Peti Kayu", 50, "Penyimpanan"),
            new Barang("BRG003", "Bubble Wrap", 200, "Pelindung")
        };

        Barang? barangPertama = AmbilKedua(daftarBarang);

        Console.WriteLine("--- Hasil AmbilKedua pada List<Barang> ---");
        if (barangPertama != null)
        {
            barangPertama.TampilkanInfo();
        }

        Console.WriteLine();

        // 2. Pengujian pada List<string> (Membuktikan Fleksibilitas Generic)
        List<string> daftarKategori = new List<string> { "Kemasan", "Penyimpanan", "Pelindung" };

        string? kategoriPertama = AmbilKedua(daftarKategori);

        Console.WriteLine("--- Hasil AmbilKedua pada List<string> ---");
        Console.WriteLine($"Kategori Kedua: {kategoriPertama}");

        Console.WriteLine();

        // 3. Pengujian pada List Kosong
        List<int> listKosong = new List<int>();
        int angkaPertama = AmbilKedua(listKosong);

        Console.WriteLine("--- Hasil AmbilKedua pada List Kosong (int) ---");
        Console.WriteLine($"Nilai Default: {angkaPertama}");
    }
}