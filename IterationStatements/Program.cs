using System;
using System.Collections.Generic;
using System.Xml;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0
            var myNumber = 0;

            do
            {
                myNumber++;

                numbers.Add(myNumber);

            } while (myNumber < 100);

            while (myNumber < 200)
            {
                myNumber++;

                numbers.Add(myNumber);
            }

            Console.WriteLine("Increase:");

            
            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the amount of items in "numbers" (numbers.Count)
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            for(int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine($"{numbers[i]}");
            }
        }
    }
}
