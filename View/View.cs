using System;
using System.Collections.Generic;
using ZbieraniaDanychOSzkoleniachZdalnych.Model;

namespace ZbieraniaDanychOSzkoleniachZdalnych.View
{
    public class View
    {
        public void WyswietlMenu()
        {
            Console.WriteLine("1. Dodaj uczestnika");
            Console.WriteLine("2. Dodaj kurs");
            Console.WriteLine("3. Przypisz uczestnika do kursu");
            Console.WriteLine("4. Wyświetl uczestników");
            Console.WriteLine("5. Wyświetl kursy");
            Console.WriteLine("6. Wyświetl uczestników kursu");
            Console.WriteLine("7. Wyjście");
        }

        public void WyswietlUczestnikow(List<Uczestnik> uczestnicy)
        {
            foreach (var uczestnik in uczestnicy)
            {
                Console.WriteLine($"Imię: {uczestnik.Imie}, Nazwisko: {uczestnik.Nazwisko}, Adres: {uczestnik.Adres}");
            }
        }

        public void WyswietlKursy(List<Kurs> kursy)
        {
            foreach (var kurs in kursy)
            {
                Console.WriteLine($"Nazwa: {kurs.Nazwa}, Data rozpoczęcia: {kurs.DataRozpoczecia.ToShortDateString()}, Czas trwania: {kurs.CzasTrwania} dni, Opis: {kurs.Opis}");
                if (kurs.Uczestnicy.Count > 0)
                {
                    Console.WriteLine("Uczestnicy:");
                    foreach (var uczestnik in kurs.Uczestnicy)
                    {
                        Console.WriteLine($"\tImię: {uczestnik.Imie}, Nazwisko: {uczestnik.Nazwisko}, Adres: {uczestnik.Adres}");
                    }
                }
                else
                {
                    Console.WriteLine("\tBrak uczestników przypisanych do kursu.");
                }
            }
        }

        public void WyswietlUczestnikowKursu(Kurs kurs)
        {
            Console.WriteLine($"Kurs: {kurs.Nazwa}");
            if (kurs.Uczestnicy.Count > 0)
            {
                foreach (var uczestnik in kurs.Uczestnicy)
                {
                    Console.WriteLine($"Imię: {uczestnik.Imie}, Nazwisko: {uczestnik.Nazwisko}, Adres: {uczestnik.Adres}");
                }
            }
            else
            {
                Console.WriteLine("Brak uczestników przypisanych do kursu.");
            }
        }

        public Uczestnik PobierzDaneUczestnika()
        {
            Console.WriteLine("Podaj imię:");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko:");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj adres:");
            string adres = Console.ReadLine();

            return new Uczestnik(imie, nazwisko, adres);
        }

        public Kurs PobierzDaneKursu()
        {
            Console.WriteLine("Podaj nazwę kursu:");
            string nazwa = Console.ReadLine();
            Console.WriteLine("Podaj datę rozpoczęcia (yyyy-MM-dd):");
            DateTime dataRozpoczecia = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Podaj czas trwania w dniach:");
            int czasTrwania = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj opis kursu:");
            string opis = Console.ReadLine();

            return new Kurs(nazwa, dataRozpoczecia, czasTrwania, opis);
        }

        public int PobierzNumerKursu(List<Kurs> kursy)
        {
            Console.WriteLine("Podaj numer kursu:");
            for (int i = 0; i < kursy.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {kursy[i].Nazwa}");
            }
            int numerKursu = int.Parse(Console.ReadLine());
            return numerKursu - 1;
        }

        public int PobierzNumerUczestnika(List<Uczestnik> uczestnicy)
        {
            Console.WriteLine("Podaj numer uczestnika:");
            for (int i = 0; i < uczestnicy.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {uczestnicy[i].Imie} {uczestnicy[i].Nazwisko}");
            }
            int numerUczestnika = int.Parse(Console.ReadLine());
            return numerUczestnika - 1;
        }
    }
}
