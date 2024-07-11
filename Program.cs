using Ispit.Proizvodi.Modeli;
using System;
using System.Collections.Generic;

namespace Ispit.Proizvodi
{
    public delegate void PocniPisatiIspit(DateTime vrijeme_pocetka);

    internal class Program
    {
        static void Main(string[] args)
        {
            Predavac predavac = new Predavac();

            List<Polaznik> polaznici = new List<Polaznik>
            {
                new Polaznik { ImePrezime = "Ana Hajdaš" },
                new Polaznik { ImePrezime = "Filip Tešija" },
                new Polaznik { ImePrezime = "Ivan Pelin" },
                new Polaznik { ImePrezime = "Josip Borozan" }
            };

            predavac.Ispit += (DateTime vrijeme_pocetka) =>
            {
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n==================== Početak ispita! ====================");
                Console.ResetColor();
                Console.ReadKey();
                foreach (var polaznik in polaznici)
                {
                    polaznik.OdgovoriNaPitanja(vrijeme_pocetka);
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("=========================================================\n");
                Console.ResetColor();
                Console.ReadKey();
            };

            foreach (var polaznik in polaznici)
            {
                polaznik.IspitZavrsen += predavac.IspitZaprimljen;
            }

            predavac.ZvoniZvono();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n==================== Predaja ispita! ====================");
            Console.ResetColor();
            Console.ReadKey();
            polaznici[2].PredajOdgovoreNaPitanja();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("=========================================================\n");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
