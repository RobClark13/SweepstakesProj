using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        //member variables
        public string name;
        Dictionary<int, Contestant> contestants;
        //Constructor
        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }
       //Member methods
        public void RegisterContestant(Contestant contestant)
        {
            contestant.FirstName = UserInterface.GetUserInputFor("What is your first name?");
            contestant.LastName = UserInterface.GetUserInputFor("What is your last name?");
            contestant.EmailAddress = UserInterface.GetUserInputFor("What is your email address?");
            contestant.RegistrationNumber = contestants.Count;
        }
        public Contestant PickWinner()
        {
            int maxNumber = contestants.Count-1;
            Random winningNumberRand = new Random();
            int winningNumber = winningNumberRand.Next(maxNumber);
            return contestants[winningNumber];
        }
        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
