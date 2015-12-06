using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Repository
{
  public interface IAuthRepository : IDisposable
    {
        Task<IdentityResult> RegisterUser(RegistrationModel userModel);
        Task<User> FindUser(string userName, string password);
    }
}

}
