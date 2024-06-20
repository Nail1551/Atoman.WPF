using Atoman.WPF.Models;
using Atoman.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Atoman.WPF.Views
{
    /// <summary>
    /// Логика взаимодействия для CarsView.xaml
    /// </summary>
    public partial class CarListView : Page
    {
        public CarListviewModel _viewModel { get; set; }
        public CarListView()
        {
            InitializeComponent();
            _viewModel = new CarListviewModel();
            this.DataContext = _viewModel;
          
        }
        public void ConvertLicensePlate(string input)
        {
            // Словарь для замены русских букв на английские
            var replaceChars = new Dictionary<char, char>
            {
                {'А', 'A'}, {'В', 'B'}, {'Е', 'E'}, {'К', 'K'}, {'М', 'M'}, {'Н', 'H'},
                {'О', 'O'}, {'Р', 'P'}, {'С', 'C'}, {'Т', 'T'}, {'У', 'Y'}, {'Х', 'X'}
               };

            // Преобразование текста в верхний регистр и замена русских букв на английские
            var SearchPlate = input.ToUpper();
            SearchPlate = Regex.Replace(SearchPlate, "[АВЕКМНОРСТУХ]", m => replaceChars[m.Value[0]].ToString());

            SearchBox.Text = SearchPlate;
        }

        private void CarGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            _viewModel.FilterAct();
            ActsGrid.ItemsSource = _viewModel.FilterActs;
        }
    }
}
