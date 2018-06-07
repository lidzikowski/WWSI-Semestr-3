using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_BF
{
    // Klasa Praca
    class Praca
    {
        // Publiczne wlasciwosci
        public string nazwa { get; set; }
        public double zarobki { get; set; }
        public List<Czlowiek> pracownicy { get; set; }

        // Konstruktor klasy
        public Praca(string _nazwa, double _zarobki)
        {
            this.nazwa = _nazwa;
            this.zarobki = _zarobki;
            this.pracownicy = new List<Czlowiek>();
        }

        /// <summary>
        /// Zatrudnienie nowego pracownika
        /// </summary>
        /// <param name="czlowiek">Obiekt osoby ktora zostanie zatrudniona</param>
        public void Zatrudnij(Czlowiek czlowiek)
        {
            pracownicy.Add(czlowiek);
        }

        /// <summary>
        /// Zwolnienie pracownika jezeli jest zatrudniony
        /// </summary>
        /// <param name="czlowiek">Obiekt osoby ktora zostanie zwolniona</param>
        public void Zwolnij(Czlowiek czlowiek)
        {
            Czlowiek pracownik = null;
            foreach (Czlowiek osoba in pracownicy)
            {
                if (osoba == czlowiek)
                {
                    pracownicy.Remove(pracownik);
                    return;
                }
            }
        }

        /// <summary>
        /// Ilosc obecnie zatrudnionych pracownikow
        /// </summary>
        /// <returns>Zwraca liczbe pracownikow</returns>
        public int IloscPracownikow()
        {
            return pracownicy.Count;
        }

        /// <summary>
        /// Ilosc obecnie pracujacych Mezczyzn
        /// </summary>
        /// <returns>Zwraca liczbe pracujacych Mezczyzn</returns>
        public int IloscMezczyzn()
        {
            int licznik = 0;
            foreach(Czlowiek osoba in pracownicy)
            {
                if (osoba is Mezczyzna)
                    licznik++;
            }
            return licznik;
        }

        /// <summary>
        /// Ilosc obecnie pracujacych Kobiet
        /// </summary>
        /// <returns>Zwraca liczbe pracujacych Kobiet</returns>
        public int IloscKobiet()
        {
            int licznik = 0;
            foreach (Czlowiek osoba in pracownicy)
            {
                if (osoba is Kobieta)
                    licznik++;
            }
            return licznik;
        }

        /// <summary>
        /// Wyplata dla pracownikow
        /// </summary>
        public void Wyplata()
        {
            foreach(Czlowiek pracownik in pracownicy)
            {
                pracownik.Zarobek(zarobki);
            }
        }

        // Metoda wypisania informacji o pracy w konsoli - przyjmuje polozenie kursora i indeks pracy w globalnej liscie prac
        public int WypiszPrace(int lewo, int gora, int index)
        {
            Console.SetCursorPosition(lewo, gora++);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(index + "  ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(nazwa);

            Console.SetCursorPosition(lewo, gora++);
            Console.Write("Zarobki: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(zarobki);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" PLN");

            Console.SetCursorPosition(lewo, gora++);
            Console.Write("Pracownicy: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(IloscPracownikow());
            Console.SetCursorPosition(lewo, gora++);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Mezczyzni: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(IloscMezczyzn());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("   Kobiety: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(IloscKobiet());
            return gora;
        }
    }
}
