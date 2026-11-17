using Modul4_GudangOOP.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== UJI COBA ABSTRACT CLASS & INTERFACE ===\n");

        ItemGudang item1 = new BarangKimia("KIM001", "Asam Sulfat");
        ItemGudang item2 = new BarangMakanan("MAK001", "Susu Kental", DateTime.Parse("2023-12-01"));

        item1.CetakInfo();
        Console.WriteLine(item1.EvaluasiResiko());

        Console.WriteLine();

        item2.CetakInfo();
        Console.WriteLine(item2.EvaluasiResiko());

        // Pemeriksaan Interface (Pattern Matching)
        if (item2 is IPeriksaKadaluarsa periksa)
        {
            Console.WriteLine(periksa.ApakahKadaluarsa() ? "Kadaluarsa" : "Masih berlaku");
        }
    }
}