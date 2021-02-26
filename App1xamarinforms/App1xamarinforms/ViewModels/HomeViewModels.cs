using App1xamarinforms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1xamarinforms.ViewModels
{
    public class HomeViewModels
    {
        public MenuOption  BarAndHotelsMenuOption { get; set; } = new MenuOption();
        public HomeViewModels()
        {
            BarAndHotelsMenuOption.Title = "Bar and Hotels";
            BarAndHotelsMenuOption.Image = "beer";
        }
    }
}
