using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModel
{
    /// <summary>
    /// Радиомаяк
    /// </summary>
    public class Beacon
    {
        /// <summary>
        /// Идентификатор радиомаяка
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Шестнадцатиричный идендификатор маяка
        /// </summary>
        [Required]
        [StringLength(30, MinimumLength = 30)]
        [RegularExpression(RegularExpressions.Hex)]
        [Index("IX_HexId_UQ", IsUnique = true)]
        [DisplayName("Шестнадцатиричный идендификатор маяка:")]
        public string HexId { get; set; }

        /// <summary>
        /// Модель радиомаяка
        /// </summary>
        [Required]
        [DisplayName("Модель радиомаяка:")]
        public string Model { get; set; }

        /// <summary>
        /// Серийный номер
        /// </summary>
        [Required]
        [DisplayName("Серийный номер:")]
        public string Serial { get; set; }

        /// <summary>
        /// Производитель
        /// </summary>
        [Required]
        [DisplayName("Производитель:")]
        public string Manufacturer { get; set; }
    }
}
