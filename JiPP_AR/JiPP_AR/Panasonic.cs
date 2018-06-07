using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_AR
{
    // Publiczna klasa Panasonic dziedziczaca wszystko z klasy abstrakcyjnej Telewizor
    class Panasonic : Telewizor
    {
        // Prywatna zmienna
        private string kod_producenta;

        // Prywatna nadpisana wlasciwosc modyfikujaca prywatna zmienna i zwracajaca ja
        public override string kodProducenta
        {
            get
            {
                return kod_producenta;
            }
            set
            {
                kod_producenta = value;
            }
        }

        // Publiczny konstruktor klasy z wywolaniem konstruktora bazowego
        public Panasonic(ConsoleColor _kolor) : base(_kolor)
        {
            // Przypisywanie tablicy stringow jako model telewizora
            model = new string[]
            {
                @"----------------------------",
                @"|                          |",
                @"|                          |",
                @"|                          |",
                @"|                          |",
                @"|                          |",
                @"|                          |",
                @"|                          |",
                @"----------Panasonic---------"
            };
        }

        // Przeciazenie konstruktora
        // Publiczny konstruktor z wywolaniem innego konstruktora w tej klasie
        public Panasonic() : this(ConsoleColor.DarkYellow)
        {

        }
    }
}