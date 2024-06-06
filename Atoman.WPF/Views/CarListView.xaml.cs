using Atoman.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
