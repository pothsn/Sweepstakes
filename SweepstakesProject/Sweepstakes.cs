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
        public Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        public string name;
        Random rng;

        //Constructor
        public Sweepstakes()
        {
            name = null;
            rng = new Random();
        }
        public Sweepstakes(string name)
        {
            this.name = name;
            rng = new Random();
        }

        //Member methods
        public void RegisterContestant(Contestant contestant)
        {
            contestant.registrationNumber = contestants.Count + 1;
            contestants.Add(contestant.registrationNumber, contestant);            
        }

        //I got permission from Mike to return a Contestant object here instead of a string.
        public Contestant PickWinner()
        {
            int winnerRegistrationNumber = rng.Next(1, contestants.Count + 1);
            Contestant winner = contestants[winnerRegistrationNumber];
            return winner;         
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.firstName);
            Console.WriteLine(contestant.lastName);
            Console.WriteLine(contestant.emailAddress);
            Console.WriteLine(contestant.registrationNumber);
        }

        public void NotifyContestants(Contestant winner)
        {
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
                if (contestant.Key != winner.registrationNumber)
                {
                    Console.WriteLine(winner.firstName + " " + winner.lastName + " has won the sweepstakes.");
                }
                else
                {
                    Console.WriteLine("Congratulations, " + winner.firstName + " " + winner.lastName + ". You have won the sweepstakes!");
                }
            }
        }
    }
}
