using System;
using System.Collections.Generic;
using System.Threading;

namespace JiPP_RW
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklaracja losowosci w programie
            Random random = new Random();

            // Tworzenie i inicjalizacja kolekcji z obiektami typu Samochod
            List<Samochod> samochody = new List<Samochod>();

            // Tworzenie i dodawanie obiektow do kolekcji
            samochody.Add(new Osobowy("BMW"));
            samochody.Add(new Osobowy("Volvo"));
            samochody.Add(new Osobowy("Mercedes"));
            samochody.Add(new Dostawczy("Scania"));
            samochody.Add(new Dostawczy("DAF"));
            samochody.Add(new Dostawczy("FSR Tarpan"));

            // Tworzenie i inicjalizacja kolekcji z obiktami Malowanie
            List<Malowanie> malowania = new List<Malowanie>();

            // Tworzenie i dodawanie obiektow do kolekcji
            malowania.Add(new Malowanie(ConsoleColor.Blue));
            malowania.Add(new Malowanie(ConsoleColor.Cyan, "Matowy"));
            malowania.Add(new Malowanie(ConsoleColor.Gray));
            malowania.Add(new Malowanie(ConsoleColor.Green));
            malowania.Add(new Malowanie(ConsoleColor.Magenta, "VIP"));
            malowania.Add(new Malowanie(ConsoleColor.Red));
            malowania.Add(new Malowanie(ConsoleColor.Yellow));

            // Losowe obiekty z kolekcji
            Samochod samochod = samochody[random.Next(0, samochody.Count - 1)];
            Malowanie malowanie = malowania[random.Next(0, malowania.Count - 1)];
             
            // Tworzenie obiektu lakierowania z wyzej wylosowanych obiektow
            Lakierowanie lakierowanie = new Lakierowanie(samochod, malowanie);

            // Zmienna czasu
            int czas = 0;

            // Petla programu
            while (true)
            {
                Console.Clear();
                
                // Wywolanie funkcji wyswietlania i malowania samochodu
                lakierowanie.Wyswietlanie_Malowanie(czas);

                // Zwiekszanie czasu programu
                czas++;

                // Zmiana samochodu co jaki czas
                if (czas >= 3)
                {
                    // Losowanie na nowo obiektow Samochod i Malowanie
                    samochod = samochody[random.Next(0, samochody.Count - 1)];
                    malowanie = malowania[random.Next(0, malowania.Count - 1)];

                    // Przypisanie nowo wylosowanych obiektow do obiektu asocjacyjnego
                    lakierowanie = new Lakierowanie(samochod, malowanie);
                    czas = 0;
                }

                Thread.Sleep(1000);
            }
        }
    }
} 