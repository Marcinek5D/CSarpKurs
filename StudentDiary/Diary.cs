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
        }

        // stan (zmienne - pola)
        List<float> ratings;                // delkaracja listy ocen typu float

        // zachowania/metody

        /// <summary>
        /// Dodawanie oceny
        /// </summary>
        /// <param name="rating">nowa ocena</param>     // "nowa ocena" - komentarz opisujacy dany parametr
        public void AddRating(float rating) // dodawanie oceny
        {
            ratings.Add(rating);
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
