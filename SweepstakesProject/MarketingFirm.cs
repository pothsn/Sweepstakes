using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class MarketingFirm
    {
        //Member vairables
        public ISweepstakesManager sweepstakesManager;

        public MarketingFirm(ISweepstakesManager sweepstakesManagers)
        {
            sweepstakesManager = sweepstakesManagers;
        }

        public void CreateSweepstakes()
        {
            Sweepstakes newSweepstakes = new Sweepstakes();
            sweepstakesManager.InsertSweepstakes(newSweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {          
            return sweepstakesManager.GetSweepstakes();
        }

        public void Run()
        {
            Sweepstakes ss = GetSweepstakes();
            Contestant winner = ss.PickWinner();
            ss.PrintContestantInfo(winner);
        }

        //Constructor

        //Member methods
        public void CreateContestant()
        {
            Contestant contestant = new Contestant();
            contestant.firstName = UserInterface.GetFirstName();
            contestant.lastName = UserInterface.GetLastName();
            contestant.emailAddress = UserInterface.GetEmailAddress();
        }
    }
}
