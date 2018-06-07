using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_ED
{
    abstract class Pytanie
    {
        // Publiczne wlasciwosci
        public int identyfikator { get; set; }
        public string tresc { get; set; }
        public string[] odpowiedzi { get; set; }

        // Prywatne pole/zmienna
        protected int licznik_punktow;

        // Publiczna wlasciwosc zwracajaca wartosc z pola prywatnego
        public int Punktacja { get { return licznik_punktow; } }

        // Konstruktor klasy
        public Pytanie(int _id, string _tresc, string[] _odpowiedzi)
        {
            identyfikator = _id;
            tresc = _tresc;
            odpowiedzi = _odpowiedzi;

            licznik_punktow = 0;
        }
        
        // Publiczna metoda wyswietlania pytania obiektu na ekranie
        public virtual void WyswietlPytanie()
        {
            Console.WriteLine();
            Console.WriteLine();

            // Wyswietlenie pytania
            Console.ForegroundColor = ConsoleColor.White;
            if (this is JednokrotnyWybor)
                Console.WriteLine(tresc);
            else
                Console.WriteLine("[WIELOKROTNY WYBOR]  " + tresc);

            // Wyswietlenie odpowiedzi
            Console.ForegroundColor = ConsoleColor.White;
            // 97 - kod ASCII - litera 'a' 
            char alfabet = (char)97;

            // Petla wyswietlania poszczegolnych odpowiedzi w kazdej lini
            for (int i = 0; i < odpowiedzi.Length; i++)
            {
                if(this is JednokrotnyWybor)
                    Console.WriteLine(alfabet++ + ")  " + odpowiedzi[i]);
                else
                    Console.WriteLine("[" + alfabet++ + "]  " + odpowiedzi[i]);
            }
        }
    }
}