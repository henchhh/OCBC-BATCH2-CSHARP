using System;

namespace Project3
{
    class PendaftaranPenduduk
    {
        static void Main(string[] args)
        {
            string nama;
            int umur;

            Console.WriteLine("=== PROGRAM PENDAFTARAN PENDUDUK ===");
            Console.WriteLine("Masukkan nama: ");
            nama = Console.ReadLine();
            Console.WriteLine("Masukkan alamat: ");
            var alamat = Console.ReadLine();
            Console.WriteLine("Masukkan umur: ");
            umur = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Terima kasih!");
            Console.WriteLine("Data Berikut");
            Console.WriteLine($"Nama: {nama}");
            Console.WriteLine($"Alamat: {alamat}");
            Console.WriteLine($"Umur: {umur}");
            Console.WriteLine("SUDAH DISIMPAN!");
        }
    }
}
