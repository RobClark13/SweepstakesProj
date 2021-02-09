using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static string GetUserInputFor(string prompt)
        {
            Console.WriteLine(prompt);
            string userInput = Console.ReadLine();
            return userInput;
        }

        public static void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("Contestant's  name is " + contestant.FirstName+ " "+ contestant.LastName);
            Console.WriteLine("Contestant's email is " + contestant.EmailAddress);
            Console.ReadLine();
        }

    }
}
