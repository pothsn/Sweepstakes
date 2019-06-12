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
        ISweepstakesManager ssm;

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
