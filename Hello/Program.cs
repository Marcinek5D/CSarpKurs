using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();

            for (; ;)
            {
                Greeting();
                Age();
                Settings();
            }
        }

        /// <summary>
        /// Wypisuje maksymalne i minimalne wartosci danych typow liczbowych
        /// </summary>
        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }

        /// <summary>
        /// Wypisujemy powitanie uzytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Wpisz swoje imie: ");        // wyswietla tekst na ekranie bez entera na koncu lini
            string name = Console.ReadLine();
            Console.WriteLine("Witaj, " + name + '!');  // wyswietle tekst na ekranie z enterem na koncu lini
        }

        /// <summary>
        /// Wypisujemy komunikat zalezny od wieku uzytkonwika
        /// </summary>
        private static void Age()
        {
            Console.Write("Podaj ile masz lat: ");

            // int.Parse konwertuje wchodzacego stringa na inta - jest niedobry bo nie zabezpiecza przed wpisywaniem liter zamiast cyfr
            // int age = int.Parse(Console.ReadLine());
            int age;
            // TryParse - jezeli uzytkownik poda wiek jako cyfre to zostanie to przypisane do "age" i "result" bedzie rowny 1 (true),
            // a jezeli uzytkownik wpisze jakies litery to wtedy "age" zostanie ustawione na 0, a "result" bedzie rowny 0 (false)
            bool result = int.TryParse(Console.ReadLine(), out age);


            if (age >= 18)      // instrukcja warunkowa sprawdzajaca czy uzytkownik jest pelnoletni
            {
                Console.ForegroundColor = ConsoleColor.Green;       // zmienia kolor tekstu w konsoli na zielony
                Console.WriteLine("Masz " + age + " lat. Brawo. Jestes pelnoletni, mozesz wypic browarka!");
            }
            else if (result == false)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Wprowadziles niepoprawny wiek!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Masz " + age + " lat. Wypij mleko, a nie piwo w glowie!");
            }
        }

        /// <summary>
        /// Reset ustawien, czeka na wzicniecie klawisza, czysci tekst konsoli, reset koloru tekstu w konsoli do domyslnego
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();      // czeka na wcisniecie jakiegokolwiek klawisza (tu zatrzymuje program przez natychmiastowym zamknieciem go
            Console.Clear();        // czysci cala konsole
            Console.ResetColor();   // reset koloru tekstu w konsoli do domyslnego
        }
    }
}