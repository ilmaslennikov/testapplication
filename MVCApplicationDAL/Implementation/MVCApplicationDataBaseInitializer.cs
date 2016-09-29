using System.Collections.Generic;
using DomainModel;

namespace MVCApplicationDAL.Implementation
{
    /// <summary>
    /// Инициализатор пустой базы данных
    /// </summary>
    public class MVCApplicationDataBaseInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MVCApplicationDbContext>
    {
        protected override void Seed(MVCApplicationDbContext context)
        {
            context.MenuItems.Add(new MenuItem
            {
                LinkText = "Анализ сообщений",
                ActionName = "Message",
                ControllerName = "Home"
            });
            context.MenuItems.Add(new MenuItem
                {
                    LinkText = "Радиомаяки",
                    ActionName = "",
                    ControllerName = "",
                    Items = new List<MenuItem>
                    {
                        new MenuItem
                        {
                            LinkText = "Список радиомаяков",
                            ActionName = "BeaconList",
                            ControllerName = "Home"
                        }
                    }
                });
            context.SaveChanges();
            base.Seed(context);
        }
    }
}
