using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atoman.WPF.Models
{
    public class Acts
    {
        
        public int ActId { get; set; }
        
        public int CarID { get; set; }

        public string ActDate { get; set; }
      
        public string NameSdch { get; set; }

        public string NamePriem { get; set; }
        


    }

    public static class ActMockService
    {
        public static List<Acts> GetAct()
        {
            return new List<Acts>()
            {
                new Acts
                {
                    ActId = 1,
                    CarID = 1,
                    ActDate = "21.10.2024",
                    NameSdch="Фомин Николай",
                    NamePriem="Меньков Андрей"

                },
                new Acts
                {
                    ActId = 2,
                    CarID = 2,
                    ActDate = "14.04.2024",
                    NameSdch="Фомин Николай",
                    NamePriem="Кугушев Наиль"

                },
                new Acts
                {
                    ActId = 3,
                    CarID = 3,
                    ActDate = "04.10.2022",
                    NameSdch="Куликов Михаил",
                    NamePriem="Рубцов Никита"

                },
                new Acts
                {
                    ActId = 4,
                    CarID = 4,
                    ActDate = "21.12.2024",
                    NameSdch="Наумов Николай",
                    NamePriem="Иванов Иван"

                },
            };
        }
    }
}
        
