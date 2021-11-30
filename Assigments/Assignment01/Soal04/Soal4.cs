using System;

namespace Soal04
{
    public class Soal4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== REVERSED NUMBER ===");
            Console.WriteLine("Selamat datang di reversed number");
            Console.Write("Enter a number: ");
            string input = (Console.ReadLine());
            char[] input_array = input.ToCharArray();
            int last_index = input_array.Length-1;
            Console.Write("Reversed number: ");
            for(int i=last_index; i>=0; i--)
            {               
                Console.Write(input_array[i]+"");
            }          
        }
    }
}