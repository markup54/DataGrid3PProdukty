using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid3PProdukty
{
    public class Produkt
    {
        public String Nazwa { get; set; }
        public bool Dostepnosc { get; set; }
        public double Cena { get; set; }
        public String Kategoria { get; set; }

        public Produkt(string nazwa, bool dostepnosc, double cena, string kategoria)
        {
            Nazwa = nazwa;
            Dostepnosc = dostepnosc;
            Cena = cena;
            Kategoria = kategoria;
        }
    }
}
