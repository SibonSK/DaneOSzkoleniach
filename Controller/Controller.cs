using System;
using System.Collections.Generic;
using ZbieraniaDanychOSzkoleniachZdalnych.Model;
using ZbieraniaDanychOSzkoleniachZdalnych.View;

namespace ZbieraniaDanychOSzkoleniachZdalnych.Controller
{
    public class Controller
    {
        private List<Uczestnik> uczestnicy = new List<Uczestnik>();
        private List<Kurs> kursy = new List<Kurs>();
        private View.View view = new View.View(); // Użycie w pełni kwalifikowanej nazwy

        public void Uruchom()
        {
            bool dzialaj = true;

            while (dzialaj)
            {
                view.WyswietlMenu();
                string wybor = Console.ReadLine();

                switch (wybor)
                {
                    case "1":
                        var uczestnik = view.PobierzDaneUczestnika();
                        uczestnicy.Add(uczestnik);
                        break;
                    case "2":
                        var kurs = view.PobierzDaneKursu();
                        kursy.Add(kurs);
                        break;
                    case "3":
                        PrzypiszUczestnikaDoKursu();
                        break;
                    case "4":
                        view.WyswietlUczestnikow(uczestnicy);
                        break;
                    case "5":
                        view.WyswietlKursy(kursy);
                        break;
                    case "6":
                        WyswietlUczestnikowKursu();
                        break;
                    case "7":
                        dzialaj = false;
                        break;
                    default:
                        Console.WriteLine("Nieznana opcja, spróbuj ponownie.");
                        break;
                }
            }
        }

        private void PrzypiszUczestnikaDoKursu()
        {
            if (kursy.Count == 0)
            {
                Console.WriteLine("Brak dostępnych kursów.");
                return;
            }

            if (uczestnicy.Count == 0)
            {
                Console.WriteLine("Brak dostępnych uczestników.");
                return;
            }

            int numerKursu = view.PobierzNumerKursu(kursy);
            int numerUczestnika = view.PobierzNumerUczestnika(uczestnicy);

            kursy[numerKursu].DodajUczestnika(uczestnicy[numerUczestnika]);
            Console.WriteLine("Uczestnik został przypisany do kursu.");
        }

        private void WyswietlUczestnikowKursu()
        {
            if (kursy.Count == 0)
            {
                Console.WriteLine("Brak dostępnych kursów.");
                return;
            }

            int numerKursu = view.PobierzNumerKursu(kursy);
            view.WyswietlUczestnikowKursu(kursy[numerKursu]);
        }
    }
}
