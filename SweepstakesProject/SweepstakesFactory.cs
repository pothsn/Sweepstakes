using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    static class SweepstakesFactory
    {
        public static ISweepstakesManager SelectSweepstakesManager(string managerType)
        {
            ISweepstakesManager manager = null;
            switch (managerType)
            {
                case "Stack":
                    manager = new SweepstakesStackManager();
                    break;
                case "Queue":
                    manager = new SweepstakesQueueManager();
                    break;
                default:
                    Console.WriteLine("Not a valid manager type.");
                    break;
            }
            return manager;
        }

    }
}
