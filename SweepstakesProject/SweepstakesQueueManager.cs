using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //Member variables
        Queue<Sweepstakes> sweepstakesQueue = new Queue<Sweepstakes>();

        //Member methods

        //Member methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesQueue.Enqueue(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesQueue.Dequeue();
        }
    }
}
