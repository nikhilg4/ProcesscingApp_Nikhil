using ProcessingApp_Nikhil.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingApp_Nikhil.RuleClasses
{
    public class ActivateMemberRule:RulesHandler
    {
        public override void HandleRule(InputRequest inputRequest)
        {
            if (inputRequest != null && !inputRequest.MembershipDetailObj.IsActive)
            {
                //Membership Activation happens here
                Console.WriteLine(string.Format("Membership Activated for the Member"));
            }
            else if (successor != null)
            {
                successor.HandleRule(inputRequest);
            }
        }
    }
}
