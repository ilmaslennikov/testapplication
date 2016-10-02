using System.Runtime.Serialization;

namespace SelfHostedServiceApplication
{
    [DataContract]
    public class ExternEvent
    {
        /// <summary>
        /// Широта
        /// </summary>
        public decimal Latitude { get; set; }

        /// <summary>
        /// Долгота
        /// </summary>
        public decimal Longtitude { get; set; }

        /// <summary>
        /// Описание события
        /// </summary>
        public string Description { get; set; }

    }
}