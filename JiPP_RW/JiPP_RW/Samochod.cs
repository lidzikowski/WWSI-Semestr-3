using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_RW
{
    // Klasa abstrakcyjna
    abstract class Samochod
    {
        // publiczna wlasciwosc
        public string marka { get; set; }

        // publiczne wlasciwosci
        protected string[] model { get; set; }

        // Publiczny konstruktor
        protected Samochod(string _marka)
        {
            marka = _marka;
        }
        // Przeciazenie konsturktora
        public Samochod(string _marka, string[] _model) : this(_marka)
        {
            model = _model;
        }

        // Wirtualna metoda wyswietlania pojazdu
        public virtual void WyswietlPojazd()
        {
            int left = (Console.BufferWidth / 2) - (model[0].Length / 2);
            int top = 5;

            // Wywolanie funkcji - bazowej
            Rysuj(left, top);
        }

        // Prywatna metoda klasy
        protected void Rysuj(int left, int top)
        {
            for (int i = 0; i < model.Length; i++)
            {
                Console.SetCursorPosition(left, top++);
                Console.Write(model[i]);
            }
        }
    }
}