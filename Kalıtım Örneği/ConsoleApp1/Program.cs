using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ucak uck = new ucak();

            uck.MARKA = "Türk Hava Yolları";
            uck.KALKIS = "ADANA - Şakirpaşa";
            uck.VARIS = "İstanbul - Sabiha Gökçen";
            uck.ADI = "Emre";
            uck.SOYADI = "Karay";
            uck.CİNSİYET = "Erkek";

            Console.WriteLine("Hava Yolu : "+ uck.MARKA);
            Console.WriteLine("Kalkış Yeri : "+ uck.KALKIS);
            Console.WriteLine("Varış Yeri : "+ uck.VARIS);
            Console.WriteLine("Ad : "+ uck.ADI);
            Console.WriteLine("Soyad : "+uck.SOYADI);
            Console.WriteLine("Cinsiyet : "+ uck.CİNSİYET);

        }
    }
}
