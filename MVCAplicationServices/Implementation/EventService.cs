using DomainModel;
using MVCAplicationServices.ViewModel;
using MVCApplicationDAL;
using System.Collections.Generic;

namespace MVCAplicationServices.Implementation
{
    /// <summary>
    /// Служба для работы с событиями радиомаяков
    /// </summary>
    public class EventService : IEventService
    {
        private readonly IBeaconRepository _beaconRepository;

        public EventService(IBeaconRepository beaconRepository)
        {
            _beaconRepository = beaconRepository;
        }
        /// <summary>
        /// Разборать текст файла соообщениями 
        /// </summary>
        /// <param name="messages">
        /// Строки файла, содержащие информацию о сообщении
        /// </param>
        /// <returns>
        /// Коллекция событий, связанная с этими сообщениями
        /// </returns>
        public IEnumerable<BeaconEventParseResult> ParseMessages(string[] messages)
        {
            foreach (var message in messages)
            {
                int beaconId;
                decimal longtitude;
                decimal latitude;
                var messageParts = message.Split(';');
                if (messageParts.Length != 4)
                {
                    yield return new BeaconEventParseResult
                    {
                        Error = string.Format(Properties.Resources.EventShouldContainFourParts, message),
                        Event = null
                    };
                    continue;
                }
                if (!int.TryParse(messageParts[0], out beaconId))
                {
                    yield return new BeaconEventParseResult
                    {
                        Error = string.Format(Properties.Resources.InvalidBeaconId, messageParts[0]),
                        Event = null
                    };
                    continue;
                }
                Beacon beacon = _beaconRepository.GetById(beaconId);
                if (beacon == null)
                {
                    yield return new BeaconEventParseResult
                    {
                        Error = string.Format(Properties.Resources.BeaconNotFoundMessage, messageParts[0]),
                        Event = null
                    };
                    continue;
                }
                if (!decimal.TryParse(messageParts[1], out longtitude))
                {
                    yield return new BeaconEventParseResult
                    {
                        Error = string.Format(Properties.Resources.InvalidLongtitudeId, messageParts[1]),
                        Event = null
                    };
                    continue;
                }
                if (!decimal.TryParse(messageParts[2], out latitude))
                {
                    yield return new BeaconEventParseResult
                    {
                        Error = string.Format(Properties.Resources.InvalidLatitudeId, messageParts[2]),
                        Event = null
                    };
                    continue;
                }
                string description = messageParts[3];
                var beaconEvent = new Event
                {
                    Beacon = beacon,
                    Latitude = latitude,
                    Longtitude = longtitude,
                    Description = description
                };
                yield return new BeaconEventParseResult { Event = beaconEvent };
            }
        }
    }
}
