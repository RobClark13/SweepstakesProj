﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        private Stack<Sweepstakes> stack;

        public Sweepstakes GetSweepstakes()
        {
            return stack.Pop();
        }

        public void InsertSweepStakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
    }
}
