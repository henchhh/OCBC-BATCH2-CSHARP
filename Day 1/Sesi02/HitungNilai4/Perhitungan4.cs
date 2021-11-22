using System;

namespace HitungNilai4
{
    class Perhitungan4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            bool isAdult = age > 18;
            bool isPasswordValid = password == "OCBC";

            if(isAdult && isPasswordValid){
                Console.WriteLine("WELCOME TO THE CLUB!");
            }
            else{
                Console.WriteLine("Sorry, try again!");
            }
        }
    }
}
