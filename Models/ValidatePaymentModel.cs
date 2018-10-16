using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSPTest.Models
{
    public class ValidatePaymentModel
    {
        public string CVV { get; set; }
        public string CardNumber { get; set; }
        public bool Is3D { get; set; }
        public string RedirectUrl { get; set; }
    }
}
