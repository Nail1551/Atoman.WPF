﻿using Atoman.WPF.ViewModels;
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
using System.Windows.Shapes;

namespace Atoman.WPF.Views
{
    /// <summary>
    /// Логика взаимодействия для LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        private LoginViewModel _loginviewModel { get; set; }
        public LoginView()
        {
            InitializeComponent();
            _loginviewModel = new LoginViewModel();
            this.DataContext = _loginviewModel;

            // Подписываемся на событие
            _loginviewModel.CheckUserAuthResultEvent += _loginviewModel_CheckUserAuthEvent;
        }

        /// <summary>
        /// Вызывается при обработке события
        /// </summary>
        /// <param name="result"></param>
        private void _loginviewModel_CheckUserAuthEvent(bool result)
        {
            if (result)
            {
                MessageBox.Show("Вход выполнен успешно!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль. Попробуйте снова.");
            }
        }
       


        //private void LoginButton_Click(object sender, RoutedEventArgs e)
        //{
        //    bool result=_loginviewModel.CheckUserAuth();

        //    if (result = true)
        //    {
        //        MessageBox.Show("Вход выполнен успешно!");

        //        this.Close();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Неверный логин или пароль. Попробуйте снова.");
        //    }
        //}
    }
}
