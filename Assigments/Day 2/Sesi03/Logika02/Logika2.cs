using System;

namespace Logika02
{
    public class Logika2{
        public static void Main(string[] args)
        {
            int nilai = 75;

            if (nilai < 60)
            {
                Console.WriteLine("Nilai Kamu C");
            }
            else if (nilai < 80)
            {
                Console.WriteLine("Nilai Kamu B");
            }
            else
            {
                Console.WriteLine("Nilai Kamu A");
            }
        }
    }
}