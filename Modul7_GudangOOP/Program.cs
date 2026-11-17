using Modul7_GudangOOP.Models;
using Modul7_GudangOOP.Services;
using Modul7_GudangOOP.Interfaces;
using Modul7_GudangOOP.Factories;

class Program
{
    static void Main()
    {
        IBarangPrinter printer = new PencetakBarang();

        Barang b = new Barang("BRG001", "Printer", 50, "Elektronik");
        printer.Cetak(b);

        Console.WriteLine("--- Dari Factory ---");
        printer.Cetak(BarangFactory.BuatBarang("Makanan"));

        Console.WriteLine("--- Input User ---");
        printer.Cetak(new InputBarang().AmbilInput());
    }
}