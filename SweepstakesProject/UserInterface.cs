using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public static class UserInterface
    {
        public static string GetFirstName()
        {
            Console.WriteLine("Please enter contestant first name:");
            return Console.ReadLine();
        }

        public static string GetLastName()
        {
            Console.WriteLine("Please enter contestant last name:");
            return Console.ReadLine();
        }

        public static string GetEmailAddress()
        {
            Console.WriteLine("Please enter contestant email address:");
            return Console.ReadLine();
        }

        public static string GetSweepStakesName()
        {
            Console.WriteLine("Please enter a sweepstakes name:");
            return Console.ReadLine();
        }

        public static string GetSweepstakesManagerType()
        {
            Console.WriteLine("Please enter a sweepstakes manager type: Stack or Queue");
            return Console.ReadLine();
        }
    }
}
