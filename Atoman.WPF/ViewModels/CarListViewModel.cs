using Atoman.WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Atoman.WPF.ViewModels
{
    public class CarListviewModel:BaseViewModel
    {
        public CarListviewModel()
        {
            CarList = CarMockService.GetCars();
            CarModelsGrid = new ObservableCollection<CarModel>(CarMockService.GetCars().Take(3));
        }


        #region Properties 

        private List<CarModel> _carList;
        public List<CarModel> CarList;

        private ObservableCollection<CarModel> _carModelsGrid;
        public ObservableCollection<CarModel> CarModelsGrid
        {
            get { return _carModelsGrid; }
            set
            {
                _carModelsGrid = value;
                OnPropertyChanged();
            }
        }
        private string _searchBox;
        public string SearchBox
        {
            get { return _searchBox; }
            set
            {
                _searchBox = value;
                OnPropertyChanged();
            }
        }

        #endregion


    }
}
