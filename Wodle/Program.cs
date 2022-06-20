using Wodle.Entities;
using Wodle.Services;

namespace Wodle
{
    class Program
    {
        static void Main(string[] args)
        {
            Prompt();
            SecretService.Check();
        }
        static void Prompt()
        {
            //Console.WriteLine("Guess" + lenght + "letter Word");
            Console.WriteLine("Guess the 5 letter word");
        }
        static int LenghtPrompt()
        {
            int len = 0;
            Console.WriteLine("How long word would you like to guess");
            return len = Console.Read();
        }

    }
}