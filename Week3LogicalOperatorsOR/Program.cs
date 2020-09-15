using System;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;

namespace Week3LogicalOperatorsOR
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Seasons
             *A program asks the user what month they were born
             *December, January or February - You were born in winter
             *March, April or May - You were born in spring
             *June, July or August - You were born in summer
             *September, October or November - You were born in autumn
             */
            Console.WriteLine("What month were you born in?");
            string Month = Console.ReadLine().ToLower();
            if (Month == "december" || Month == "january" || Month == "february")
            {
                Console.WriteLine("You were born in winter");
            }
            else if (Month == "march" || Month == "april" || Month == "may")
            {
                Console.WriteLine("You were born in spring");
            }
            else if (Month == "june" || Month == "july" || Month == "august")
            {
                Console.WriteLine("You were born in summer");
            }
            else if (Month == "september" || Month == "october" || Month == "november")
            {
                Console.WriteLine("You were born in autumn");
            }else
            {
                Console.WriteLine($"{Month} is not a correct term for this test.")
            }
        }
    }
}
