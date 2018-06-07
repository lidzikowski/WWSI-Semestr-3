using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_AR
{
    // Publiczna klasa Samsung dziedziczaca wszystko z klasy abstrakcyjnej Telewizor
    class Samsung : Telewizor
    {
        // Publiczny konstruktor klasy z wywolaniem konstruktora bazowego
        public Samsung(ConsoleColor _kolor):base(_kolor)
        {
            // Przypisywanie tablicy stringow jako model telewizora
            model = new string[]
            {
                @"-----------------------",
                @"|                     |",
                @"|                     |",
                @"|                     |",
                @"|                     |",
                @"|                     |",
                @"--------Samsung--------"
            };
        }

        // Nadpisanie bazowej wirtualnej metody
        public override void Wyswietl()
        {
            // Szerokosc aby model byl centralnie na srodku
            int szerokosc = (Console.BufferWidth / 2) - (model[0].Length / 2); 
            int wysokosc = 4; // Wysokosc rysowania modelu

            // Wywolanie metody rysowania
            Rysowanie(szerokosc, wysokosc);
        }
    }
}