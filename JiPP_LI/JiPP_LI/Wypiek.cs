using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_LI
{
    class Wypiek
    {
        public Piekarnik piekarnik { get; set; }
        public Produkt produkt { get; set; }

        private int temperatura { get; set; }
        private int czas_pieczenia { get; set; }
        private bool osiagnieta_temperatura { get; set; }

        public Wypiek(Piekarnik _piekarnik, Produkt _produkt)
        {
            piekarnik = _piekarnik;
            produkt = _produkt;

            temperatura = 0;
            czas_pieczenia = 0;
            osiagnieta_temperatura = false;
        }

        public int CzasPieczenia()
        {
            return czas_pieczenia;
        }

        public void WyswietlWypiek()
        {
            piekarnik.WyswietlPiekarnik();
            produkt.WyswietlProdukt(piekarnik.WysokoscPiekarnika() - produkt.WysokoscProduktu() - 1);
        }

        public void WyswietlInformacje()
        {
            // Temperatura piekarnika
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Temperatura pieca: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(temperatura);

            // Max temperatura
            Console.SetCursorPosition(0, 1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Maksymalna temperatura: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(piekarnik.maksymalna_temperatura);

            // Nazwa produktu
            Console.SetCursorPosition(0, 3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Produkt: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(produkt.nazwa);

            // Czas pieczenia
            Console.SetCursorPosition(0, 4);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Czas pieczenia: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(czas_pieczenia + " / 20  ");

            if(czas_pieczenia > 0)
            {
                double procent = (czas_pieczenia * 100) / 20;
                Console.Write(procent + "%");
            }

            // Temperatura pieczenia
            Console.SetCursorPosition(0, 5);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Temperatura: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(produkt.temperatura_pieczenia);

            if (temperatura < piekarnik.maksymalna_temperatura)
                temperatura += 10;
            else
                osiagnieta_temperatura = true;

            if(temperatura >= produkt.temperatura_pieczenia)
            {
                czas_pieczenia++;
                switch(czas_pieczenia)
                {
                    case 5:
                        produkt.ZmienKolorProduktuo(ConsoleColor.Yellow);
                        break;
                    case 10:
                        produkt.ZmienKolorProduktuo(ConsoleColor.Red);
                        break;
                    case 15:
                        produkt.ZmienKolorProduktuo(ConsoleColor.DarkRed);
                        break;
                }
            }
        }
    }
}