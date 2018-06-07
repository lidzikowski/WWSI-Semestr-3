using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_RW
{
    class Malowanie
    {
        // Publiczne wlasciwosci
        public ConsoleColor kolor { get; set; }

        // Publiczna zmienna
        private string rodzaj;

        // Konstruktor klasy
        public Malowanie(ConsoleColor _kolor, string _rodzaj = "Metalik")
        {
            kolor = _kolor;
            rodzaj = _rodzaj;
        }

        // Publiczna funkcja kolorujaca konsole na zdefiniowany kolor
        public void Koloruj()
        {
            Console.ForegroundColor = kolor;
        }

        // Funkcja zwracajaca rodzaj malowania
        public string RodzajMalowania()
        {
            return rodzaj;
        }
    }
}