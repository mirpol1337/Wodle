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
;
        }
        static void Prompt()
        {
            Console.WriteLine("Guess 5 letter Word");
        }
        static int LenghtPrompt()
        {
            int len = 0;
            Console.WriteLine("How long word would you like to guess");
            return len = Console.Read();
        }

    }
}