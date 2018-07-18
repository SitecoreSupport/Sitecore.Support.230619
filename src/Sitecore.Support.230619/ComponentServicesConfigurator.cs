using Microsoft.Extensions.DependencyInjection;
using Sitecore.DependencyInjection;
using Sitecore.Services.Core.Security;
using Sitecore.Services.Infrastructure.Sitecore.Security;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Sitecore.Support.Services.Infrastructure.Sitecore.DependencyInjection
{
  public class ComponentServicesConfigurator : global::Sitecore.Services.Infrastructure.Sitecore.DependencyInjection.ComponentServicesConfigurator, IServicesConfigurator
  {
    void IServicesConfigurator.Configure(IServiceCollection serviceCollection)
    {
      base.Configure(serviceCollection);
      var descriptor = serviceCollection.First(d => d.ServiceType == typeof(IUserService)); 
      serviceCollection.Remove(descriptor);
      serviceCollection.AddScoped<IUserService, global::Sitecore.Support.Services.Infrastructure.Sitecore.Security.UserServiceEx>();
    }
  }
}