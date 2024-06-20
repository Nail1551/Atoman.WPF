using Atoman.WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Atoman.WPF.ViewModels
{
    public class CarListviewModel:BaseViewModel
    {
        public CarListviewModel()
        {
            CarList = CarMockService.GetCars();
            CarModelsGrid = new ObservableCollection<CarModel>(CarMockService.GetCars());
            ActList = ActMockService.GetAct();
            FilterActs= new ObservableCollection<Acts>(ActMockService.GetAct());
        }


        #region Properties 

        private CarModel _selectedcar;
        public CarModel SelectedCar
        {
            get { return _selectedcar; }
            set
            {
                _selectedcar = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Acts> _filterActs;
        public ObservableCollection<Acts> FilterActs
        {
            get { return _filterActs; }
            set
            {
                _filterActs = value;
                OnPropertyChanged();
            }
        }


        private List<CarModel> _carList;
        public List<CarModel> CarList;

        private List<Acts> _actList;
        public List<Acts> ActList;
       


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

       

        private string _searchPlate;
        public string SearchPlate
        {
            get { return _searchPlate; }
            set
            {
                if (value != null)
                    value = ConvertLicensePlate(value);
                _searchPlate = value;
         
                OnPropertyChanged();
                
            }
        }

        #endregion


        public string ConvertLicensePlate(string searchText)
        {
            // Словарь для замены русских букв на английские
            var replaceChars = new Dictionary<char, char>
            {
                {'А', 'A'}, {'В', 'B'}, {'Е', 'E'}, {'К', 'K'}, {'М', 'M'}, {'Н', 'H'},
                {'О', 'O'}, {'Р', 'P'}, {'С', 'C'}, {'Т', 'T'}, {'У', 'Y'}, {'Х', 'X'}
               };

            // Преобразование текста в верхний регистр и замена русских букв на английские
            var result = searchText.ToUpper();
            return Regex.Replace(result, "[АВЕКМНОРСТУХ]", m => replaceChars[m.Value[0]].ToString());
            

            
        }

        public void FilterCar()
        {
   
            CarModelsGrid.Clear();
            var filteredCars = CarList.Where(car => car.CarNumber.Contains(SearchPlate)).ToList();
   
            if (Regex.IsMatch(SearchPlate, @"^[ABEKMHOPCTYX0-9]+$"))
            {
                if (filteredCars.Any())
                {
                    CarModelsGrid = new ObservableCollection<CarModel>(filteredCars);
                }
                else
                {
                    // Выводим сообщение о том, что ничего не найдено
                    MessageBox.Show("По вашему запросу ничего не найдено. Попробуйте изменить критерии поиска и попробовать снова.");
                }
            }
            else
            {
                // Выводим сообщение об ошибке
                MessageBox.Show("Введите корректные данные. Допустимые символы для поиска: A, B, E, K, M, H, O, P, C, T, Y, X и цифры.");
                // Очищаем поле поиска
                SearchPlate = string.Empty;
            }
        }
        public void FilterAct()
        {

            FilterActs.Clear();
            if (SelectedCar != null)
            {
                
                int selectedCarId = Convert.ToInt32(SelectedCar.CarId);
                var filteredActs = ActList.Where(act => act.CarID == selectedCarId);
                if (filteredActs.Any())
                {
                    FilterActs = new ObservableCollection<Acts>(filteredActs);
                }
            }
            
              

        }

    #region Commands 

    public RelayCommand SearchCommand => new RelayCommand(a => FilterCar());

        #endregion
    }
}
