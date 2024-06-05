using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Atoman.WPF.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel()
        {
            
        }
        


        public  bool CheckUserAuth()
        {
            if (UserLogin == "Nail" && UserPassword == "Major")
            {
               return true;
            }
            else
            {
               return false;
            }
        }

        #region Properties 

        private string _userLogin;
        public string UserLogin
        {
            get { return _userLogin; }
            set
            {
                _userLogin = value;
                OnPropertyChanged();
            }
        }

        private string _userPassword;
        public string UserPassword
        {
            get { return _userPassword; }
            set
            {
                _userPassword = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }
}
