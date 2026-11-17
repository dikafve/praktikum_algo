using System;
using System.Collections.Generic;
using System.IO;
using Modul6_GudangOOP.Exceptions;
using Modul6_GudangOOP.Models;

class Program
{
    static string filePath = "stok.txt";
    static List<Barang> daftarBarang = new List<Barang>();

    static void Main()
    {
        // 1. Load data dari file stok.txt ke memori RAM terlebih dahulu
        MuatDataDariFile();

        Console.WriteLine("=== 1. PENANGANAN EXCEPTION & INPUT INTERAKTIF ===");
        TambahBarangInteraktif();

        Console.WriteLine("\n=== 2. OPERASI FILE I/O (MENULIS KE STOK.TXT) ===");
        SimpanKeFile();

        Console.WriteLine("\n=== 3. OPERASI FILE I/O (MEMBACA BARIS DARI STOK.TXT) ===");
        BacaDariFile();
    }

    // Method baru: Memuat data dari stok.txt ke daftarBarang saat program start
    static void MuatDataDariFile()
    {
        try
        {
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            daftarBarang.Add(Barang.FromCsv(line));
                        }
                    }
                }
            }
            else
            {
                // Jika file stok.txt belum ada sama sekali, buat sampel data awal
                daftarBarang.Add(new Barang("B001", "Laptop", 30));
                daftarBarang.Add(new Barang("B002", "Smartphone", 60));
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[Warning] Gagal memuat data awal: {ex.Message}");
        }
    }

    static void TambahBarangInteraktif()
    {
        try
        {
            Console.Write("Masukkan Kode Barang: ");
            string kode = Console.ReadLine()!;

            // Validasi duplikasi kode barang (sekarang B001 & B002 dari stok.txt sudah terdeteksi)
            if (daftarBarang.Exists(b => b.KodeBarang.Equals(kode, StringComparison.OrdinalIgnoreCase)))
            {
                throw new KodeBarangDuplikatException($"Kode barang '{kode}' sudah terdaftar di sistem!");
            }

            Console.Write("Masukkan Nama Barang: ");
            string nama = Console.ReadLine()!;

            Console.Write("Masukkan Jumlah Stok: ");
            int stok = int.Parse(Console.ReadLine()!);

            Barang barangBaru = new Barang(kode, nama, stok);
            daftarBarang.Add(barangBaru);
            Console.WriteLine("Barang berhasil ditambahkan!");
        }
        catch (FormatException)
        {
            Console.WriteLine("[Error Format] Input stok harus berupa angka integer!");
        }
        catch (StokNegatifException ex)
        {
            Console.WriteLine($"[Custom Error] {ex.Message}");
        }
        catch (KodeBarangDuplikatException ex)
        {
            Console.WriteLine($"[Custom Error] {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[Error Umum] Terjadi kesalahan: {ex.Message}");
        }
    }

    static void SimpanKeFile()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var b in daftarBarang)
                {
                    writer.WriteLine(b.ToCsv());
                }
            }
            Console.WriteLine($"Data berhasil disimpan ke file '{filePath}'.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"[Error I/O] Gagal menulis ke file: {ex.Message}");
        }
    }

    static void BacaDariFile()
    {
        try
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"File '{filePath}' tidak ditemukan.");
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string? line;
                Console.WriteLine($"=== Isi File {filePath} ===");
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine($"[Error File] {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[Error Umum] Gagal membaca file: {ex.Message}");
        }
    }
}