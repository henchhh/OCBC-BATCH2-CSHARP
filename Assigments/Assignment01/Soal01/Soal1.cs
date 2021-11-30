using System;

namespace Soal01
{
    public class Soal1
    {
        public static void Main(string[] args)
        {
            int input;
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Console.WriteLine("=== PIRAMIDA ALFABET ===");
            Console.WriteLine("Selamat datang di piramida alfabet");
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
                    Console.Write(alphabet[k]);
                }
                int l = 1;
                int m = (i-1)-l;
                while(m>=0)
                {
                    Console.Write(alphabet[m]);
                    m--;
                }
                l++;
                Console.WriteLine("");
            }
        }
    }
}