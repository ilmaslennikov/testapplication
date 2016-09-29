namespace MVCAplicationServices
{
    /// <summary>
    /// Служба для работы с меню
    /// </summary>
    public interface IMenuService
    {
        /// <summary>
        /// Получить меню
        /// </summary>
        /// <returns>
        /// Меню сайта
        /// </returns>
        DomainModel.MenuItem[] GetMenu();
    }
}
