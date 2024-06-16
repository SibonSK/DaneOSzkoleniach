# Program do Zbierania Danych o Szkoleniach Zdalnych

## Opis projektu
Celem tego projektu jest stworzenie aplikacji konsolowej w języku C#, która umożliwia zbieranie i zarządzanie danymi uczestników szkoleń zdalnych. Aplikacja pozwala na dodawanie uczestników i kursów, przypisywanie uczestników do kursów oraz wyświetlanie listy uczestników przypisanych do konkretnego kursu.

## Funkcjonalności
- Dodawanie uczestników
- Dodawanie kursów
- Przypisywanie uczestników do kursów
- Wyświetlanie listy uczestników
- Wyświetlanie listy kursów wraz z przypisanymi uczestnikami
- Wyświetlanie uczestników przypisanych do wybranego kursu

## Wymagania
- Windows 10/11
- Microsoft Visual Studio minimum w wersji Community 2019
- .NET Framework

## Instalacja i uruchomienie
1. Sklonuj repozytorium na swój lokalny komputer:
    ```bash
    git clone https://github.com/SibonSK/DaneOSzkoleniach.git
    ```

2. Otwórz projekt w Microsoft Visual Studio.

3. Skompiluj projekt, klikając **Build** > **Build Solution**.

4. Uruchom aplikację, klikając **Debug** > **Start Debugging** lub naciskając **F5**.

## Użycie
Po uruchomieniu aplikacji zostanie wyświetlone menu z następującymi opcjami:
1. Dodaj uczestnika
2. Dodaj kurs
3. Przypisz uczestnika do kursu
4. Wyświetl uczestników
5. Wyświetl kursy
6. Wyświetl uczestników kursu
7. Wyjście

Wybierz odpowiednią opcję, wpisując numer opcji i postępuj zgodnie z instrukcjami wyświetlanymi na ekranie.

## Struktura projektu
- **Model**
  - `Uczestnik.cs`: Klasa reprezentująca uczestnika szkolenia.
  - `Kurs.cs`: Klasa reprezentująca kurs szkoleniowy.
- **View**
  - `View.cs`: Klasa odpowiedzialna za interakcję z użytkownikiem.
- **Controller**
  - `Controller.cs`: Klasa zarządzająca logiką aplikacji i komunikacją między Modelem a View.
- **Program.cs**: Główna klasa uruchamiająca aplikację.

## Przykład użycia
1. Dodaj nowego uczestnika, wpisując jego imię, nazwisko i adres.
2. Dodaj nowy kurs, podając jego nazwę, datę rozpoczęcia, czas trwania i opis.
3. Przypisz uczestnika do kursu, wybierając z listy dostępnych kursów i uczestników.
4. Wyświetl listę kursów wraz z przypisanymi uczestnikami.

## Autor
- **Imię i Nazwisko**: [Twój Profil GitHub](https://github.com/SibonSK)

