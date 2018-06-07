using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_ED
{
    class Uczestnik
    {
        public string imie { get; set; }
        public double wiek { get; set; }

        public Uczestnik(string _imie, double _wiek)
        {
            imie = _imie;
            wiek = _wiek;
        }

        public void StarzenieSie()
        {
            wiek += 0.1;
        }
    }
}