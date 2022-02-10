using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //KAPSULLEME
            emlak eml = new emlak();
            eml.SEMT = "Kadıköy";
            eml.RENGİ = "mavi";
            eml.ODASAYİSİ = 4;
            eml.KATNUMARA = 8;
            eml.ALAN = 80;

            Console.WriteLine("Evin Bulunduğu Semt : "+ eml.SEMT);
            Console.WriteLine("Evin Oda Renkleri : "+ eml.RENGİ);
            Console.WriteLine("Evin Toplam Oda Sayısı : "+ eml.ODASAYİSİ);
            Console.WriteLine("Evin Bulunduğu Kat : "+eml.KATNUMARA);
            Console.WriteLine("Evin Toplam Alanı : "+eml.ALAN + " Metrekare");
        }
    }
}
