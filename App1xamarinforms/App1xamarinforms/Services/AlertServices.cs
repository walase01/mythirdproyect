using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App1xamarinforms.Services
{
    public class AlertServices : InterfaceAlertServices
    {
        public Task AlertAsync(string name)
        {
            return App.Current.MainPage.DisplayAlert("Bienvenido",$"Hola {name}","Ok");
            
        }
    }
}
