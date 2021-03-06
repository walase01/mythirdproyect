﻿using App1xamarinforms.Services;
using App1xamarinforms.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1xamarinforms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginTabbedPage : TabbedPage
    {
        public LoginTabbedPage()
        {
            InitializeComponent();
            this.BindingContext = new MainViewModels(new AlertServices());
        }
    }
}