using System;
namespace Uebung51_Immobilien_pbbgh20aba
{
    class Immobilie
    {

        //Attribute
        private string beschreibung;
        private double wohnflaeche;
        private int anzahlZimmer;
        private int baujahr;
        private double kaufpreis;
        private bool verkauft;

        public Immobilie(string beschreibung, double wohnflaeche, int anzahlZimmer, int baujahr, double kaufpreis, bool verkauft)
        {
            this.beschreibung = beschreibung;
            this.wohnflaeche = wohnflaeche;
            this.anzahlZimmer = anzahlZimmer;
            this.baujahr = baujahr;
            this.kaufpreis = kaufpreis;
            this.verkauft = verkauft;
        }


        //Ekrana yazdirmak icin kullaniyoruz yani detaylandirmak icin bicim denebilir
        public override string ToString()
        {
            return $"Immobilie [Beschreibung={beschreibung}, wohnfäche={wohnflaeche},anzahlzimmer={anzahlZimmer}]" +
                $"baujahr={baujahr}, kaufpreis={kaufpreis}, verkauft={verkauft}";

        }


    }
}
