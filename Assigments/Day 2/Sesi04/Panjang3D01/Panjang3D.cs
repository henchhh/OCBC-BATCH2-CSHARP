using System;

namespace Length01
{
    public class Length{
        public static void Main(string[] args)
        {
            int[, ,] angka = new int[10,5,6];
            Console.Write("Panjang array angka adalah "+angka.Length);
        }
    }
}