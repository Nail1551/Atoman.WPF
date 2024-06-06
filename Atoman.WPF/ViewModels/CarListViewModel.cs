using Atoman.WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atoman.WPF.ViewModels
{
    public class CarListviewModel:BaseViewModel
    {
        public CarListviewModel()
        {
            CarModels = CarMockService.GetCars();
        }

        #region Properties 

        private List<CarModel> _carModels;
        public List<CarModel> CarModels
        {
            get { return _carModels; }
            set
            {
                _carModels = value;
                OnPropertyChanged();
            }
        }
        #endregion

    }
}
