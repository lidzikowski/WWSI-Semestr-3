using System;
using System.Collections.Generic;
using System.Threading;

namespace JiPP_BF
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generator losowosci
            Random rnd = new Random();

            // Deklaracja listy z obiektami pracy
            List<Praca> prace = new List<Praca>();
            prace.Add(new Praca("Budowlaniec", 1500));
            prace.Add(new Praca("Junior", 2100));
            prace.Add(new Praca("Senior", 5100));
            prace.Add(new Praca("Ochroniarz", 800));

            // Deklaracja listy z obiektami osob
            List<Czlowiek> osoby = new List<Czlowiek>();
            osoby.Add(new Mezczyzna("Janusz", "Kowalski", rnd.Next(0,50), rnd.Next(0, 1)));
            osoby.Add(new Kobieta("Januszowa", "Kowalska", rnd.Next(0, 50)));
            osoby.Add(new Kobieta("Monika", "Em", rnd.Next(0, 50)));
            osoby.Add(new Mezczyzna("Adam", "Adamski", rnd.Next(0, 50), rnd.Next(0, 3)));
            osoby.Add(new Mezczyzna("Rob", "oM", rnd.Next(0, 50), rnd.Next(0, 7)));
            osoby.Add(new Kobieta("A", "aaaa", rnd.Next(0, 50)));
            osoby.Add(new Mezczyzna("B", "bbbb", rnd.Next(0, 50), rnd.Next(0, 2)));
            osoby.Add(new Kobieta("C", "cccc", rnd.Next(0, 50)));
            osoby.Add(new Mezczyzna("D", "dddd", rnd.Next(0, 50), rnd.Next(0, 4)));
            osoby.Add(new Kobieta("E", "eeee", rnd.Next(0, 50)));

            // Poczatkowe losowe przypisanie osob do prac
            foreach (Czlowiek osoba in osoby)
            {
                int pracaId = rnd.Next(-1, prace.Count);
                if(pracaId != -1)
                {
                    prace[pracaId].Zatrudnij(osoba);
                    osoba.praca = prace[pracaId];
                }
            }

            // Wskaznik obecnego miesiaca / obroty petli
            int miesiac = 0;

            // Nieskonczona petla
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Miesiąc: " + miesiac);
                Console.WriteLine("Oferty pracy: ");

                // Wyswietlenie wszystkich zadeklarowanych wyzej prac
                int pozycja_gora = 2;
                for (int i = 0; i < prace.Count; i++)
                {
                    prace[i].Wyplata();
                    pozycja_gora = prace[i].WypiszPrace(0, pozycja_gora, i + 1);
                    pozycja_gora++;
                }

                // Wypisanie osob i informacji o nich ktore zostaly zadeklarowane wyzej
                int pozycja_lewo = Console.WindowWidth / 4;
                pozycja_gora = 1;
                for (int i = 0; i < osoby.Count; i++)
                {
                    if (i % 2 == 0)
                        osoby[i].WypiszCzlowieka(pozycja_lewo * 2, pozycja_gora, i + 1);
                    else
                    {
                        pozycja_gora = osoby[i].WypiszCzlowieka(pozycja_lewo * 3, pozycja_gora, i + 1);
                        pozycja_gora++;
                    }
                }

                // Zwiekszenie miesiaca / obrotu petli i zatrzymanie pracy programu na 1 sekunde
                miesiac++;
                Thread.Sleep(1000);
            }
        }
    }
}