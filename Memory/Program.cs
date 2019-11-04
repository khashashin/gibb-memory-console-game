using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Program
    {
        static void Main(string[] args)
        {
            ZeigeAnleitung();
        }

        public static void ZeigeAnleitung()
        {
            Console.WriteLine("Hinter den '?' verstecken sich Symbole, die paarweise vorkommen. Finden Sie diese!");
            Console.WriteLine("Wählen Sie zwei Positionen zum Aufdecken in der Form: Zeile1Spalte1Zeile2Spalte2,");
            Console.WriteLine("z.B 2142 vergleicht das Symbol in Zeile 2 und Spalte 1 mit dem Symbol in Zeile 4 und Spalte 2");
            Console.WriteLine("  1  2  3  4");
            Console.WriteLine("1 ?  ?  ?  ?");
            Console.WriteLine("2 ☺  ?  ?  ?");
            Console.WriteLine("3 ?  ?  ?  ?");
            Console.WriteLine("4 ?  ☺  ?  ?");
            Console.ReadLine();
        }
    }
}
