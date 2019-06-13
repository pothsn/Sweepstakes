using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Sweepstakes sweepstakes = new Sweepstakes("testSweepstakes");
            Contestant testContestant1 = new Contestant();
            testContestant1.firstName = "nate";
            Contestant testContestant2 = new Contestant();
            testContestant2.firstName = "mike";
            Contestant testContestant3 = new Contestant();
            testContestant3.firstName = "nevin";

            sweepstakes.contestants.Add(1, testContestant1);
            sweepstakes.contestants.Add(2, testContestant2);
            sweepstakes.contestants.Add(3, testContestant3);

            Contestant winner = sweepstakes.PickWinner();
            Console.WriteLine(winner);
            Console.ReadLine();

            sweepstakes.PrintContestantInfo(testContestant1);


            //SweepstakesQueueManager thing = new SweepstakesQueueManager();
            //SweepstakesStackManager thing1 = new SweepstakesStackManager();

            string managerType = UserInterface.GetSweepstakesManagerType();
            ISweepstakesManager newManager = SweepstakesFactory.SelectSweepstakesManager(managerType);

            MarketingFirm marketingFirm = new MarketingFirm(newManager);









        }
    }
}
