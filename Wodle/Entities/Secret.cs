using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wodle.Entities
{
    internal class Secret
    {
        public static string Solution(int length)
        {
            string tajny = "";

            switch (length)
            {
                case 4:
                    tajny = "prdy";
                    break;
                case 5:
                    tajny = "hovno";
                    break;
                case 6:
                    tajny = "hektar";
                    break;
                case 7:
                    tajny = "maminka";
                    break;
                case 8:
                    tajny = "manifest";
                    break;
                default:
                    Console.WriteLine("Choose between 4 and 8");
                    break;
                    ;
            }
            return tajny;
        }
    }
}
