using System;

namespace Konsep01
{
    class Program
    {
        public static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop();

            Console.Write("Masukkan merk laptop: ");
            laptop1.merk = Console.ReadLine();
            Console.Write("Masukkan ram laptop: ");
            laptop1.ram = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan memory laptop: ");
            laptop1.memory = Convert.ToInt32(Console.ReadLine());

            // laptop1.merk = "lenovo";
            // laptop1.ram = 4;
            // laptop1.memory = 128;

            Console.WriteLine("\nMerk Laptop adalah {0}", laptop1.merk);
            Console.WriteLine("Kapasitas Ram adalah {0}", laptop1.ram);
            Console.WriteLine("Kapasitas Memory adalah {0}", laptop1.memory);

            laptop1.Chatting();
            laptop1.Sosmed();
            laptop1.OnlineShop();
        }
    }
}