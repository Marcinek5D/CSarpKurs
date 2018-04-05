using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {
        // konstruktory
        public Diary()
        {
            ratings = new List<float>();    // inicjalizacja listy w konstruktorze
            Count++;                        // zwieksza licznik dzienniczkow w naszym programie
            Count2++;
        }

        // stan (zmienne - pola)
        private List<float> ratings;                // delkaracja listy ocen typu float

        public static float MinGrade = 0;           // dzieki "static" mozna odwolac sie do tych wartosci nawet bez tworzenia obiektow klasy Diary
        public static float MaxGrade = 10;          // ("static" jest dostepne z poziomu klast a nie obiektu!!!!)
        public static long Count = 0;       // zlicza ilosc dzienniczkow w naszym programie

        public long Count2 = 0;             // dla pokazania ze zwykla zmienna rozni sie od "static" i jest dostepna z poziomu obiektu, a nie samej klasy

        // zachowania/metody

        /// <summary>
        /// Dodawanie oceny
        /// </summary>
        /// <param name="rating">nowa ocena</param>     // "nowa ocena" - komentarz opisujacy dany parametr
        public void AddRating(float rating) // dodawanie oceny
        {
            if (rating > 0 && rating <= 10)
            {
                ratings.Add(rating);
            }
            
        }

        /// <summary>
        ///  Obliczanie statystyk dzienniczka i przechowywanie ich w nowym obiekcie DiaryStatistics
        /// </summary>
        /// <returns></returns>
        internal DiaryStatistics ComputeStatistics()    // Obliczanie statystyk ocen - odcinek 12
        {
            DiaryStatistics stats = new DiaryStatistics();

            float sum = 0f;                 // f - ze to liczba float a nie int
            foreach (var rating in ratings)
            {
                sum += rating;              // sumowanie wszystkich ocen
            }

            stats.AverageGrade = sum / ratings.Count();    // Count() - zwraca ilosc elementow (tutaj na liscie/kolekcji ratings)
            stats.MaxGrade = ratings.Max();
            stats.MinGrade = ratings.Min();

            return stats;
        }

        // *************************************************************************************
        // to jest niepotrzebne przez odcinek 12 - wszystko jest liczone wyrzej przez metode ComputeStatistics()
        // *************************************************************************************
         /*
        /// <summary>
        /// Obliczamy srednia naszych ocen
        /// </summary>
        /// <returns></returns>
        public float CalculateAverage()     // obliczenie sredniej ocen
        {
            float sum = 0, avg = 0;

            foreach (var rating in ratings)
            {
                sum += rating;              // sumowanie wszystkich ocen
            }

            avg = sum / ratings.Count();    // Count() - zwraca ilosc elementow (tutaj na liscie/kolekcji ratings)

            return avg;
        }

        /// <summary>
        /// Pobieramy najwyzsza ocene
        /// </summary>
        /// <returns></returns>
        public float GivenMaxRating()
        {
            return ratings.Max();           // Max() - zwraca najwiekszy element na liscie
        }

        /// <summary>
        /// Pobieramy najnizsza ocene
        /// </summary>
        /// <returns></returns>
        public float GivenMinRating()
        {
            return ratings.Min();           // Min() - zwraca najmniejszy element na liscie
        }
        */
        // -------------------------------------------------------------------------------------
    }
}
