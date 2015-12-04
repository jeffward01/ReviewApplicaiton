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
            //Map classes here



            base.OnModelCreating(modelBuilder);
        }











    }
}
