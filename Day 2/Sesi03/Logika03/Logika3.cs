using System;

namespace Logika03
{
    public class Logika3{
        public static void Main(string[] args)
        {
            string username, password;

            Console.Write("Username: ");
            username = Console.ReadLine();
            Console.Write("Password: ");
            password = Console.ReadLine();

            bool isUsernameValid = username == "ocbc";
            bool isPasswordValid = password == "bootcamp";

            if (isUsernameValid && isPasswordValid)
            {
                Console.WriteLine("Anda berhasil login");
            }
            else
            {
                Console.WriteLine("Username atau Password anda salah");
            }
        }
    }
}