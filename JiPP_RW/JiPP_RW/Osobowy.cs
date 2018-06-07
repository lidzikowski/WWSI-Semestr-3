using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_RW
{
    // Klasa Osobowy dziedziczy wszystko z klasy abstrakcyjnej Malowanie
    class Osobowy : Samochod
    {

        // Konstruktor odwolujacy sie do klasy bazowej
        public Osobowy(string _marka, string[] _model) : base(_marka, _model)
        {

        }

        // Przeciazenie konstruktora
        public Osobowy(string _marka) : base(_marka)
        {
            // Domyslny model obiektu
            model = new string[]
            {
                @"  __/''''\___ ",
                " (___________]",
                "  o        o"
            };
        }
    }
}