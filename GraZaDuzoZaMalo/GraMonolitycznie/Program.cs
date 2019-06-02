using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMonolitycznie
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(100);
            int number;
            int counter = 0;

            Console.WriteLine("Witaj w grze.\nWybierz liczbę z zakesu 1-100:");

            while(true)
            {
                counter++;
                number = Convert.ToInt32(Console.ReadLine());
                if (number == randomNumber)
                {
                    Console.WriteLine("Brawo wygrałeś");
                    break;
                }
                else if(number > randomNumber)
                {
                    Console.WriteLine("Za dużo");
                    continue;
                }
                else if(number < randomNumber)
                {
                    Console.WriteLine("Za mało");
                    continue;
                }
                else if(number > 100 || number < 1)
                {
                    Console.WriteLine("Podana liczba nie mieści się w zakresie");
                    continue;
                }
                else
                {
                    Console.WriteLine("Nieoczekiwany błąd");
                    continue;
                }
            }
            
            Console.WriteLine("Udało ci się zgadnąć w " + counter + " próbach");
            Console.ReadKey();
        }
    }
}
