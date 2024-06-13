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
                    ActDate = "21.10.2024",
                    NameSdch="Фомин Николай",
                    NamePriem="Меньков Андрей"

                },
            };
        }
    }
}
        
