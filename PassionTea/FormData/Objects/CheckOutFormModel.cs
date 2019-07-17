using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.Form_Data.Objects
{
    public class CheckOutFormModel
    {
        public string Email { get; set; }
        public string Name { get; set;}
        public string Address { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public string CardholderName { get; set;}
        public string VerificationCode { get; set;}
    }
}
