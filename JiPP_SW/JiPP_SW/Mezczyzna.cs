using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_SW
{
    // Klasa Mezczyzna dziedziczy abstrakcyjna klase Osoba
    class Mezczyzna : Osoba
    {
        // Konstruktor klasy
        public Mezczyzna(string _imie, string _nazwisko, int _wiek) : base(_imie, _nazwisko, _wiek)
        {

        }

        // Publiczna nadpisana metoda
        public override int DajWiek()
        {
            return base.DajWiek() + 10;
        }
    }
}
