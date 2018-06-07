using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_RW
{
    // Klasa asocjacyjna
    class Lakierowanie
    {
        // Publiczne wlasciwosci obiektowow
        public Samochod samochod { get; set; }
        public Malowanie malowanie { get; set; }

        // Konstruktor
        public Lakierowanie(Samochod _samochod, Malowanie _malowanie)
        {
            samochod = _samochod;
            malowanie = _malowanie;
        }

        // Glowna mechanika malowania
        public void Wyswietlanie_Malowanie(int czas)
        {
            Console.ResetColor(); // Reset kolorow

            Napisy(0, "Marka samochodu: ", samochod.marka);
            Napisy(1, "Rodzaj malowania: ", malowanie.RodzajMalowania());
            Napisy(3, "Czas: ", czas.ToString());

            // Wywolanie funkcji kolorowania konsoli
            malowanie.Koloruj();

            // Wywolanie funkcji wyswietlajacej pomalowany NA KOLOR model samochodu
            samochod.WyswietlPojazd();
        }

        private void Napisy(int wysokosc, string nazwa, string wiadomosc)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(0, wysokosc++);
            Console.Write(nazwa);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(wiadomosc);
        }
    }
}