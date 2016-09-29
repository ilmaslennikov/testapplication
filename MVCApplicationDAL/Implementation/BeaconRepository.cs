using System.Collections.Generic;
using DomainModel;
using System.Linq;

namespace MVCApplicationDAL.Implementation
{
    /// <summary>
    /// Репоизиторий для работы с радиомаяками
    /// </summary>
    public class BeaconRepository : BaseRepository<Beacon>, IBeaconRepository
    {
        public BeaconRepository(MVCApplicationDbContext context) : base(context)
        {
        }

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
        public Beacon GetById(int id)
        {
            return Context.Beacons.FirstOrDefault(b => b.Id == id);
        }


        /// <summary>
        /// Возвращает список радиомаяков
        /// </summary>
        /// <returns>
        /// Список радиомаяков
        /// </returns>
        public IEnumerable<Beacon> GetBeacons()
        {
            return Context.Beacons.ToArray();
        }
    }
}
