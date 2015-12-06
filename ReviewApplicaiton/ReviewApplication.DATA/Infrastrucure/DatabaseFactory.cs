using ReviewApplication.CORE.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.DATA.Infrastrucure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private readonly ReviewApplicationDbContext _dataContext;

        public ReviewApplicationDbContext GetDataContext()
        {
            return _dataContext ?? new ReviewApplicationDbContext();
        }

        public DatabaseFactory()
        {
            _dataContext = new ReviewApplicationDbContext();
        }

        protected override void DisposeCore()
        {
            if(_dataContext != null)
            {
                _dataContext.Dispose();
            }
        }
    }
}
