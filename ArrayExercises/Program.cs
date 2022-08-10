using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Arrays!");

            //initialize array in a single line
            int[] numArray = { 1, 1, 2, 3, 5, 8 };

            //Loop through the array and print each value.
            foreach (int num in numArray)
            {
                Console.WriteLine(num);
            }

            //Modify t0 print only the odd numbers
            foreach (int num in numArray)
            {
                if (num % 2 == 1)
                {
                    Console.WriteLine(num);
                }
            }

        }
    }
}
