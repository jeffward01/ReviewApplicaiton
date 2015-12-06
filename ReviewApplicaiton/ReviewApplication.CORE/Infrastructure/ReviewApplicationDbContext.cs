using Microsoft.AspNet.Identity.EntityFramework;
using ReviewApplication.CORE.Infrastructure;
using ReviewApplication.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ReviewApplication.CORE.Domain;

namespace ReviewApplication.CORE.Infrastructure
{
    public class ReviewApplicationDbContext : IdentityDbContext, IReviewApplicationDbContext 
    {
        public ReviewApplicationDbContext() : base("ReviewApplication")
        {

        }

        public IDbSet<Comment> Comments { get; set; }
        public IDbSet<CompanyProfile> CompanyProfiles { get; set; }
        public IDbSet<InsuranceAgentProfile> InsuranceAgentProfiles { get; set; }
        public IDbSet<LeadProduct> LeadProducts { get; set; }
        public IDbSet<LeadTransaction> LeadTransactions { get; set; }
        public IDbSet<ReviewPost> ReviewPosts { get; set; }
        public IDbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Map Review post to Comapny
            modelBuilder.Entity<ReviewPost>().HasKey(rp => rp.ReviewPostID);
            modelBuilder.Entity<ReviewPost>().HasRequired(c => c.Company)
                                                .WithMany(rp => rp.ReviewPosts)
                                                .HasForeignKey(c => c.CompanyID);

            //Map Review post to Agent
            modelBuilder.Entity<ReviewPost>().HasRequired(a => a.InsuranceAgent)
                                        .WithMany(rp => rp.ReviewPosts)
                                        .HasForeignKey(a => a.InsuranceAgentID);

            //Map Review Post to Comments
            modelBuilder.Entity<ReviewPost>().HasMany(c => c.Comments)
                                                .WithRequired(c => c.ReviewPost)
                                                .HasForeignKey(rp => rp.ReviewID);


            //Map to Comments to Comments
            modelBuilder.Entity<Comment>().HasKey(c => c.CommentID);
            modelBuilder.Entity<Comment>().



            //Map CompanyProfile to Transactions

            




            base.OnModelCreating(modelBuilder);
        }











    }
}
