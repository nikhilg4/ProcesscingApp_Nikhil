using ProcessingApp_Nikhil.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingApp_Nikhil.RuleClasses
{
    public class UpgradeMemberRule:RulesHandler
    {
        public override void HandleRule(InputRequest inputRequest)
        {
            if (inputRequest != null && inputRequest.MembershipDetailObj.IsActive)
            {
                //Membership upgradation happens here
                if (inputRequest.PaidAmount >= 2500)
                {
                    Console.WriteLine(string.Format("You are now a Gold  Member"));
                }
                if (inputRequest.PaidAmount >= 5000)
                {
                    Console.WriteLine(string.Format("You are now a Diamond Member"));
                }
                if (inputRequest.PaidAmount >= 10000)
                {
                    Console.WriteLine(string.Format("You are now a Platinum Member"));
                }

            }
            else if (successor != null)
            {
                successor.HandleRule(inputRequest);
            }
        }
    }
}
