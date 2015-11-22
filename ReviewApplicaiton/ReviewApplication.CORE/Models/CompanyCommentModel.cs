using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Models
{
    public class CompanyCommentModel
    {
        public int CompanyCommentID { get; set; } // Primary Key
        public int ReviewID { get; set; } // Foriegn Key
        public int CompanyID { get; set; } // Foriegn Key
        public string PostBody { get; set; }
        public int NumberOfLikes { get; set; }

        public ReviewPostModel ReviewPost { get; set;
        }
        public List<AgentCommentModel> AgentComments { get; set; }
        public List<CompanyCommentModel> CompanyComments { get; set; }
        //Add Vitrual Varibles

        //Add methods if any (update)
    }
}
