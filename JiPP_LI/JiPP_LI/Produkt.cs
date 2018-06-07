using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_LI
{
    abstract class Produkt
    {
        public string nazwa { get; set; }
        public int temperatura_pieczenia { get; set; }

        protected string[] model { get; set; }

        private ConsoleColor kolor { get; set; }

        protected Produkt(string _nazwa, int _temperatura_pieczenia, double _czas_pieczenia)
        {
            nazwa = _nazwa;
            temperatura_pieczenia = _temperatura_pieczenia;

            kolor = ConsoleColor.White;
        }
        public Produkt(string _nazwa, int _temperatura_gotowosci, double _czas_pieczenia, string[] _model) : this(_nazwa, _temperatura_gotowosci, _czas_pieczenia)
        {
            model = _model;
        }

        public int WysokoscProduktu()
        {
            return model.Length;
        }

        public void ZmienKolorProduktuo(ConsoleColor nowy_kolor)
        {
            kolor = nowy_kolor;
        }

        public virtual void WyswietlProdukt(int wysokosc)
        {
            int szerokosc = (Console.BufferWidth / 2) - (model[0].Length / 2);
            Rysowanie(szerokosc, wysokosc);
        }

        protected void Rysowanie(int szerokosc, int wysokosc)
        {
            Console.ResetColor();
            Console.ForegroundColor = kolor;
            for (int i = 0; i < model.Length; i++)
            {
                Console.SetCursorPosition(szerokosc, wysokosc++);
                Console.Write(model[i]);
            }
        }
    }
}