using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
       //I am using dependecy injection here when I create the Marketing Firm. The benefit of it is that I don't have to create
       //separate methods to be able to use either the Queue Manager or the Stack Manager.
        public void CreateMarketingFirmWithManager()
        {
            string type = UserInterface.GetUserInputFor("Would you like to use a Queue Manager or Stack Manager for your sweepstakes? Press 1 for Queue or Press 2 for Stack");
            MarketingFirm marketingFirm = new MarketingFirm(ManagerChoice(type));
        }
        public ISweepstakesManager ManagerChoice(string type)
        {
            switch (type)
            {
                case "1":
                    return new SweepstakesQueueManager();
                case "2":
                    return new SweepstakesStackManager();
                default:
                    throw new ApplicationException(string.Format("Not a valid choice"));
            }
        }

    }
}
