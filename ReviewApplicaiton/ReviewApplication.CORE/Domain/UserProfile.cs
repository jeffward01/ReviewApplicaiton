using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewApplication.CORE.Models;

namespace ReviewApplication.CORE.Domain
{
   public class UserProfile
    {
        public int UserID { get; set; } // Primary Key

        public string  Email { get; set; }
        public string ResetEmail { get; set; }
        public string Password { get; set; }
        public string AccountType { get; set; }
        public List<string> Industry { get; set; }
        public DateTime CreatedDate { get; set; }

        //Add Vitrual Varibles
        public virtual CompanyProfile CompanyProfile { get; set; }
        public virtual InsuranceAgentProfile InsuranceAgentProfile { get; set; }

         
        //Add methods if any (update)
        public void Update(UserProfileModel UserProfile)
        {
            //If new user, CreatedDate = now.
            if(UserProfile.UserID == 0)
            {
                CreatedDate = DateTime.Now;
            }

            Email = UserProfile.Email;
            ResetEmail = UserProfile.ResetEmail;
            Password = UserProfile.Password;
            AccountType = UserProfile.AccountType;
            Industry = UserProfile.Industry;
            CreatedDate = UserProfile.CreatedDate;
        }
    }
}
