using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Models
{
   public class AgentCommentModel
    {
        public int AgentCommentID { get; set; }  //Primary Key
        public int ReviewID { get; set; } //Foriegn Key
        public int InsuranceAgentID { get; set; } // Foriegn Key
        public string PostBody { get; set; }
        public int NumberOfLikes { get; set; }

        public ReviewPostModel ReviewPost { get; set; }

        public List<AgentCommentModel> AgentComments { get; set; }
        public List<CompanyCommentModel> CompanyComments { get; set; }

        //Add methods if any (update)

    }
}
