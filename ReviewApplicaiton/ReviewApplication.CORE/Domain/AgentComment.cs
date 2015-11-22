using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Domain
{
   public class AgentComment
    {
        public int AgentCommentID { get; set; }
        public int ReviewID { get; set; }
        public int InsuranceAgentID { get; set; }
        public string PostBody { get; set; }
        public int NumberOfLikes { get; set; }


        //Add Vitrual Varibles

        //Add methods if any (update)

    }
}
