using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek10_klasa_a_zmienna
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();  // zmienna diary typy Diary (dzienniczek)
            diary.AddRating(3);
            diary.AddRating(5);

            Diary diary2 = new Diary();
            diary2.AddRating(8);

            Diary diary3 = diary;       // diary3 i diary wskazuja na ten sam obiekt
            diary3.AddRating(8);

        }
    }
}
