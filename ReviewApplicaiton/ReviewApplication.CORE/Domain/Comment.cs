﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewApplication.CORE;
using ReviewApplication.CORE.Models;

namespace ReviewApplication.CORE.Domain
{
    public class Comment
    {
        public int CommentID { get; set; }
        public DateTime CommentDate { get; set; }
        public int ReviewID { get; set; }
        public int? InsuranceAgentID { get; set; }
        public int? CompanyID { get; set; }
        public string PostBody { get; set; }
        public int NumberOfLikes { get; set; }

        //Set Virtual varibles

        //any Methods? Update
        public void Update(CommentModel comment)
        {
            //If new comment, set created date to now
            if(comment.CommentID == 0)
            {
                CommentDate = DateTime.Now;
            }

            CommentID = comment.CommentID;
            CommentDate = comment.CommentDate;
            ReviewID = comment.ReviewID;
            InsuranceAgentID = comment.InsuranceAgentID;
            CompanyID = comment.CompanyID;
            PostBody = comment.PostBody;
            NumberOfLikes = comment.NumberOfLikes;

        }

    }
}
