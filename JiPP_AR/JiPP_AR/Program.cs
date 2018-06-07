using System;
using System.Collections.Generic;
using System.Threading;

namespace JiPP_AR
{
    class Program
    {
        static void Main(string[] args)
        {
            // Losowosc
            Random random = new Random();

            // Inicjalizacja kolekcji z telewizorami
            List<Telewizor> telewizory = new List<Telewizor>();

            // Tworzenie obiektow i dodawanie ich do kolekcji Telewizor
            telewizory.Add(new Samsung(ConsoleColor.Red));
            telewizory.Add(new Samsung(ConsoleColor.Blue));
            telewizory.Add(new Samsung(ConsoleColor.Cyan));
            telewizory.Add(new Samsung(ConsoleColor.Green));
            telewizory.Add(new Panasonic());
            telewizory.Add(new Panasonic(ConsoleColor.Red));
            telewizory.Add(new Panasonic(ConsoleColor.Blue));
            telewizory.Add(new Panasonic(ConsoleColor.Cyan));
            telewizory.Add(new Panasonic(ConsoleColor.Green));

            // Pobranie referencji do losowego elementu z kolekcji telewizorow
            Telewizor telewizor = telewizory[random.Next(0, telewizory.Count - 1)];

            // Zmiana czasu
            int czas = 5;

            // Nieskonczona petla programu
            while (true)
            {
                Console.Clear(); // Czyszczenie konsoli
                Console.ResetColor();

                Console.WriteLine("Nastepny telewizor za " + czas);

                // Jezeli obiekt telewizor jest obiektem typu Panasonic
                if(telewizor is Panasonic)
                {
                    // Wyswietlenie kodu producenta z prywatnej zmiennej przy pomocy funkcji
                    Console.WriteLine("Kod producenta: " + telewizor.kodProducenta);
                }

                // Wyswietlenie telewizora w kolorze
                telewizor.Wyswietl();
                
                // Reset czasu i wylosowanie nastepnego telewizora
                czas--;
                if (czas < 1)
                {
                    // Wylosowanie nowego obiektu z listy telewizorow
                    telewizor = telewizory[random.Next(0, telewizory.Count - 1)];
                    
                    // Jezeli obiekt telewizor jest obiektem typu Panasonic
                    if (telewizor is Panasonic)
                    {
                        // Przypisanie kodu do prywatnej zmiennej przy pomocy funkcji
                        telewizor.kodProducenta = "K0D PaNaSoNiC";
                    }

                    czas = 10;
                }

                Thread.Sleep(500); // Uspienie programu na 1000ms
            }
        }
    }
}
