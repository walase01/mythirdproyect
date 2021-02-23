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

        public MainViewModels()
        {
            LoginCommand = new Command(StartLogin);
        }


        private void StartLogin()
        {
            if (!string.IsNullOrEmpty(Name.ToString()) || (!String.IsNullOrEmpty(Password.ToString())))
            {

            }
        }
    }
}
