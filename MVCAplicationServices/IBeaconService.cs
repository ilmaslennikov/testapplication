using System.Collections.Generic;
using DomainModel;

namespace MVCAplicationServices
{
    /// <summary>
    /// Служба для работы с радиомаяками
    /// </summary>
    public interface IBeaconService
    {
        /// <summary>
        /// Возвращает радиомаяк по его идентификатору
        /// </summary>
        /// <param name="id">
        /// Идентификатор радиомаяка
        /// </param>
        /// <returns>
        /// Радиомаяк
        /// </returns>
        Beacon GeBeacon(int id);

        /// <summary>
        /// Возвращает список радиомаяков
        /// </summary>
        /// <returns>
        /// Список радиомаяков
        /// </returns>
        IEnumerable<Beacon> GeBeacons();
    }
}
