namespace MVCApplicationDAL
{

    /// <summary>
    /// Предоставляет методы для работы с меню сайта
    /// </summary>
   public interface IMenuRepository
    {
        /// <summary>
        /// Возвращает меню сайта
        /// </summary>
        /// <returns>
        /// Меню
        /// </returns>
        DomainModel.MenuItem[] GetMenu();
    }
}
