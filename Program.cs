using System;

namespace AB4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie ein Nummer grosser als null ein!");

            int eingabe = Convert.ToInt32(Console.ReadLine());
            int i = eingabe;
            int summe = eingabe;
            /* Null Ausnahme */
            if (eingabe == 0)
            {
                summe = 1;
                Console.WriteLine("Das Ergebnis ist: {0}", summe);
            }
            else if (eingabe > 0)
            {
                while (i >= 2)
                {
                    int things = i - 1;
                    summe = summe * things;
                    i = i - 1;
                }
                Console.WriteLine("Das Ergebnis ist: {0}", summe);
            }
            else
            {
                Console.WriteLine("Nicht Definiert!");
            }

        }
    }
}
