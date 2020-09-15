using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day of the week is it?");
            string Day = Console.ReadLine().ToLower();
            if (Day == "monday" || Day == "tuesday" || Day == "wednesday" || Day == "thursday" || Day == "friday")
            {
                Console.WriteLine("Today is a weekday.");
            }
            else if (Day == "saturday" || Day == "sunday")
            {
                Console.WriteLine("Today is a weekend day.");
            }else
            {
                Console.WriteLine($"{Day} is not a day.");
            }

        }
    }
}
