using Atoman.WPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Atoman.WPF.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        public MainViewModel()
        {
            LocalVariables.UserName = Environment.UserName;
            // tut 
            // if token
            if (LocalVariables.CurrentUserJwtToken == null)
            {
                var x = new LoginView();
                x.Show();
                x.Topmost = true;
            }
            // new login view
        }

        public void ChangeVersion()
        {
            AppVersion = "Test";
        }

        #region Properties 

        private string _appVersion = "0.0.1";
        public string AppVersion
        {
            get { return _appVersion; }
            set
            {
                _appVersion = value;
                OnPropertyChanged();
            }
        }

        private string _userName= Environment.UserName;
        public string Username
        { 
            get { return _userName; } 
            set {
                _userName = value;
                OnPropertyChanged();
                  } 
        }
        #endregion

        #region Commands 

        public RelayCommand MyCommand => new RelayCommand(a => ChangeVersion(), can => false);

        #endregion

    }
}
