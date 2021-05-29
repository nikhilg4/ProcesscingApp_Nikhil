using ProcessingApp_Nikhil.DTO;
using ProcessingApp_Nikhil.RuleClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingApp_Nikhil
{
    class Program
    {
        static void Main(string[] args)
        {
            RulesHandler h1 = new BookRule();
            RulesHandler h2 = new VideoRule();
            RulesHandler h3 = new ActivateMemberRule();
            RulesHandler h4 = new UpgradeMemberRule();
            //Console.WriteLine("Enter Input Details:");
            InputRequest inputRequest = new InputRequest() {  PaymentType= "ProductPayment",PaidAmount=5000};
            //inputRequest.MembershipDetailObj = new MembershipDetails();
            //inputRequest.MembershipDetailObj.IsActive = false;
            //inputRequest.MembershipDetailObj.MemberId = null;
            //inputRequest.MembershipDetailObj.MembershipType = null;

            inputRequest.ProductDetailObj = new ProductDetails();
            inputRequest.ProductDetailObj.ProductType = "video";

            if (inputRequest.PaymentType== "Membership")
            {
                h3.SetSuccessor(h4);
                h3.HandleRule(inputRequest);
                //Email Informing activation/upgradation
                Console.WriteLine(string.Format("Email Informing activation/upgradation sent"));
            }
            else
            {
                Random rnd = new Random();
                //Create packing slip here
                Console.WriteLine(string.Format("Packing Slip for Shipping is ready with ID:{0}", rnd.Next(1,100000000)));
                h1.SetSuccessor(h2);
                h1.HandleRule(inputRequest);
            }

            Console.WriteLine(string.Format("Processing done!!!!!!!"));
            Console.ReadKey();
        }
    }
}
