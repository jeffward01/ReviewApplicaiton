using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Domain
{
    public class InsuranceAgentProfile
    {
        public int InsuranceAgentID { get; set; } // Primary Key
        public int UserID { get; set; } // Forign Key

        public string ProfileName { get; set; }
        public DateTime JoinDate { get; set; }

        // Change Terrortiory to list in the future
        public string Territory { get; set; }
        public int YearsOfExperience { get; set; }
        public string TypeOfAgent { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        //Recommended Lead Companies a list?
        public string RecommendedLeadCompanies { get; set; }
        //Reference LeadType?   (Types of Leads Used)
        public string TypesOfLeadsUsed { get; set; }
        public string ProfilePictureURL { get; set; }
        //Gravatar? Something special?
        public string Gravatar { get; set; }
        public string TwitterHandle { get; set; }
        public string AgentWebsiteURL { get; set; }
        public string InsuranceForumsHandle { get; set; }
        public int NumberOfReviewPosts { get; set; }
        public int NumberOfLikesRecieved { get; set; }
        public int AverageQuanitityOfLeadsPurchasedPerWeek { get; set; }
        public int AverageQuanitityOfLeadsPurchasedPerMonth { get; set; }


        //Add Vitrual Varibles

        //Add methods if any (update)

    }
}
