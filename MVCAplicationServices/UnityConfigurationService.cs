
using Microsoft.Practices.Unity;
using MVCAplicationServices.Implementation;
using MVCApplicationDAL;
using MVCApplicationDAL.Implementation;

namespace MVCAplicationServices
{
    public static class UnityConfigurationService
    {
        public static void Configure(IUnityContainer container)
        {
            container.RegisterType<MVCApplicationDbContext, MVCApplicationDbContext>(new HierarchicalLifetimeManager()); // HierarchicalLifetimeManager нужен, чтобы в конце каждого запроса вызывался MVCApplicationDbContext.Dispose();
            container.RegisterType<IMenuRepository, MenuRepository>();
            container.RegisterType<IMenuService, MenuService>();
            container.RegisterType<IBeaconRepository, BeaconRepository>();
            container.RegisterType<IEventService, EventService>();
            container.RegisterType<IBeaconService, BeaconService>();
        }
    }
}
