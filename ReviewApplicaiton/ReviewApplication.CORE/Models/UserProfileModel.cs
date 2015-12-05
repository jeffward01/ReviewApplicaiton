using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Models
{
    public class UserProfileModel
    {

        public int UserID { get; set; } // Primary Key

        public string Email { get; set; }
        public string ResetEmail { get; set; }
        public List<string> Industry { get; set; }
        public string Password { get; set; }
        public string AccountType { get; set; }
        public DateTime CreatedDate { get; set; }

       
        //Add Either?
        public InsuranceProfileAgentModel InsuranceAgentProfile { get; set; }
        public CompanyProfileModel CompanyProfile { get; set; }

        //Add methods if any (update)

    }
}
