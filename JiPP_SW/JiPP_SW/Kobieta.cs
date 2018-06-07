using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_SW
{
    // Klasa Kobieta dziedziczy abstrakcyjna klase Osoba
    class Kobieta : Osoba
    {
        // Konstruktor klasy
        public Kobieta(string _imie, string _nazwisko, int _wiek) : base(_imie, _nazwisko, _wiek)
        {

        }

        // Publiczna nadpisana metoda
        public override int DajWiek()
        {
            // Jezeli wiek obiektu jest wiekszy niz 30, odejmujemy 10 lat
            int wiek = base.DajWiek();
            if (wiek >= 30)
                return wiek - 10;
            else
                return wiek;
        }
    }
}
