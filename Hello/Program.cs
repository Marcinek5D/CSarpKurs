using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = args[0];

            Console.WriteLine("witaj, " + name);

            // petla pobierajaca kazdy element (item) z tablicy "args" 
            //foreach (var item in args)
            //{
            //    Console.WriteLine("Witaj, " + item);
            //}

            foreach (var item in args)
            {
                Console.WriteLine("Witaj, " + item);
            }

        }
    }
}