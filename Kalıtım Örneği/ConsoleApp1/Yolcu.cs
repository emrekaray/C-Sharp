using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Yolcu
    {
        private string ad;
        private string soyad;
        private int yas;
        private string cinsiyet;

        public string ADI
        {
            get { return ad; }
            set { ad = value.ToLower(); }
        }
        public string SOYADI
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }
        }
        public int YAS
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }
        public string CİNSİYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value.ToLower(); }
        }
    }
}
