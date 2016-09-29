using System.Collections.Generic;
using DomainModel;

namespace MVCApplicationDAL
{
    /// <summary>
    /// Репозиторий для работы с радиомаяками
    /// </summary>
    public interface IBeaconRepository
    {
        /// <summary>
        /// Возвращает радиомаяк по его идентификатору
        /// </summary>
        /// <param name="id">
        /// Идентификатор радиомаяка
        /// </param>
        /// <returns>
        /// Объект радиомаяка с указанным идентификатором
        /// или 
        /// null, если маяк не найден
        /// </returns>
        Beacon GetById(int id);

        /// <summary>
        /// Возвращает коллекцию радиомаяков
        /// </summary>
        /// <returns>
        /// Коллекция радиомаяков, содержащихся в системе
        /// </returns>
        IEnumerable<Beacon> GetBeacons();
    }
}
