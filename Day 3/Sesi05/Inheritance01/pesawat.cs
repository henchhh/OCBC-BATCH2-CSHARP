using System;

namespace Inheritance01
{
    public class pesawat
    {
        public string Nama, Ketinggian, JumlahPenumpang;
        public int JumlahRoda;

        public void terbang()
        {
            Console.WriteLine("\nClass pesawat, pesawat dengan nama {0} "+
                            "yang mempunyai jumlah roda {1}, sedang berada pada ketinggian {2} dengan membawa" +
                            "jumlah penumpang sebanyak {3} akan meledakkan senjata", this.Nama, 
                            this.JumlahRoda, this.Ketinggian, this.JumlahPenumpang);
        }
    }

    class pesawat_tempur : pesawat
    {
        public void terbangtinggi()
        {
            Console.WriteLine("\nClass pesawat, pesawat terbangtinggi dengan nama {0} "+
                            "yang mempunyai jumlah roda {1}, sedang berada pada ketinggian {2} dengan membawa" +
                            "jumlah penumpang sebanyak {3} akan meledakkan senjata", this.Nama, 
                            this.JumlahRoda, this.Ketinggian, this.JumlahPenumpang);
        }
    }
}