using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class emlak
    {

        private string semt;
        private string renk;
        private int odasayisi;
        private int katno;
        private double alan;

        public string SEMT
        {
            get { return semt; }
            set { semt = value.ToUpper(); }
            
        }
        public string RENGİ
        {
            get { return renk; }
            set { renk = value.ToLower(); }
        }

        public int ODASAYİSİ
        {
            get { return odasayisi; }
            set { odasayisi = Math.Abs(value); }
        }

        public int KATNUMARA
        {
            get { return katno; }
            set { katno = Math.Abs(value); }

        }
        public double ALAN
        {
            get { return alan; }
            set { alan = Math.Abs(value); }
        }


    }
}
