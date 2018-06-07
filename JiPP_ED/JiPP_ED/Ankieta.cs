using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace JiPP_ED
{
    // Klasa asocjacyjna - laczaca relacje pomiedzy obiektami i zarzadzajaca ich dzialaniami
    class Ankieta
    {
        // Publiczne wlasciwosci do referencji obiektow typu Uczestnik i Pytanie
        public Uczestnik uczestnik { get; set; }
        public Pytanie pytanie { get; set; }

        // Prywatna wlasciwosc
        private string doswiadczenie { get; set; }

        // Prywatna zmienna ze zdobytymi punktami
        private int punkty;

        // Dwa konstruktory tworzace przeciazenie konstruktora klasy
        // Konstruktor przyjmuje wartosci i przekazuje je do "this" - konstruktora w tej klasie
        public Ankieta(Uczestnik _uczestnik, Pytanie _pytanie) : this(_uczestnik) 
        {
            pytanie = _pytanie;
        }
        public Ankieta(Uczestnik _uczestnik)
        {
            uczestnik = _uczestnik;

            if (_uczestnik.wiek >= 20)
                doswiadczenie = "Doswiadczony uczestnik";
            else
                doswiadczenie = "Amator";

            punkty = 0;
        }
        
        // Publiczna metoda/funkcja wyswietlajaca informacje o uczestniku
        public void Informacje()
        {
            // Imie uczestnika
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Imie uczestnika: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(uczestnik.imie);
            
            Console.WriteLine();
            // Wiek uczestnika
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Wiek: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(uczestnik.wiek);

            Console.WriteLine();
            // Doswiadczenie uczestnika
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Doswiadczenie: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(doswiadczenie);
            
            Console.WriteLine();
            // Punkty uczestnika
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Zdobyte punkty: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(punkty);
        }

        // Publiczna metoda/funkcja wyswietlajaca obecne pytanie do uczestnika
        public void Pytanie()
        {
            pytanie.WyswietlPytanie();

            // Zapytanie o odpowiedz
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Twoja odpowiedz: ");

            // Czekanie na odpowierdz i zamiana jej na tablice znakow
            char[] odpowiedz = Console.ReadLine().ToCharArray();

            // Odroznienie obiektow pytania i przekazanie odpowiedzi z konsoli do funkcji danego obiektu
            if(pytanie is JednokrotnyWybor)
                WynikOdpowiedzi((pytanie as JednokrotnyWybor).PoprawnoscOdpowiedzi(odpowiedz[0]));
            else
                WynikOdpowiedzi((pytanie as WielokrotnyWybor).PoprawnoscOdpowiedzi(odpowiedz));
        }

        private void WynikOdpowiedzi(bool stan)
        {
            Console.WriteLine();
            Console.WriteLine();
            if (stan)
            {
                // Dopisanie punktow do stanu uczestnika
                punkty += pytanie.Punktacja;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Odpowiedz jest POPRAWNA!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Zdobyto " + pytanie.Punktacja + " punktow.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Odpowiedz jest BLEDNA!");
            }

            Thread.Sleep(1000);
        }
    }
}