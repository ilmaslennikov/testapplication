namespace DomainModel
{
    /// <summary>
    /// Событие
    /// </summary>
    public class Event
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

        /// <summary>
        /// Радиомаяк
        /// </summary>
        public Beacon Beacon { get; set; }
    }
}
