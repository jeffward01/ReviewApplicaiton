using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Infrastructure
{
    public interface IReviewApplicationDbContext : IDisposable
    {
        //Add Classes Here

        int SaveChanges();
    }
}
