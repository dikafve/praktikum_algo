using Modul1_GudangOOP.Models;
class Program
{
 static void Main()
 {
 Barang b1 = new Barang("BRG001", "Karton", 120, "Kemasan");
 Barang b2 = new Barang("BRG002", "Bubble Wrap", 40, "Pelindung");
 b1.TampilkanInfo();
 b2.TampilkanInfo();
 Console.WriteLine($"Status: {b1.StatusStok()}");
Console.WriteLine($"Status: {b2.StatusStok()}");
Barang b3 = new Barang();
Console.Write("Masukkan Nama Barang: ");
b3.NamaBarang = Console.ReadLine();
Console.Write("Masukkan Kode Barang: ");
b3.KodeBarang = Console.ReadLine();
Console.Write("Masukkan Jumlah Stok: ");
b3.JumlahStok = int.Parse(Console.ReadLine());
Console.Write("Masukkan Kategori: ");
b3.Kategori = Console.ReadLine();
b3.TampilkanInfo();
 }
}