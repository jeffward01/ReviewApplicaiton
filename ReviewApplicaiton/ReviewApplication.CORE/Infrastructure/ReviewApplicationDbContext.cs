using Microsoft.AspNet.Identity.EntityFramework;
using ReviewApplication.CORE.Infrastructure;
using ReviewApplication.CORE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Infrastructure
{
    public class ReviewApplicationDbContext : IdentityDbContext, IReviewApplicationDbContext 
    {
        public ReviewApplicationDbContext() : base("ReviewApplication")
        {

        }
    }
}
