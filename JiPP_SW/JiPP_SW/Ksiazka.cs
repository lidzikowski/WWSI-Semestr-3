using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_SW
{
    class Ksiazka
    {
        // Publiczne wlasciwosci klasy
        public string autor { get; set; }
        public string tytul { get; set; }

        // Prywatne wlasciwosci klasy
        private int przeznaczenie_wiekowe { get; set; }

        // Konstruktor klasy
        public Ksiazka(string _autor, string _tytul, int _przeznaczenie_wiekowe)
        {
            autor = _autor;
            tytul = _tytul;
            przeznaczenie_wiekowe = _przeznaczenie_wiekowe;
        }

        // Publiczne metody dostepowe
        public int PrzeznaczenieWiekowe()
        {
            return przeznaczenie_wiekowe;
        }
    }
}