using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_BF
{
    // Klasa Mezczyzna dziedziczy Czlowiek
    class Mezczyzna : Czlowiek
    {
        // Wlasciwosci prywatne
        private int iloscSamochodow { get; set; }

        // Konstruktor
        public Mezczyzna(string _imie, string _nazwisko, int _wiek) : base(_imie, _nazwisko, _wiek)
        {
            iloscSamochodow = 0;
        }

        // Konstruktor
        public Mezczyzna(string _imie, string _nazwisko, int _wiek, int _iloscSamochodow) : base(_imie, _nazwisko, _wiek)
        {
            iloscSamochodow = _iloscSamochodow;
        }

        // Przeciazenie wirtualnej metody z klasy bazowej zwracajaca nowy majatek
        public override double MajatekOsoby()
        {
            return base.MajatekOsoby() - Wydatki();
        }

        // Prywatna metoda klasy zwracajaca wydatki obiektu
        private double Wydatki()
        {
            return iloscSamochodow * 100;
        }

        // Przeciazenie wirtualnej metody z klasy bazowej
        public override int WypiszCzlowieka(int lewo, int gora, int index)
        {
            int gora_temp =  base.WypiszCzlowieka(lewo, gora, index);

            Console.SetCursorPosition(lewo, gora_temp++);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Plec: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Mezczyzna");

            Console.SetCursorPosition(lewo, gora_temp++);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Majatek: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(base.MajatekOsoby());
            double wydatki = Wydatki();
            if (wydatki > 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" -");
                Console.Write(wydatki);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" PLN");

            return gora_temp;
        }
    }
}