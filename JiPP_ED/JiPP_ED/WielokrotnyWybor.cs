using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_ED
{
    class WielokrotnyWybor : Pytanie
    {
        // Prywatna wlasciwosc
        private char[] poprawna_odpowiedz { get; set; }

        // Konstruktor z odwolaniem do bazowego konstruktora w klasie abstrakcyjnej
        public WielokrotnyWybor(int _id, string _tresc, string[] _odpowiedzi, char[] _poprawna_odpowiedz) : base(_id, _tresc, _odpowiedzi)
        {
            poprawna_odpowiedz = _poprawna_odpowiedz;
            licznik_punktow = _poprawna_odpowiedz.Length;
        }

        // Metoda/Funkcja sprawdzenia poprawnej odpowiedzi do pytania obiektu
        public bool PoprawnoscOdpowiedzi(char[] odpowiedz)
        {
            // Jezeli odpowiedzi zostalo udzielonych zbyt malo, funkcja zwraca falsz
            if (odpowiedz.Length != poprawna_odpowiedz.Length)
                return false;
            
            // Petla po odpowiedziach przychodzacych do funkcji
            for(int i = 0; i < odpowiedz.Length; i++)
            {
                // Tymczasowe zmienne znalezienia odpowiedzi w puli prawidlowych odpowiedzi
                bool znalezione = false;

                // Petla sprawdzania czy podana odpowiedz znajduje sie w tablicy z poprawnymi odpowiedziami
                for (int j = 0; j < poprawna_odpowiedz.Length; j++)
                {
                    // Jezeli znaleziona ustawia zmienna na prawde, dodaje punkty
                    if (poprawna_odpowiedz[j] == odpowiedz[i])
                    {
                        znalezione = true;
                        break; // zerwanie petli w celu dalszego szukania, bo odpowiedz zostala znaleziona
                    }
                }

                // Jezeli nie znaleziono odpowiedzi w puli poprawnych odpowiedzi, funkcja zwraca falsz
                if (!znalezione)
                    return false;
            }

            // Jezeli funkcja przeszla pozytywnie wszystkie testy, funkcja zwraca prawde
            return true;
        }
    }
}
