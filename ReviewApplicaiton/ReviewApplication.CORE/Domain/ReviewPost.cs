﻿using ReviewApplication.CORE.Models;
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
        public DateTime ReviewPostDate { get; set; }

        public int CompanyRating { get; set; }
        public int? AgentRating { get; set; }
        public string PostTitle { get; set; }
        public string PostBody { get; set; }
        public int NumberOfLikes { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual CompanyProfile Company { get; set; }
        public virtual InsuranceAgentProfile InsuranceAgent { get; set; }

        public void Update(ReviewPostModel reviewPost)
        {
            ReviewPostID = reviewPost.ReviewPostID;
            CompanyID = reviewPost.CompanyID;
            InsuranceAgentID = reviewPost.InsuranceAgentID;
            ReviewPostDate = reviewPost.ReviewPostDate;
            CompanyRating = reviewPost.CompanyRating;
            AgentRating = reviewPost.AgentRating;
            PostBody = reviewPost.PostBody;
            PostTitle = reviewPost.PostTitle;
            NumberOfLikes = reviewPost.NumberOfLikes;
        }
    }
}
