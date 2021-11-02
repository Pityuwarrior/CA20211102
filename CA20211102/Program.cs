using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA20211102
{
    class Program
    {
        static List<Ember> emberek = new List<Ember>();
        static void Main(string[] args)
        {
            InitEmberek();
            // Összegzés
            // Pl. listába lévők összsúlyszáma
            float res_01 = emberek.Sum(x => x.Suly);

            //Átlag
            // Pl. listába lévők átlagmagassága
            float res_02 = emberek.Average(x => x.Suly);

            //Megszámlálás
            // Pl. Verebélyesek száma
            float res_03 = emberek.Count(x => x.Iskola == "Verebely");

            //Minimum érték
            //pl. legkisebb magasság
            int res_04 = emberek.Min(x => x.Magassag);

            //Maximum érték
            // pl. legnagyobb súly
            float res_05 = emberek.Max(x => x.Suly);

            //























        }
        private static void InitEmberek() 
        {
            emberek.Add(new Ember() 
            {
                Nev = "Kiss Pista",
                Szul = new DateTime(2000, 05, 11),
                Iskola = "Verebely",
                Magassag = 174,
                Suly = 68.3F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Zömek Árpád",
                Szul = new DateTime(2002, 05, 23),
                Iskola = "Katona József",
                Magassag = 168,
                Suly = 53.4F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Kis Ernő",
                Szul = new DateTime(2004, 11, 02),
                Iskola = "Bertalan",
                Magassag = 180,
                Suly = 73.2F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Varga Koppány",
                Szul = new DateTime(2000, 02, 26),
                Iskola = "Verebely",
                Magassag = 187,
                Suly = 79.6F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Nagy Róbert",
                Szul = new DateTime(2002, 08, 01),
                Iskola = "Katona József",
                Magassag = 169,
                Suly = 90.8F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Kerek Szebasztián",
                Szul = new DateTime(2003, 12, 28),
                Iskola = "Umszki",
                Magassag = 175,
                Suly = 67.4F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Kovács Virág",
                Szul = new DateTime(2000, 03, 21),
                Iskola = "Neumann",
                Magassag = 178,
                Suly = 68.9F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Kelemen Sámuel",
                Szul = new DateTime(2002, 06, 23),
                Iskola = "Bólyai",
                Magassag = 183,
                Suly = 80.3F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Fazekas Anna",
                Szul = new DateTime(2001, 03, 11),
                Iskola = "Verebely",
                Magassag = 165,
                Suly = 61.2F,
            });
            emberek.Add(new Ember()
            {
                Nev = "Nagy Orsolya",
                Szul = new DateTime(2001, 05, 05),
                Iskola = "Umszki",
                Magassag = 174,
                Suly = 71.9F,
            });

        }
    }
}
