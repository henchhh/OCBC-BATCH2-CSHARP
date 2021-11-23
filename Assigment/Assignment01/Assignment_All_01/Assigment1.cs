using System;

namespace Assignment_All_01
{
    public class Assigment1
    {
        public static void Main(string[] args)
        {
            string input_kembali;
            //bool isYes = input_kembali.Equals("y") || input_kembali.Equals("Y");
            int input_menu;
            do
            {
                Console.Clear();
                Console.WriteLine("=== SELAMAT DATANG DI ASSIGNMENT 1 ===");
                Console.WriteLine("\nNama lengkap saya : Deandri Firdaus");
                Console.WriteLine("Nomor peserta saya : FSDO002ONL013");
                Console.WriteLine("Alamat saya : Jakarta Selatan");
                Console.WriteLine("\nMenu Soal: ");
                Console.WriteLine("1. Soal Piramida Alfabet");
                Console.WriteLine("2. Soal Piramida Angka");
                Console.WriteLine("3. Soal Factorial");
                Console.WriteLine("4. Soal Reversed Number");
                Console.WriteLine("5. Soal Number to String");
                Console.WriteLine("6. About / Tentang Saya");
                Console.WriteLine("7. Exit");
                Console.WriteLine("\nPilih menu soal(1-7): ");
                input_menu = Convert.ToInt32(Console.ReadLine());
                switch (input_menu)
                {
                    case 1:
                        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                        Console.WriteLine("\n=== PIRAMIDA ALFABET ===");
                        Console.WriteLine("Selamat datang di piramida alfabet");
                        Console.Write("Masukkan banyak baris yang diinginkan(maksimal 26 baris): ");
                        int input = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= input; i++)
                        {
                            for (int j = input; j > i; j--)
                            {
                                Console.Write(" ");
                            }
                            for (int k = 0; k < i; k++)
                            {
                                Console.Write(alphabet[k]);
                            }
                            int l = 1;
                            int m = (i - 1) - l;
                            while (m >= 0)
                            {
                                Console.Write(alphabet[m]);
                                m--;
                            }
                            l++;
                            Console.WriteLine("");
                        }
                        break;
                    case 2:
                        char[] angka = "123456789".ToCharArray();
                        Console.WriteLine("\n=== PIRAMIDA ANGKA ===");
                        Console.WriteLine("Selamat datang di piramida angka");
                        Console.Write("Masukkan banyak baris yang diinginkan(maksimal 9 baris): ");
                        input = int.Parse(Console.ReadLine());
                        for (int i = 1; i <= input; i++)
                        {
                            for (int j = input; j > i; j--)
                            {
                                Console.Write(" ");
                            }
                            for (int k = 0; k < i; k++)
                            {
                                Console.Write(angka[k]);
                            }
                            int l = 1;
                            int m = (i - 1) - l;
                            while (m >= 0)
                            {
                                Console.Write(angka[m]);
                                m--;
                            }
                            l++;
                            Console.WriteLine("");
                        }
                        break;
                    case 3:
                        int factorial = 1;
                        Console.WriteLine("\n=== FACTORIAL ===");
                        Console.WriteLine("Selamat datang di factorial");
                        Console.Write("Enter any Number: ");
                        input = Convert.ToInt32(Console.ReadLine());
                        if (input == 0)
                        {
                            factorial = 1;
                            Console.WriteLine($"Factorial of {input} is: {factorial}");
                        }
                        else
                        {
                            for (int i = 1; i <= input; i++)
                            {
                                factorial = factorial * i;
                            }
                            Console.WriteLine($"Factorial of {input} is: {factorial}");
                        }
                        break;
                    case 4:
                        Console.WriteLine("\n=== REVERSED NUMBER ===");
                        Console.WriteLine("Selamat datang di reversed number");
                        Console.Write("Enter a number: ");
                        string input_new = (Console.ReadLine());
                        char[] input_array = input_new.ToCharArray();
                        int last_index = input_array.Length - 1;
                        Console.Write("Reversed number: ");
                        for (int i = last_index; i >= 0; i--)
                        {
                            Console.Write(input_array[i] + "");
                        }
                        Console.WriteLine("");
                        break;
                    case 5:
                        Console.WriteLine("\n=== NUMBER TO STRING ===");
                        Console.WriteLine("Selamat datang di number to string");
                        Console.Write("Enter the Number= ");
                        string input_new1 = (Console.ReadLine());
                        char[] input_array_new = input_new1.ToCharArray();
                        for (int i = 0; i <= input_array_new.Length - 1; i++)
                        {
                            switch (input_array_new[i])
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
                        Console.WriteLine("");
                        break;
                    case 6:
                        Console.WriteLine("\n=== TENTANG SAYA ===");
                        Console.WriteLine("Selamat datang di menu tentang saya");
                        Console.WriteLine("\nPerkenalkan saya Deandri Firdaus, biasa dipanggil Dean.");
                        Console.WriteLine("Saya lulusan Teknik Informatika Universitas Gunadarma");
                        Console.WriteLine("Mohon bantuannya selama bertahun-tahun ke depan.");
                        Console.WriteLine("Terima kasih!");
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("\nInputan salah, mohon input dari angka 1 sampai 7");
                        break;
                }
                Console.Write("\nKembali ke menu awal? (Y/N): ");
                input_kembali = Console.ReadLine();
            } while (input_kembali.Equals("y") || input_kembali.Equals("Y"));
        }
    }
}