using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewApplication.CORE.Models;
using Microsoft.AspNet.Identity;
using ReviewApplication.CORE.Repository;
using ReviewApplication.CORE.Models;
using ReviewApplication.CORE.Domain;

namespace ReviewApplication.CORE.Domain
{
   public class UserProfile : IUser<int>
    {
        public int UserID { get; set; } // Primary Key

        public string  Email { get; set; }
        public string ResetEmail { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
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
            PasswordHash = UserProfile.PasswordHash;
            UserName = UserProfile.UserName;
            SecurityStamp = UserProfile.SecurityStamp;
            AccountType = UserProfile.AccountType;
            Industry = UserProfile.Industry;
            CreatedDate = UserProfile.CreatedDate;
        }
    }
}
