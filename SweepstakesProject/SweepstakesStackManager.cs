using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        //Member variables
        public Stack<Sweepstakes> sweepstakesStack = new Stack<Sweepstakes>();

        //Member methods

        //Member methods
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakesStack.Push(sweepstakes);
        }

        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesStack.Pop();
        }
    }
}
