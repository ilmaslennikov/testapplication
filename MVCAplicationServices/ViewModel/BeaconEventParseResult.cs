using DomainModel;

namespace MVCAplicationServices.ViewModel
{
    /// <summary>
    /// Результат разбора события от радиомаяка
    /// </summary>
    public class BeaconEventParseResult
    {
        /// <summary>
        /// Событие, связанное с радиомаяком
        /// </summary>
        public Event Event { get; set; }

        /// <summary>
        /// Текст ошибки разбора
        /// </summary>
        public string Error { get; set; }
    }
}
