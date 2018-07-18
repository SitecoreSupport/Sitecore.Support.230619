using Sitecore.Security.Accounts;
using Sitecore.Services.Core.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.Services.Infrastructure.Sitecore.Security
{
  public class UserServiceEx : global::Sitecore.Services.Infrastructure.Sitecore.Security.UserService, IUserService
  {
    bool IUserService.IsAnonymousUser
    {
      get
      {
        if (Context.User != null && Context.User.IsAuthenticated)
        {
          return false;
        }
        return true;
      }
    }

   
  }
}