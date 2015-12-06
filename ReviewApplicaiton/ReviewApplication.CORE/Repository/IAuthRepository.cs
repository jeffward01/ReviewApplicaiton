using Microsoft.AspNet.Identity;
using ReviewApplication.API.Models;
using ReviewApplication.CORE.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewApplication.CORE.Repository
{
  public interface IAuthRepository : IDisposable
    {
        Task<IdentityResult> RegisterUser(UserModel userModel);
        Task<UserProfile> FindUser(string userName, string password);
    }
}


