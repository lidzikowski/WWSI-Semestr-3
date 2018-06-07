using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_RW
{
    // Klasa Dostawczy dziedziczy wszystko z klasy abstrakcyjnej Malowanie
    class Dostawczy : Samochod
    {

        // Konstruktor odwolujacy sie do klasy bazowej
        public Dostawczy(string _marka, string[] _model) : base(_marka, _model)
        {

        }

        // Przeciazenie konstruktora
        public Dostawczy(string _marka) : base(_marka)
        {
            // Domyslny model obiektu
            model = new string[]
            {
                @"  _______''''\ ",
                " (___________]",
                " (___________]",
                "  o        o"
            };
        }

        // Publiczna metoda nadpisujaca funkcje bazowa / wirtualna
        public override void WyswietlPojazd()
        {
            int left = (Console.BufferWidth / 2) - (model[0].Length / 2);
            int top = 10;

            // Wywolanie funkcji - bazowej
            Rysuj(left, top);
        }
    }
}
