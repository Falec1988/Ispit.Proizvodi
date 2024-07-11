using System;

namespace Ispit.Proizvodi.Modeli
{
    internal class Predavac
    {
        public event PocniPisatiIspit Ispit;

        public void ZvoniZvono()
        {
            Console.WriteLine("Zvoni, ispit počinje!!!");
            Ispit?.Invoke(DateTime.Now);
        }

        public void IspitZaprimljen(Polaznik polaznik)
        {
            Console.WriteLine($"Predavač je zaprimio riješeni ispita od: {polaznik.ImePrezime}");
        }
    }
}
