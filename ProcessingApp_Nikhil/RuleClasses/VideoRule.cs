using ProcessingApp_Nikhil.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingApp_Nikhil
{
   public class VideoRule:RulesHandler
    {
        public override void HandleRule(InputRequest inputRequest)
        {
            if (inputRequest != null && inputRequest.ProductDetailObj.ProductType.ToLower() == "video")
            {
                //Add free "First Aid" video to packing slip
                Console.WriteLine(string.Format("Added free \"First Aid\" video to packing slip"));
                //Commission  payment for agent
                //Console.WriteLine(string.Format("Commission  payment for agent generated"));
            }
            else if (successor != null)
            {
                successor.HandleRule(inputRequest);
            }
        }
    }
}
