﻿using Wodle.Entities;
using Wodle.Services;

namespace Wodle
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = LenghtPrompt();
            Prompt(lenght);
            SecretService.Check(lenght);
            Console.WriteLine("Hit Enter to quit");
            Console.ReadLine();
        }
        static void Prompt(int length)
        {
            Console.WriteLine("Guess " + length + " letter Word");
            //Console.WriteLine("Guess the 5 letter word");
        }
        public static int LenghtPrompt()
        {
            int len = 0;
            Console.WriteLine("Select length between 4 and 8");
            string inputString = Console.ReadLine();
            if (Int32.TryParse(inputString, out int numValue))
            {
                if (Enumerable.Range(4, 8).Contains(numValue))
                {
                    return numValue;
                }
                else if (!Enumerable.Range(4, 8).Contains(numValue))
                {
                    Console.WriteLine("Right lenght of word wasnt enter(or no number). Default length 5 chosen");
                }
            }
            else
            {
                Console.WriteLine("Right lenght of word wasnt enter(or no number). Default length 5 chosen");
            }
            return 5;
        }

    }
}