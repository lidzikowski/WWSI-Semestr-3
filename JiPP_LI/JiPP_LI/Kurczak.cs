using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_LI
{
    class Kurczak : Produkt
    {
        public Kurczak(string _nazwa, int _temperatura_pieczenia, double _czas_pieczenia, string[] _model) : base(_nazwa, _temperatura_pieczenia, _czas_pieczenia)
        {
            model = _model;
        }
        public Kurczak(string _nazwa, int _temperatura_pieczenia, double _czas_pieczenia) : base(_nazwa, _temperatura_pieczenia, _czas_pieczenia)
        {
            model = new string[] {
                @"  _O_  ",
                @" /   \ ",
                @"\|   |/",
                @" |___| ",
                @" /   \ "
            };
        }
        public Kurczak() : this("Kurczak", 180, 10.0) { }
    }
}