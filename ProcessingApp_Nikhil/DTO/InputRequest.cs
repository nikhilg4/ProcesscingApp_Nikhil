using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessingApp_Nikhil.DTO
{
    public class InputRequest
    {
        public string PaymentType;
        public long PaidAmount;
        public ProductDetails ProductDetailObj;
        public MembershipDetails MembershipDetailObj;
    }
    public class ProductDetails
    {
        public string ProductType;
        //public string ProductName;
    }
    public class MembershipDetails
    {
        public string MemberId;
        public string MembershipType;
        public bool IsActive;
    }
}
