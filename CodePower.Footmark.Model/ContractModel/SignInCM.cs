using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePower.Footmark.Model.ContractModel
{
    public class SignInCM
    {
        public int UserId { get; set; }

        public int ChurchId { get; set; }

        public string ChurchName { get; set; }

        public string FirstName { get; set; }

        public string GoesBy { get; set; }

        public string LastName { get; set; }

        public string ChurchCulture { get; set; }

        public string CurrencySymbol { get; set; }
    }
}
