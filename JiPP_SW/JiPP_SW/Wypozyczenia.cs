using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_SW
{
    class Wypozyczenia
    {
        // Publiczne wlasciwosci klasy
        public Osoba osoba { get; set; }
        public Ksiazka ksiazka { get; set; }
        public string opis { get; set; }

        // Konstruktor
        public Wypozyczenia(Osoba _osoba, Ksiazka _ksiazka)
        {
            osoba = _osoba;
            ksiazka = _ksiazka;
        }
        // Konstruktor przeciazony z odwolaniem do konstruktora wyzej
        public Wypozyczenia(Osoba _osoba, Ksiazka _ksiazka, string _opis):this(_osoba,_ksiazka)
        {
            opis = _opis;
        }

        public int Wyswietl(int lewo, int gora, int index)
        {
            int tmp = ++gora;
            Console.SetCursorPosition(lewo, tmp++);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(index + "  " + osoba.imie + " " + osoba.nazwisko);

            Console.SetCursorPosition(lewo, tmp++);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Wiek osoby: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(osoba.DajWiek());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Ksiazka od: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(ksiazka.PrzeznaczenieWiekowe());

            Console.SetCursorPosition(lewo, tmp++);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Autor ksiazki: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(ksiazka.autor);

            Console.SetCursorPosition(lewo, tmp++);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Nazwa ksiazki: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(ksiazka.tytul);

            return tmp;
        }
    }
}