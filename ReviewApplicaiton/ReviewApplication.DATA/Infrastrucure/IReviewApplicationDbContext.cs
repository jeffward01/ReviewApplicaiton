using ReviewApplication.CORE.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Infrastructure
{
    public interface IReviewApplicationDbContext : IDisposable
    {
        IDbSet<Comment> Comments { get; set; }
        IDbSet<CompanyProfile> CompanyProfiles { get; set; }
        IDbSet<InsuranceAgentProfile> InsuranceAgentProfiles { get; set; }
        IDbSet<LeadProduct> LeadProducts { get; set; }
        IDbSet<LeadTransaction> LeadTransactions { get; set; }
        IDbSet<ReviewPost> ReviewPosts { get; set; }
        IDbSet<UserProfile> UserProfiles { get; set; }

        int SaveChanges();
    }
}
