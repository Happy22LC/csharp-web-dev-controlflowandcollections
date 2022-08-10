using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Strings!");

            //create a string
            string sentence = @"I would not, could not, in a box. I would not, could not with a fox.I will not eat them in a house. I will not eat them with a mouse.";

            //split at spaces to create array
            string[] sentenceArray = sentence.Split(" ");

            //print array
            Console.WriteLine(string.Join(",", sentenceArray));

            //repeat to separate the sentence
            string[] sentenceArray2 = sentence.Split(" ");
            Console.WriteLine(string.Join("/", sentenceArray2));
        }
    }
}
