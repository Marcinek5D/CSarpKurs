using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();

            // *************************************************************************************
            // to jest czesc programu z odcinka 15 - typy referencyjne
            // *************************************************************************************
            Diary d1 = new Diary();
            Diary d2 = d1;          // d2 wskazuje na ten sam obiekt co d1 (to nie jest skopiowanie danych z d1 do d2!!!!)

            d1 = new Diary();       // d1 wskazuje teraz na nowy obiekt (inny niz d2), d1 i d2 wskazuja na dwa rozne obiekty
            d1.Name = "Dzienniczek Marcina";

            Console.WriteLine(d2.Name);
            // -------------------------------------------------------------------------------------

            // *************************************************************************************
            // to jest czesc programu z odcinka 12/14 - STATIC
            // *************************************************************************************
            //diary.AddRating(5);
            //diary.AddRating(8.5f);
            //diary.AddRating(4.7f);
            //diary.AddRating(1.2f);
            //diary.AddRating(9.6f);

            //DiaryStatistics stats = diary.ComputeStatistics();

            //Console.WriteLine("Srednia ocen: " + stats.AverageGrade);
            //Console.WriteLine("Maksymalna ocena: " + stats.MaxGrade);
            //Console.WriteLine("Minimalna ocena: " + stats.MinGrade);

            //Console.WriteLine("\n" + "Diary.MaxGrade = " + Diary.MaxGrade + "\n");

            //Diary diary2 = new Diary();
            //Diary diary3 = new Diary();
            //Diary diary4 = new Diary();
            //Diary diary5 = new Diary();
            //Diary diary6 = new Diary();

            //Console.WriteLine("Liczba dzienniczkow: " + Diary.Count);
            // -------------------------------------------------------------------------------------

            // *************************************************************************************
            // to jest czesc programu z wczesniejszych odcinkow
            // *************************************************************************************
            /*
            diary.AddRating(5);
            diary.AddRating(8.5f);
            diary.AddRating(4.7f);
            float avg = diary.CalculateAverage();
            float max = diary.GivenMaxRating();
            float min = diary.GivenMinRating();
            */ // ----------------------------------------------------------------------------------

            // *************************************************************************************
            // to jest czesc programu z wczesniejszych odcinkow
            // *************************************************************************************
            /*
            for (; ; )
            {
                Console.WriteLine("Podaj ocene z zakresu 1-10. (11 konczy wprowadzanie ocen) ");
                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);       // wczytywanie oceny z konsoli i wpisywanie do rating
                                                                                    // zabezpieczenie przed wpisywaniem liter zamiast cyfr
                if (rating == 11)       // 11 zatrzymuje petle do wpisywania ocen
                {
                    break;
                }
                if (result)
                {
                    if (rating > 0 && rating <= 10) // jezeli liczba miesi sie w zakresie 1-10 to dopisz ja do dzienniczka
                    {
                        diary.AddRating(rating);    // dodawanie wpisanej oceny do dzienniczka
                    }
                    else                            // jezeli liczba z poza zakresu 1-10 to nie dopisuj jej, wyswietl tylko ostrzerzenie
                    {
                        Console.WriteLine("Niepoprawna liczba. Liczba z poza zakresu 1-10!");
                    }
                }
            }
            Console.WriteLine("Srednia twoich ocento: " + diary.CalculateAverage());
            Console.WriteLine("Najwyzsza ocena to: " + diary.GivenMaxRating());
            Console.WriteLine("Najnizsza ocena to: " + diary.GivenMinRating());
            */ // ----------------------------------------------------------------------------------

            Console.ReadKey();
        }
    }
}
