using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bonus16
{
    class Validator
    {

        public static string MakeValidator(string askUser, string errorMessage)
        {
            Console.WriteLine(askUser);
            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput == null)
                {
                    Console.WriteLine(errorMessage);
                }
                else if (!Regex.IsMatch(userInput, @"^[a-zA-Z]{1,20}$"))
                {
                    Console.WriteLine(errorMessage);
                }
                else
                {
                    return userInput;
                }
            }
        }

        public static string ModelValidator(string askUser, string errorMessage)
        {
            Console.WriteLine(askUser);
            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput == null)
                {
                    Console.WriteLine(errorMessage);
                }
                else if (!Regex.IsMatch(userInput, @"^[a-zA-Z0-9]{1,20}$$"))
                {
                    Console.WriteLine(errorMessage);
                }
                else
                {
                    return userInput;
                }
            }
        }

        public static int YearValidator(string askUser, string errorMessage)
        {
            Console.WriteLine(askUser);
            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput == null)
                {
                    Console.WriteLine(errorMessage);
                }
                else if (!Regex.IsMatch(userInput, @"^[1][9]\d\d$|^[2][0][01]\d$"))
                {
                    Console.WriteLine(errorMessage);
                }
                else
                {
                    return int.Parse(userInput);
                }
            }
        }

        public static double PriceValidator(string askUser, string errorMessage)
        {
            Console.WriteLine(askUser);
            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput == null)
                {
                    Console.WriteLine(errorMessage);
                }
                else if (!Regex.IsMatch(userInput, @"^\d{1,10}$"))
                {
                    Console.WriteLine(errorMessage);
                }
                else
                {
                    return double.Parse(userInput);
                }
            }
        }

        public static string AddChoiceValidator(string askUser, string errorMessage)
        {
            Console.WriteLine(askUser);
            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput == null)
                {
                    Console.WriteLine(errorMessage);
                }
                else if (!Regex.IsMatch(userInput, @"^[yY]$|^[yY][eE][sS]$|^[nN]$|^[nN][oO]$"))
                {
                    Console.WriteLine(errorMessage);
                }
                else
                {
                    return userInput;
                }
            }
        }

    }
}
