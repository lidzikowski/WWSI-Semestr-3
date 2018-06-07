using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_LI
{
    class Piekarnik
    {
        public string producent { get; set; }
        public int maksymalna_temperatura { get; set; }

        private string[] model { get; set; }
        private ConsoleColor kolor { get; set; }

        public Piekarnik(string _producent, int _maksymalna_temperatura = 220)
        {
            producent = _producent;
            maksymalna_temperatura = _maksymalna_temperatura;
            model = new string[] {
                @"-------------------------",
                @"|                       |",
                @"|                       |",
                @"|                       |",
                @"|                       |",
                @"|                       |",
                @"|                       |",
                @"|                       |",
                @"|                       |",
                @"-------------------------"
            };

            List<ConsoleColor> kolory = new List<ConsoleColor>();
            kolory.Add(ConsoleColor.Yellow);
            kolory.Add(ConsoleColor.Green);
            kolory.Add(ConsoleColor.Red);
            kolory.Add(ConsoleColor.Cyan);
            kolory.Add(ConsoleColor.Magenta);

            Random random = new Random();

            kolor = kolory[random.Next(0, kolory.Count - 1)];
        }
        public Piekarnik(string _producent, int _maksymalna_temperatura, string[] _model)
        {
            producent = _producent;
            maksymalna_temperatura = _maksymalna_temperatura;
            model = _model;
        }

        public int WysokoscPiekarnika()
        {
            return model.Length;
        }

        public virtual void WyswietlPiekarnik()
        {
            int szerokosc = (Console.BufferWidth / 2) - (model[0].Length / 2);
            int wysokosc = 0;
            
            Console.ForegroundColor = kolor;
            for (int i = 0; i < model.Length; i++)
            {
                Console.SetCursorPosition(szerokosc, wysokosc++);
                Console.Write(model[i]);
            }

            Console.SetCursorPosition(szerokosc + (model[0].Length / 2) - (producent.Length / 2), wysokosc++);
            Console.Write(producent);
        }
    }
}