using System;

namespace Overloading01
{
    public class data
    {
        public string nama;

        private double nomor_telepon;

        public void print(string nama)
        {
            this.nama = nama;
            Console.WriteLine("\nNamanya adalah : {0}", this.nama);
        }

        public void print(double nomor_telepon)
        {
            this.nomor_telepon = nomor_telepon;
            Console.WriteLine("\nNomor HP : {0}", this.nomor_telepon);
        }

    }
}