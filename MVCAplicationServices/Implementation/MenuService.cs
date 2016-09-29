using System;
using DomainModel;
using MVCApplicationDAL;

namespace MVCAplicationServices.Implementation
{
    /// <summary>
    /// Служба, отвечающая за работу с меню
    /// </summary>
    public class MenuService : IMenuService
    {
        /// <summary>
        /// Репозиторий для работы с меню
        /// </summary>
        private readonly IMenuRepository _menuRepositry;

        /// <summary>
        /// Создает новый объект службу доступа к меню
        /// </summary>
        /// <param name="menuRepositry">
        /// Репозиторий для доступа к меню
        /// </param>
        public MenuService(IMenuRepository menuRepositry)
        {
            if (menuRepositry == null)
            {
                throw new ArgumentNullException("menuRepositry");
            }
            _menuRepositry = menuRepositry;
        }

        /// <summary>
        /// Получить меню
        /// </summary>
        /// <returns>
        /// Меню сайта
        /// </returns>
        public MenuItem[] GetMenu()
        {
            return _menuRepositry.GetMenu();
        }
    }
}
