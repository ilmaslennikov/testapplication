using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostedServiceApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SampleService" in both code and config file together.
    public class SampleService : ISampleService
    {
        public async Task<ExternEvent> GetExternEvent()
        {
            await Task.Delay(1000);
            return new ExternEvent
            {
                Description = "Тетовое событие",
                Longtitude = 0,
                Latitude = 0
            };
        }
    }
}
