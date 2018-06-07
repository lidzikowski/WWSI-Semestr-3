using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_BF
{
    // Klasa abstrakcyjna Czlowiek
    abstract class Czlowiek
    {
        // Wlasciwosci publiczne
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public Praca praca { get; set; }
        public int wiek { get; set; }

        // Wlasciwosci prywatne
        private double majatek { get; set; }

        // Konstruktor klasy
        public Czlowiek(string _imie, string _nazwisko, int _wiek)
        {
            imie = _imie;
            nazwisko = _nazwisko;
            praca = null;
            wiek = _wiek;
        }

        // Publiczna metoda zwiekszajaca zarobek obiektu
        public void Zarobek(double wyplata)
        {
            majatek += wyplata;
        }

        // Publiczna wirtualna metoda zwracajaca obecny majatek osoby
        public virtual double MajatekOsoby()
        {
            return majatek;
        }

        // Publiczna wirtualna metoda klasy
        public virtual int WypiszCzlowieka(int lewo, int gora, int index)
        {
            Console.SetCursorPosition(lewo, gora++);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(index + "  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(imie + " " + nazwisko);
            if (praca != null)
            {
                Console.SetCursorPosition(lewo, gora++);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Praca: ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(praca.nazwa);
            }
            return gora;
        }
    }
}