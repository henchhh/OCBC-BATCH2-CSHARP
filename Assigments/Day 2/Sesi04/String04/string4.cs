using System;

namespace Length01
{
    public class Length{
        public static void Main(string[] args)
        {
            string stringawal = "C# membuat string mudah.";

            string substr = stringawal.Substring(5, 12);

            Console.WriteLine("stringawal: "+stringawal);
            Console.WriteLine("substring: "+substr);
        }
    }
}