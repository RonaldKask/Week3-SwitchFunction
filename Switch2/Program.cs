using System;

namespace Switch2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What was the result of your test?");
                string test = Console.ReadLine().ToUpper();

            switch (test)
            {
                case "A":
                    Console.WriteLine("Excellent!");
                    break;
                case "B":
                    Console.WriteLine("Very good!");
                    break;
                case "C":
                    Console.WriteLine("Passed!");
                    break;
                case "D":
                    Console.WriteLine("Failed!");
                    break;
                default:
                    Console.WriteLine("Wasted!");
                    break;


            }
        }
    }
}
