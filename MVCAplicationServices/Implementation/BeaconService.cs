using System.Collections.Generic;
using DomainModel;
using MVCApplicationDAL;

namespace MVCAplicationServices.Implementation
{
    /// <summary>
    /// Служба для работы с радиомаяками
    /// </summary>
    public class BeaconService : IBeaconService
    {
        private readonly IBeaconRepository _beaconRepository;
        public BeaconService(IBeaconRepository beaconRepository)
        {
            _beaconRepository = beaconRepository;
        }

        /// <summary>
        /// Возвращает радиомаяк по его идентификатору
        /// </summary>
        /// <param name="id">
        /// Идентификатор радиомаяка
        /// </param>
        /// <returns>
        /// Радиомаяк
        /// </returns>
        public Beacon GeBeacon(int id)
        {
            return _beaconRepository.GetById(id);
        }


        /// <summary>
        /// Возвращает список радиомаяков
        /// </summary>
        /// <returns>
        /// Список радиомаяков
        /// </returns>
        public IEnumerable<Beacon> GeBeacons()
        {
            return _beaconRepository.GetBeacons();
        }
    }
}
