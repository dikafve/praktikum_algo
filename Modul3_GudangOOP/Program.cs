using Modul3_GudangOOP.Models;

class Program
{
    static void Main()
    {
        // Langkah 3: polymorphism
        Barang b1 = new Barang("BRG001", "Peti Plastik", 80, "Kemasan");
        Barang b2 = new BarangElektronik("ELK001", "Handheld Scanner", 10, "Elektronik", 25);

        b1.TampilkanInfo();
        b2.TampilkanInfo();   // tipe Barang, tapi yang jalan versi override BarangElektronik

        Console.WriteLine();

        // Langkah 4: array bertipe Barang[]
        Barang[] daftarBarang = new Barang[]
        {
            new Barang("BRG002", "Kotak Kayu", 30, "Kemasan"),
            new BarangElektronik("ELK002", "Printer Laser", 5, "Elektronik", 150),
            new BarangMakanan("MKN001", "Biskuit", 100, "Makanan", new DateTime(2027, 3, 1))
        };

        foreach (var barang in daftarBarang)
        {
            barang.TampilkanInfo();   // otomatis pilih versi sesuai tipe objek asli
        }
    }
}