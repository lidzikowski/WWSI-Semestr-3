using System;
using System.Collections.Generic;
using System.Text;

namespace JiPP_ED
{
    class JednokrotnyWybor : Pytanie
    {
        // Prywatna wlasciwosc
        private int poprawna_odpowiedz { get; set; }

        // Konstruktor z odwolaniem do bazowego konstruktora w klasie abstrakcyjnej
        public JednokrotnyWybor(int _id, string _tresc, string[] _odpowiedzi, char _poprawna_odpowiedz) : base(_id, _tresc, _odpowiedzi)
        {
            poprawna_odpowiedz = _poprawna_odpowiedz;
            licznik_punktow = 1;
        }
        
        // Metoda/Funkcja sprawdzenia poprawnej odpowiedzi do pytania obiektu
        public bool PoprawnoscOdpowiedzi(char odpowiedz)
        {
            // Jezeli odpowiedz jest poprawna zwraca prawde
            if (odpowiedz == poprawna_odpowiedz)
            {
                return true;
            }

            // Jezeli warunek wyzej sie nie spelni, funkcja zwroci falsz
            return false;
        }
    }
}
