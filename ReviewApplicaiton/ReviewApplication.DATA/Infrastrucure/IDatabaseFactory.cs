using ReviewApplication.CORE.Infrastructure;
using ReviewApplication.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.DATA.Infrastrucure
{
    public interface IDatabaseFactory : IDisposable
    {
        ReviewApplicationDbContext GetDataContext();
    }
}
