using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atoman.WPF.Models
{
    public class CarTypeModel
    {
        /// <summary>
        /// Идентификатор модели автомобиля
        /// </summary>
        public Guid CarTypeId { get; set; }
        /// <summary>
        /// Наименование модели автомобиля
        /// </summary>
        public string CarTypeName { get; set; }
        /// <summary>
        /// Идентификатор шаблона чек-листа
        /// </summary>
        public int? InspectionPatternId { get; set; }
    }
}
