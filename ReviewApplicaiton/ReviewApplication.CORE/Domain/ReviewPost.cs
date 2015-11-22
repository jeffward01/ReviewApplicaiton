using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Domain
{
    public class ReviewPost
    {
        public int ReviewPostID { get; set; } //Primary Key
        public int CompanyID { get; set; } // Foriegn Key
        public int InsuranceAgentID { get; set; } // Foriegn Key

        public int CompanyRating { get; set; }
        public string PostTitle { get; set; }
        public string PostBody { get; set; }
        public string NumberOfLikes { get; set; }
    }
}
