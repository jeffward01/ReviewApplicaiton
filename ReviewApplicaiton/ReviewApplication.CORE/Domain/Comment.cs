using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Domain
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int ReviewID { get; set; }
        public int? InsuranceAgentID { get; set; }
        public int? CompanyID { get; set; }
        public string PostBody { get; set; }
        public int NumberOfLikes { get; set; }
    }
}
