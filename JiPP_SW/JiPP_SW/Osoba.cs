using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_SW
{
    // Klasa abstrakcyjna
    abstract class Osoba
    {
        // Publiczne wlasciwosci klasy
        public string imie { get; set; }
        public string nazwisko { get; set; }
        private int wiek { get; set; }

        // Konstruktor klasy
        public Osoba(string _imie, string _nazwisko, int _wiek)
        {
            imie = _imie;
            nazwisko = _nazwisko;
            wiek = _wiek;
        }

        // Wirtualna metoda zwracajaca wiek obiektu
        public virtual int DajWiek()
        {
            return wiek;
        }

        // Metoda zwiekszajaca wiek obiektu
        public virtual void ZwiekszWiek()
        {
            wiek++;
        }

        // Publiczna metoda wyswietlajaca smierc obiektu
        public void Smierc()
        {
            Console.SetCursorPosition(2, 5);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(imie + " " + nazwisko);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" umarl w wieku ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(wiek);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" lat.");
        }
    }
}