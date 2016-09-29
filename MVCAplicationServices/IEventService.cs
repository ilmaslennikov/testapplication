using System.Collections.Generic;
using MVCAplicationServices.ViewModel;

namespace MVCAplicationServices
{
    public interface IEventService
    {
        IEnumerable<BeaconEventParseResult> ParseMessages(string[] messages);
    }
}
