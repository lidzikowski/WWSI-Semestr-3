using System;
using System.Collections.Generic;
using System.Threading;

namespace JiPP_LI
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<Piekarnik> piekarniki = new List<Piekarnik>();
            piekarniki.Add(new Piekarnik("Bosh"));
            piekarniki.Add(new Piekarnik("Electrolux"));
            piekarniki.Add(new Piekarnik("Amica"));

            List<Produkt> produkty = new List<Produkt>();
            produkty.Add(new Pizza());
            produkty.Add(new Pizza("Pizza wloska", 199, 7));
            produkty.Add(new Kurczak());
            produkty.Add(new Kurczak("Kurczątko", 150, 13));
            produkty.Add(new Kurczak("Kurcze", 300, 18));

            Wypiek wypiek = new Wypiek(piekarniki[random.Next(0, piekarniki.Count - 1)], produkty[random.Next(0, produkty.Count - 1)]);

            while (true)
            {
                Console.Clear();
                Console.ResetColor();

                wypiek.WyswietlInformacje();
                wypiek.WyswietlWypiek();

                if(wypiek.CzasPieczenia() >= 20)
                {
                    wypiek = new Wypiek(piekarniki[random.Next(0, piekarniki.Count - 1)], produkty[random.Next(0, produkty.Count - 1)]);
                    Console.Clear();
                    Console.ResetColor();
                    Console.WriteLine("Produkt zostal upieczony - trwa ladowanie nowego.");
                    Thread.Sleep(2000);
                }

                Thread.Sleep(250);
            }
        }
    }
}