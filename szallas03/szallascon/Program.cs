using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szallascon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Szallas> szallasok = Szallas.Beolvas("szallas2022.csv");

            Console.WriteLine("4.feladat");
            Console.WriteLine($"Az összes szálláshelyek száma: {szallasok.Count} darab");

            int agyak = 0;
            int aktiv = 0;

            foreach (Szallas szallas in szallasok)
            {
                if (szallas.Statusz)
                {
                    aktiv++;
                    agyak += szallas.AgySzam;
                }
            }
            Console.WriteLine("5.feladat");

            double atlag = (double)agyak / (double)aktiv; 

            Console.WriteLine($"Átlagos ágyszám az aktív szálláshelyeken: {atlag:0.00}");

            Console.WriteLine("6.feladat");
            Console.WriteLine($"Szeghalom környéki aktív szállások:");
          


            Dictionary<string, int> telepulesek = new Dictionary<string, int>();

            foreach (Szallas szallas in szallasok)
            {
                if (szallas.Statusz)
                {
                    if (telepulesek.ContainsKey(szallas.Telepules))
                        telepulesek[szallas.Telepules]++;
                    else
                        telepulesek[szallas.Telepules] = 1;
                }

            }
            foreach (var telepules in telepulesek)
            {
                Console.WriteLine($"\t{telepules.Key} : {telepules.Value} db");
            }






            Console.ReadKey();
        }
    }
}
