﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Models
{
    public class ReviewPostModel
    {
        public int ReviewPostID { get; set; } //Primary Key
        public int CompanyID { get; set; } // Foriegn Key
        public int InsuranceAgentID { get; set; } // Foriegn Key
        public DateTime ReviewPostDate { get; set; }

        public int CompanyRating { get; set; }
        public int? AgentRating { get; set; }
        public string PostTitle { get; set; }
        public string PostBody { get; set; }
        public int NumberOfLikes { get; set; }

        // I dont think these are needed
        //public CompanyProfileModel Company { get; set; }
        //public InsuranceProfileAgentModel InsuranceAgent { get; set; }

        public List<CommentModel> Comments { get; set; }
    }
}
