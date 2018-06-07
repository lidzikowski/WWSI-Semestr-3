using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_AR
{
    // Klasa abstrakcyjna
    abstract class Telewizor
    {
        // Publiczne wlasciwosci
        public ConsoleColor kolor { get; set; }
        public virtual string kodProducenta { get; set; } // Wirtualna

        // Prywatna wlasciwosc
        protected string[] model { get; set; }

        // Prywatne zmienne
        private int szerokosc;
        private int wysokosc;

        // Konstruktor klasy abstrakcyjnej
        protected Telewizor(ConsoleColor _kolor)
        {
            kolor = _kolor;
        }

        // Publiczna wirtualna metoda obliczajaca szerokosc i wysokosc konsoli oraz wywolujaca metode rysowania modelu na konsoli
        public virtual void Wyswietl()
        {
            // Szerokosc aby model byl centralnie na srodku
            szerokosc = (Console.BufferWidth / 2) - (model[0].Length / 2);
            // Wysokosc rysowania modelu
            wysokosc = 2;

            // Wywolanie metody rysowania
            Rysowanie(szerokosc, wysokosc);
        }

        // Prywatna metoda widoczna w klasach ktore dziedzicza klase abstrakcyjna rysujaca model
        protected void Rysowanie(int szerokosc, int wysokosc)
        {
            Console.ForegroundColor = kolor; // Ustawienie koloru
            // Petla rysujaca model telewizora na konsoli
            for (int i = 0; i < model.Length; i++)
            {
                Console.SetCursorPosition(szerokosc, wysokosc++); // Ustawienie wskaznika
                Console.Write(model[i]); // Rysowanie z modelu
            }
        }
    }
}