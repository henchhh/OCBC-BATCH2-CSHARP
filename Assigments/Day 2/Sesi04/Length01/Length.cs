using System;

namespace Length01
{
    public class Length{
        public static void Main(string[] args)
        {
            int[] angka = new int[10];
            Console.WriteLine("Panjang array angka adalah "+angka.Length);

            Console.Write("Berikut adalah array angka ");
            for(int i=0; i<angka.Length; i++)
            {
                angka[i] = i*i;
                Console.Write(angka[i]+" ");
            }
        }
    }
}