using System;

namespace Ispit.Proizvodi.Modeli
{
    internal class Polaznik
    {
        public string ImePrezime { get; set; }

        public delegate void PredajIspit(Polaznik polaznik);
        public event PredajIspit IspitZavrsen;

        public void OdgovoriNaPitanja(DateTime vrijeme_pocetka)
        {
            Console.WriteLine($"{ImePrezime} - {vrijeme_pocetka} - Počnite pisati ispit!");
        }

        public void PredajOdgovoreNaPitanja()
        {
            Console.WriteLine($"{ImePrezime} je predao/la ispit.");
            IspitZavrsen?.Invoke(this);
        }
    }
}
