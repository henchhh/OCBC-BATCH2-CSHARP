using System;

namespace Soal05
{
    public class Soal5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== NUMBER TO STRING ===");
            Console.WriteLine("Selamat datang di number to string");
            Console.Write("Enter the Number= ");
            string input = (Console.ReadLine());
            char[] input_array = input.ToCharArray();
            for (int i = 0; i <= input_array.Length-1; i++)
            {
                switch (input_array[i])
                {
                    case '0':
                        Console.Write("zero ");
                        break;
                    case '1':
                        Console.Write("one ");
                        break;
                    case '2':
                        Console.Write("two ");
                        break;
                    case '3':
                        Console.Write("three ");
                        break;
                    case '4':
                        Console.Write("four ");
                        break;    
                    case '5':
                        Console.Write("five ");
                        break; 
                    case '6':
                        Console.Write("six ");
                        break;
                    case '7':
                        Console.Write("seven ");
                        break;      
                    case '8':
                        Console.Write("eight ");
                        break;      
                    case '9':
                        Console.Write("nine ");
                        break;             
                    default:
                        Console.Write("Number only please!");
                        break;               
                }
            }    
        }
    }
}