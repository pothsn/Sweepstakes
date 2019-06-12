using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Sweepstakes
    {
        //Member variables
        Dictionary<string, string> test = new Dictionary<string, string>();
        string name;

        //Constructor
        public Sweepstakes(string name)
        {
            name = "Super Duper Random Sweepstakes";
        }

        //Member methods
        public void RegisterContestant(Contestant contestant) //Adding to dictionary
        {
            contestant.firstName = UserInterface.GetFirstName();
            contestant.lastName = UserInterface.GetLastName();
            contestant.emailAddress = UserInterface.GetEmailAddress();
            contestant.registrationNumber = UserInterface.GetRegistrationNumber();
        }

        public string PickWinner() //Using dictionary
        {
            return "placeholder";
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }


    }
}
