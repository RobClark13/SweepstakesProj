using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        private ISweepstakesManager _manager;

        public MarketingFirm(ISweepstakesManager _manager)
        {
            this._manager = _manager;
        }
        public void CreateSweepstakes()
        {
            string sweepstakesName =UserInterface.GetUserInputFor("What is the name of the sweepstakes?");
            Sweepstakes sweepstakes = new Sweepstakes(sweepstakesName);
        }
    }
}
