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
        

        /// <summary>
        /// Проверка пользователя
        /// </summary>
        public void CheckUserAuth()
        {
            if (UserLogin == "Nail" && UserPassword == "Major")
            {
                // Вызываем событие с результатом проверки
                CheckUserAuthResultEvent?.Invoke(true);
            }
            else
            {
                CheckUserAuthResultEvent?.Invoke(false);
            }
        }


        private void UpdateBtnLoginState()
        {
            
            IsBtnLoginClickable = !string.IsNullOrEmpty(UserLogin) && !string.IsNullOrEmpty(Convert.ToString(UserPassword));
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
                UpdateBtnLoginState();
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
                UpdateBtnLoginState();
            }
        }

        private bool _isBtnLoginClickable = false;
        public bool IsBtnLoginClickable
        {
            get { return _isBtnLoginClickable; }
            set
            {
                _isBtnLoginClickable = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Commands 

        public RelayCommand AuthCommand => new RelayCommand(a => CheckUserAuth(), can => IsBtnLoginClickable);

        #endregion

        #region Events 

        public event Action<bool> CheckUserAuthResultEvent; // Событие - результат проверки

        #endregion
    }
}
