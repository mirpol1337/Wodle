using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wodle.Entities;

namespace Wodle.Services
{
    public class SecretService
    {
        public static void Check(int lenght)
        {
            string guess = ReadAndValidate(lenght);
            if (guess.Equals(Secret.Solution(lenght)))
            {
                Result(true);
            }
            else
            {
                Result(false);
                Hint(guess,lenght);
                Check(lenght);
            }
        }
        static string ReadAndValidate(int lenght)
        {
            string guess = Console.ReadLine();
            while (guess.Length != lenght)
            {
                Console.WriteLine("Guess must contain " + lenght + " characters");
                guess = Console.ReadLine();
            }
            return guess.ToLowerInvariant();
        }
        static void Hint(string guess, int length)
        {
            string hint = "";
            for (int i = 0; i < Secret.Solution(length).Length; i++)
            {
                if (guess[i].Equals(Secret.Solution(length)[i]))
                {
                    hint += "Y";
                }
                else if (Contains(guess[i],length))
                {
                    hint += "C";
                }
                else
                {
                    hint += "N";
                }
            }
            Console.WriteLine(hint);
        }
        static bool Contains(Char guess, int lenght)
        {

            if (Secret.Solution(lenght).Contains(guess))
            {
                return true;
            }

            return false;
        }
        static void Result(bool result)
        {
            if (result)
            {
                Console.WriteLine("CORRECT");
            }
            else
            {
                Console.WriteLine("Guess Again");
            }
        }
    }
}