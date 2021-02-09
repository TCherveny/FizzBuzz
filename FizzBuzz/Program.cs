using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            Console.ReadLine();
            //Fizzbuzz(15);
        }

        public static void Fizzbuzz(int number)
        {

            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Fizzbuzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
        }
    }
}