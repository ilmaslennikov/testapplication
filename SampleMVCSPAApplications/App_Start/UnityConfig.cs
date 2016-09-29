using System.Web.Mvc;
using Microsoft.Practices.Unity;
using MVCAplicationServices;
using Unity.Mvc5;

namespace SampleMVCSPAApplications
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            UnityConfigurationService.Configure(container);
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}