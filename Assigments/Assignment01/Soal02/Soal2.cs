using System;

namespace Soal02
{
    public class Soal2
    {
        public static void Main(string[] args)
        {
            int input;
            char[] angka = "123456789".ToCharArray();
            Console.WriteLine("=== PIRAMIDA ANGKA ===");
            Console.WriteLine("Selamat datang di piramida angka");
            Console.Write("Masukkan banyak baris yang diinginkan: ");
            input = int.Parse(Console.ReadLine());
            for(int i = 1; i<=input; i++)
            {
                for(int j = input; j>i; j--)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k<i;k++)
                {
                    Console.Write(angka[k]);
                }
                int l = 1;
                int m = (i-1)-l;
                while(m>=0)
                {
                    Console.Write(angka[m]);
                    m--;
                }
                l++;
                Console.WriteLine("");
            }
        }
    }
}