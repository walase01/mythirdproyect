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
        public string Name { get; set; } = null;

        public string Password { get; set; } = null;

        public ICommand RegisterCommand { get; } 

        public ICommand LoginCommand { get; }

        private InterfaceAlertServices AlertServices;
             

        public MainViewModels(InterfaceAlertServices alertServices)
        {
            LoginCommand = new Command(StartLogin);
            RegisterCommand = new Command(EnterRegister);
            AlertServices = alertServices;
        }
   
        async private void StartLogin()
        {
            if (!string.IsNullOrEmpty(Name.ToString()) || (!string.IsNullOrEmpty(Password.ToString())))
            {
               await AlertServices.AlertAsync(Name.ToString());
                await AlertServices.NavegationHome();
            }
            else
            {
                await AlertServices.AlartEmpty();
            }
        }

        async private void EnterRegister()
        {
            await AlertServices.NavegationRegister();
        }


    }
}
