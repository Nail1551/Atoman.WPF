using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atoman.WPF.Models
{
    public class CarModel
    {
        /// <summary>
        /// Идентификатор автомобиля
        /// </summary>
        public int CarId { get; set; }
        /// <summary>
        /// Марка автомобиля
        /// </summary>
        public CarTypeModel CarTypeModel { get; set; }
        /// <summary>
        /// Пробег автомобиля
        /// </summary>
        public int CarMileage { get; set; }
        /// <summary>
        /// Гос.номер автомобиля
        /// </summary>
        public string CarNumber { get; set; }
        /// <summary>
        /// Штрих-код автомобиля
        /// </summary>
        public string CarBarCode { get; set; }

    }

    public static class CarMockService
    {
        public static List<CarModel> GetCars()
        {
            return new List<CarModel>()
            {
                new CarModel
                {
                        CarId = 1,
                        CarBarCode = string.Empty,
                        CarMileage = 0,
                        CarNumber = "T538OO790",
                        CarTypeModel = new CarTypeModel
                        {
                            CarTypeId = Guid.NewGuid(),
                            CarTypeName = "Porche Cayene",
                            InspectionPatternId = 1
                        }
                },
                new CarModel
                {
                        CarId = 2,
                        CarBarCode = string.Empty,
                        CarMileage = 0,
                        CarNumber = "K753AM790",
                        CarTypeModel = new CarTypeModel
                        {
                            CarTypeId = Guid.NewGuid(),
                            CarTypeName = "Гелик",
                            InspectionPatternId = 2
                        }
                },
                new CarModel
                {
                        CarId = 3,
                        CarBarCode = string.Empty,
                        CarMileage = 0,
                        CarNumber = "E753BK790",
                        CarTypeModel = new CarTypeModel
                        {
                            CarTypeId = Guid.NewGuid(),
                            CarTypeName = "нЕГелик",
                            InspectionPatternId = 3
                        }
                },
                new CarModel
                {
                        CarId = 4,
                        CarBarCode = string.Empty,
                        CarMileage = 0,
                        CarNumber = "K233AA790",
                        CarTypeModel = new CarTypeModel
                        {
                            CarTypeId = Guid.NewGuid(),
                            CarTypeName = "Гелик",
                            InspectionPatternId = 4
                        }
                }

            };
        }
    }


}
