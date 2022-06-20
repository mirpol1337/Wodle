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
        public static void Check()
        {
            string guess = ReadAndValidate();
            if (guess.Equals(Secret.Solution(5)))
            {
                Result(true);
            }
            else
            {
                Result(false);
                Hint(guess);
                Check();
            }
        }
        static string ReadAndValidate()
        {
            string guess = Console.ReadLine();
            while (guess.Length != 5)
            {
                Console.WriteLine("Guess must contain 5 characters");
                guess = Console.ReadLine();
            }
            return guess.ToLowerInvariant();
        }
        static string Hint(string guess)
        {
            string hint = "";
            for (int i = 0; i < Secret.Solution(5).Length; i++)
            {
                if (guess[i].Equals(Secret.Solution(5)[i]))
                {
                    hint += "Y";
                }
                else if (Contains(guess[i]))
                {
                    hint += "C";
                }
                else
                {
                    hint += "N";
                }
            }
            Console.WriteLine(hint);
            return hint;
        }
        static bool Contains(Char guess)
        {

            if (Secret.Solution(5).Contains(guess))
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