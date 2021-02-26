using App1xamarinforms.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1xamarinforms.ViewModels
{

    public class RegsiterVewModels
    {
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
        public string ConfirmPassword { get; set; } = "";
        public ICommand LoginCommand { get; }

        private InterfaceAlertServices interfaceAlert;

        public RegsiterVewModels(InterfaceAlertServices alertServices)
        {
            interfaceAlert = alertServices;
            LoginCommand = new Command(ComfirmEmpty);
        }

        async private void ComfirmEmpty()
        {
            if(!string.IsNullOrEmpty(Name) || !string.IsNullOrEmpty(Email) || !string.IsNullOrEmpty(Password) || !string.IsNullOrEmpty(Password) || !string.IsNullOrEmpty(ConfirmPassword))
            {
                if (string.Equals(Password, ConfirmPassword))
                {
                    await interfaceAlert.AlertEmpyRegister(Name);
                    await interfaceAlert.NavegationHome();
                }
                else
                {
                    await interfaceAlert.AlertPassword();
                }
            }
            else
            {
                await interfaceAlert.AlartEmpty();
            }
        }

    }
}
