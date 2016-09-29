using System.Data.Entity;
using System.Linq;
using DomainModel;

namespace MVCApplicationDAL.Implementation
{
    /// <summary>
    /// Предоставляет методы для работы с меню сайта
    /// </summary>
    public class MenuRepository : BaseRepository<MenuItem>, IMenuRepository
    {
        public MenuRepository(MVCApplicationDbContext context)
            : base(context)
        { }

        /// <summary>
        /// Возвращает меню сайта
        /// </summary>
        /// <returns>
        /// Меню
        /// </returns>
        public MenuItem[] GetMenu()
        {
            return Context.MenuItems.Include(m => m.Items).Where(m => m.ParentMenuItemId == null).OrderByDescending(m => m.Id).ToArray();
        }
    }
}
