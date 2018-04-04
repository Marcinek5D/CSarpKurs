using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {
        // stan (zmienne - pola)
        List<float> ratings;                // delkaracja listy ocen typu float
        
        // zachowania/metody
        public void AddRating(float rating) // dodawanie oceny
        {
            ratings.Add(rating);
        }

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

        public float GivenMaxRating()
        {
            return ratings.Max();           // Max() - zwraca najwiekszy element na liscie
        }

        public float GivenMinRating()
        {
            return ratings.Min();           // Min() - zwraca najmniejszy element na liscie
        }

    }
}
