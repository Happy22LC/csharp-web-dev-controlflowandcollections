using System;
using System.Collections.Generic;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lists!");

            //Within Main, create a list with at least 10 integers and call your method on the list.
            List<int> newList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //calling the method for sum of the all even numbers.
            Console.WriteLine("The sum of the even numbers: " + SumEven(newList));

            //print word in the list that has exactly 5 letters.
            List<string> myWordlist = new List<string> { "Hi", "cat", "fight", "blue", "happy" };
            //LetterWord(myWordlist);
            //user to enter the word length for the search
            Console.WriteLine("Enter the word Length: ");
            string input = Console.ReadLine();
            int numChar = int.Parse(input);
            LetterWord(myWordlist, numChar);

        }

        //Write a static method to find the sum of all the even numbers in a List.
        static int SumEven(List<int> arg)
        {
            int sum = 0;
            foreach (int num in arg)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }

        //Write a static method to print out each word in a list that has exactly 5 letters.
        /*static void LetterWord(List<string> wordlist)
        {

            foreach (string word in wordlist)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                }
            }

        }*/
        //The modified code for taking the length
        static void LetterWord(List<string> wordlist, int length)
        {

            foreach (string word in wordlist)
            {
                if (word.Length == length)
                {
                    Console.WriteLine(word);
                }
            }

        }
    }
}
