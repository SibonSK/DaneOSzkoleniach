using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbieraniaDanychOSzkoleniachZdalnych.Model
{
    public class Kurs
    {
        public string Nazwa { get; set; }
        public DateTime DataRozpoczecia { get; set; }
        public int CzasTrwania { get; set; } // W dniach
        public string Opis { get; set; }
        public List<Uczestnik> Uczestnicy { get; set; }

        public Kurs(string nazwa, DateTime dataRozpoczecia, int czasTrwania, string opis)
        {
            Nazwa = nazwa;
            DataRozpoczecia = dataRozpoczecia;
            CzasTrwania = czasTrwania;
            Opis = opis;
            Uczestnicy = new List<Uczestnik>();
        }

        public void DodajUczestnika(Uczestnik uczestnik)
        {
            Uczestnicy.Add(uczestnik);
        }
    }
}


