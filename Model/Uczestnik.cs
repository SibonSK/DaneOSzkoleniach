using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbieraniaDanychOSzkoleniachZdalnych.Model
{
    public class Uczestnik
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Adres { get; set; }

        public Uczestnik(string imie, string nazwisko, string adres)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Adres = adres;
        }
    }
}



