using System;
using System.Collections.Generic;
using System.Threading;

namespace JiPP_SW
{
    class Program
    {
        // 1.1 - 
        // 1.2 - 
        // 1.3 - 
        // 1.4 - 

        // 2.1 - 
        // 2.2 - 

        // 3.1 - 
        // 3.2 - 
        // 3.3 - 
        // 3.4 - 

        // 4.1 - 
        // 4.2 - 
        // 4.3 - 
        // 4.4 - 

        // 5.1 - 
        // 5.2 - 
        // 5.3 - 
        // 5.4 - 

        // Wypozyczalnia ksiazek
        // Opisy klas:
        // Osoba - klasa abstrakcyjna majaca kilka wlasciwosci z metodą zwrotu wieku osoby;
        //
        // Kobieta - dziedziczy wszystko po osobie i zmienia funkcje zwrotu wieku - 10 lat;
        // Mezczyzna - dziedziczy wszystko po osobie i zmienai funkcje zwrotu wieku + 10 lat;
        //
        // Ksiazka - Zwykla klasa majaca wlasciwosci i metode zwrot przznaczenia wiekowego
        //
        // Wypozyczenia - klasa majaca na celu polaczenia obiektu osoby z obiektem ksiazka (asocjacja)

            
        static void Main(string[] args)
        {
            // Deklaracja losowosci
            Random random = new Random();

            // Deklaracja listy/tablicy z Ksiazkami:
            List<Ksiazka> ksiazki = new List<Ksiazka>();

            // Dodawanie nowych obiektow typu Ksiazka do stworzonej wyzej kolekcji
            ksiazki.Add(new Ksiazka("Adam Mickiewicz", "Pan Tadeusz", 16));
            ksiazki.Add(new Ksiazka("Anonim", "Tajna Ksiega", 8));
            ksiazki.Add(new Ksiazka("Romantyk", "Serce", 18));
            ksiazki.Add(new Ksiazka("Jan", "Porachunki", 22));

            // Deklaracja listy/tablicy z Osobami:
            List<Osoba> osoby = new List<Osoba>();

            // Dodawanie nwoych obiektow typu Mezczyzna oraz Kobieta do stworzonej kolekcji
            osoby.Add(new Mezczyzna("Jan", "Nowak", 5));
            osoby.Add(new Mezczyzna("Arnold", "Tadeusz", 15));
            osoby.Add(new Mezczyzna("Pan", "Wacław", 33));
            osoby.Add(new Mezczyzna("Adam", "Paluch", 25));
            osoby.Add(new Kobieta("Anna", "Nowak", 15));
            osoby.Add(new Kobieta("Monika", "Mała", 28));
            osoby.Add(new Kobieta("Joanna", "Wielka", 34));
            osoby.Add(new Kobieta("Kobieta", "Losowa", 38));

            // Deklaracja listy/tablicy z Wypozyczeniami:
            List<Wypozyczenia> wypozyczenia = new List<Wypozyczenia>();

            // Dodawanie nowych obiektow typu Wypozyczenia do stworzonej wyzej kolekcji
            for (int i = 0; i < 2; i++)
            {
                // Wyszukanie osoby w kolekcji
                Osoba osoba = osoby[random.Next(0, osoby.Count - 1)];

                // Wyszukanie ksiazki odpowiadajacej do wieku osoby
                Ksiazka ksiazka;
                do
                {
                    ksiazka = ksiazki[random.Next(0, ksiazki.Count - 1)];
                } while (ksiazka.PrzeznaczenieWiekowe() >= osoba.DajWiek());

                // Dodanie obiektu wypozyczenia do kolekcji losowo z opisem lub bez
                if (random.Next(0, 100) > 50)
                    wypozyczenia.Add(new Wypozyczenia(osoba, ksiazka, "Wypozyczenie w wieku " + osoba.DajWiek()));
                else
                    wypozyczenia.Add(new Wypozyczenia(osoba, ksiazka));
            }

            // Zmienna trzmajaca obecny rok programu
            int rok = 0;

            // Glowna petla programu
            while (true)
            {
                Console.Clear();
                Console.ResetColor();
                int rok_smierci = random.Next(30, 70);
                Console.WriteLine("Obecny rok: " + rok + " Rok śmierci: " + rok_smierci);

                // Petla sprawdzajaca osoby ktore umrą w jakims wieku
                bool smierci = false;
                foreach (Wypozyczenia w in wypozyczenia)
                {
                    if (w.osoba.DajWiek() >= rok_smierci)
                    {
                        // Wyswietlenie informacji o smierci
                        w.osoba.Smierc();

                        // Usuniecie wypozycznia danej osoby
                        wypozyczenia.Remove(w);

                        // Usuniecie obiektu osoby
                        osoby.Remove(w.osoba);

                        smierci = true;
                        Thread.Sleep(2000);
                        break;
                    }
                }

                // Zwiekszenie wieku osob
                foreach(Osoba os in osoby)
                {
                    os.ZwiekszWiek();
                }

                // Jezeli nie wykryto zadnej smierci
                if(!smierci)
                {
                    int gora = 1;
                    // Wyswietlenie wszystkich wypozyczen
                    for (int i = 0; i < wypozyczenia.Count; i++)
                    {
                        if (i % 2 == 1)
                            gora = wypozyczenia[i].Wyswietl(Console.BufferWidth / 2, gora, i + 1);
                        else
                            wypozyczenia[i].Wyswietl(0, gora, i + 1);
                    }

                    // Zwiekszenie roku
                    rok++;
                }

                if (wypozyczenia.Count == 0)
                    return;

                // Wstrzymanie pracy na 1 sekunde
                Thread.Sleep(1000);
            }
        }
    }
}