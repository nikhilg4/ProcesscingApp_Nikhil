using ProcessingApp_Nikhil.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProcessingApp_Nikhil.DTO.InputRequest;

namespace ProcessingApp_Nikhil.RuleClasses
{
    public class BookRule:RulesHandler
    {
        public override void HandleRule(InputRequest inputRequest)
        {
            if (inputRequest != null && inputRequest.ProductDetailObj.ProductType.ToLower()=="book")
            {
                Random rnd = new Random();
                //Create duplicate packing slip if its book
                Console.WriteLine(string.Format("Duplicate Packing Slip for Royality Dept is ready with ID:{0}", rnd.Next(1, 100000000)));
                //Commission  payment for agent
                Console.WriteLine(string.Format("Commission  payment for agent generated"));
            }
            else if (successor != null)
            {
                successor.HandleRule(inputRequest);
            }
        }
    }
}
