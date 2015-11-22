using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Domain
{
    public class ReviewPost
    {
        public int ReviewID { get; set; }
        public int CompanyID { get; set; }
        public int InsuranceAgentID { get; set; }
        public int CompanyRating { get; set; }
        public string PostTitle { get; set; }
        public string PostBody { get; set; }
        public string NumberOfLikes { get; set; }
    }
}
