using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_BF
{
    // Klasa Kobieta dziedziczy Czlowiek
    class Kobieta : Czlowiek
    {
        // Konstruktor klasy
        public Kobieta(string _imie, string _nazwisko, int _wiek) : base(_imie, _nazwisko, _wiek)
        { }

        // Przeciazenie wirtualnej metody z klasy bazowej
        public override int WypiszCzlowieka(int lewo, int gora, int index)
        {
            int gora_temp = base.WypiszCzlowieka(lewo, gora, index);

            Console.SetCursorPosition(lewo, gora_temp++);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Plec: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Kobieta");

            Console.SetCursorPosition(lewo, gora_temp++);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Majatek: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(this.MajatekOsoby());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" PLN");

            return gora_temp;
        }
    }
}