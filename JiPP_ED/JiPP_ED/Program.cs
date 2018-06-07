using System;
using System.Collections.Generic;
using System.Threading;

namespace JiPP_ED
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obiekt generatora liczb losowych
            Random random = new Random();

            // Globalna zmienna identyfikatora pytania
            int numer_pytania = 1;

            // Zmienne z tresciami pytan
            string tresc_1 = "Wiecej niz jedno zwierze to";
            string tresc_2 = "Gdzie wystepuja rzeki bez wody";
            string tresc_3 = "Jak nazywa sie syn optyka";
            string tresc_4 = "2 * 2 + 2 = ";

            // Zmienne z odpowiedziami do pytan
            string[] odpowiedz_tresc_1 = new string[] {
                "owca",     //a
                "krowa",    //b
                "lama"      //c +
            };
            string[] odpowiedz_tresc_2 = new string[] {
                "w Polsce",     //a
                "na mapie",     //b +
                "na swiecie"    //c
            };
            string[] odpowiedz_tresc_3 = new string[] {
                "Synoptyka",        //a +
                "Synokulisty",      //b
                "Optyk nie ma syna",//c
                "Synalek"           //d
            };
            string[] odpowiedz_tresc_4 = new string[] {
                "0",        //a
                "6",        //b +
                "2 * 3",    //c +
                "3 * 2",    //d +
                "8"         //e
            };

            // Tworzenie kolekcji z obiektami typu Pytanie
            List<Pytanie> pytania = new List<Pytanie>();

            // Stworzenie i dodanie nowych obiektow do stworzonej wyzej kolekcji
            pytania.Add(new JednokrotnyWybor(numer_pytania++, tresc_1, odpowiedz_tresc_1, 'c'));
            pytania.Add(new JednokrotnyWybor(numer_pytania++, tresc_2, odpowiedz_tresc_2, 'b'));
            pytania.Add(new JednokrotnyWybor(numer_pytania++, tresc_3, odpowiedz_tresc_3, 'a'));
            char[] tablica_odpowiedzi_do_4 = new char[] { 'b', 'c', 'd' };
            pytania.Add(new WielokrotnyWybor(numer_pytania++, tresc_4, odpowiedz_tresc_4, tablica_odpowiedzi_do_4));

            // Tworzenie obiektu uczestnika na podstawie wpisania imienia w konsoli
            Console.WriteLine("Podaj swoje imie: ");
            Uczestnik uczestnik = new Uczestnik(Console.ReadLine(), random.Next(18, 25)); // Losowy wiek obiektu

            // Obiekt ankiety
            Ankieta ankieta = new Ankieta(uczestnik);

            // Nieskonczona petla programu
            while (true)
            {
                // Czyszczenie konsoli
                Console.Clear();

                // Przypisanie losowego pytania z puli wyzej zdefiniowanych pytan
                ankieta.pytanie = pytania[random.Next(0, pytania.Count)];

                // Wyswietlenie informacji
                ankieta.Informacje();

                // Wyswietlenie pytania i odczekanie na odpowiedz
                ankieta.Pytanie();

                // Stazenie sie obiektu uczestnika
                uczestnik.StarzenieSie();
            }
        }
    }
}