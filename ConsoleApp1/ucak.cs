using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ucak : Yolcu  //KALITIM YAPMA YOLU
    {
        private string marka;
        private string kalkis;
        private string varis;

        public string MARKA
        {
            get { return marka; }
            set { marka = value.ToUpper(); }
        }
        public string KALKIS
        {
            get { return kalkis; }
            set { kalkis = value.ToLower(); }
        }
        public string VARIS
        {
            get { return varis; }
            set { varis = value.ToUpper(); }
        }

    }
}
