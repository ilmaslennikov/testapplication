using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModel
{
    /// <summary>
    /// Элемент навигационного меню
    /// </summary>
    public class MenuItem
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Текст ссылки
        /// </summary>
        public string LinkText { get; set; }

        /// <summary>
        /// Имя действия
        /// </summary>
        public string ActionName { get; set; }

        /// <summary>
        /// Имя контроллера
        /// </summary>
        public string ControllerName { get; set; }

        /// <summary>
        /// Родительский пункт меню
        /// </summary>
        public int? ParentMenuItemId { get; set; }

        /// <summary>
        /// Дочерние элементы меню
        /// </summary>
        [ForeignKey("ParentMenuItemId")]
        public List<MenuItem> Items { get; set; }
    }
}