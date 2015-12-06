using ReviewApplication.DATA.Infrastrucure;
using ReviewApplication.CORE.Domain;
using ReviewApplication.CORE.Repository;
using ReviewApplication.CORE.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.DATA.Repository
{
    public class UserProfileRepository : Respositry<UserProfile>, IUserProfileRepository
    {
        public UserProfileRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        { }

    }
}
