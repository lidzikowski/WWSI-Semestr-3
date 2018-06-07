using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_LI
{
    class Pizza : Produkt
    {
        public Pizza(string _nazwa, int _temperatura_pieczenia, double _czas_pieczenia, string[] _model) : base(_nazwa, _temperatura_pieczenia, _czas_pieczenia)
        {
            model = _model;
        }
        public Pizza(string _nazwa, int _temperatura_pieczenia, double _czas_pieczenia) : base(_nazwa, _temperatura_pieczenia, _czas_pieczenia)
        {
            model = new string[] {
                @"__o,_oo__.o_",
                @"\__________/"
            };
        }
        public Pizza() : this("Pizza", 160, 8.0) { }

        public override void WyswietlProdukt(int wysokosc)
        {
            int szerokosc = (Console.BufferWidth / 2) - (model[0].Length / 2);
            Rysowanie(szerokosc, wysokosc);
        }
    }
}