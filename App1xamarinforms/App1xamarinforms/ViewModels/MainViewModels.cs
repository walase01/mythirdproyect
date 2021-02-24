using App1xamarinforms.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1xamarinforms.ViewModels
{
    public class MainViewModels
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public ICommand LoginCommand { get; }

        private InterfaceAlertServices AlertServices;

        public MainViewModels(InterfaceAlertServices alertServices)
        {
            LoginCommand = new Command(StartLogin);
            AlertServices = alertServices;
        }
   
        async private void StartLogin()
        {
            if (!string.IsNullOrEmpty(Name.ToString()) || (!String.IsNullOrEmpty(Password.ToString())))
            {
               await AlertServices.AlertAsync(Name.ToString());
            }
        }
    }
}
