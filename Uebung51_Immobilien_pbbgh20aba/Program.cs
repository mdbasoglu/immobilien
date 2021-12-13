using System;
using System.IO;

namespace Uebung51_Immobilien_pbbgh20aba
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Immobilie objekt1 = new Immobilie("Doppelhaushälfte innenstadtnah", 110, 5, 1977, 210000, true);
            Immobilie objekt2 = new Immobilie("Traumhaus am Waldrand", 165, 8, 2005, 650000, false);
            Immobilie objekt3 = new Immobilie("Whohnung für Studenten", 60, 2, 1999, 150000, false);


            Console.WriteLine(objekt1);
            Console.WriteLine(objekt2);
            Console.WriteLine(objekt3);
            */


            Immobilie[] haus = LeseImmobilien();
            Console.WriteLine(string.Join<Immobilie>(", ", haus));

        }


        public static Immobilie[] LeseImmobilien()
        {

            string[] lines = File.ReadAllLines(@"Daten/Immobillie.csv");

            Immobilie[] immobilie = new Immobilie[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] data = lines[i].Split(',');

                string beschreibung = data[0];
                double wohnflaeche = Convert.ToDouble(data[1]);
                int anzahlzimmer = Convert.ToInt32(data[2]);
                int baujahr = Convert.ToInt32(data[3]);
                double kaufpreis = Convert.ToDouble(data[4]);
                bool verkauft = Convert.ToBoolean(data[5]);


                immobilie[i] = new Immobilie(data[0], wohnflaeche, anzahlzimmer, baujahr, kaufpreis, verkauft);

            }
            return immobilie;
        }
    }
}
