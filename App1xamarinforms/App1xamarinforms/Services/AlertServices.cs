using App1xamarinforms.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App1xamarinforms.Services
{
    public class AlertServices : InterfaceAlertServices
    {
        public Task AlartEmpty()
        {
            return App.Current.MainPage.DisplayAlert("Error","Los campos esan vacios","Ok");
        }

        public Task AlertAsync(string name)
        {
            return App.Current.MainPage.DisplayAlert("Bienvenido",$"Hola {name}","Ok");
        }

        public Task AlertEmpyRegister(string name)
        {
            return App.Current.MainPage.DisplayAlert("Bienvenido",$"Hola {name}","Ok");
        }

        public Task AlertPassword()
        {
            return App.Current.MainPage.DisplayAlert("Error","Las contraseñas no coinciden","Ok");
        }

        public Task ConfirmEmpty()
        {
            return App.Current.MainPage.DisplayAlert("Error","Los compos estan vacios","Ok");
        }

        public Task NavegationRegister()
        {
            return App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
        }
    }
}
