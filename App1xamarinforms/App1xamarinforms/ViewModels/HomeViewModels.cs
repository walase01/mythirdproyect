using App1xamarinforms.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1xamarinforms.ViewModels
{
    public class HomeViewModels
    {
        public MenuOption  BarAndHotelsMenuOption { get; set; } = new MenuOption();
        public MenuOption FineDining { get; set; } = new MenuOption();

        public MenuOption Cafes { get; set; } = new MenuOption();

        public MenuOption Nearby { get; set; } = new MenuOption();

        public MenuOption FastFood { get; set; } = new MenuOption();

        public MenuOption FeaturedFoods { get; set; } = new MenuOption();
        public HomeViewModels()
        {
            BarAndHotelsMenuOption.Title = "Bar and Hotels";
            BarAndHotelsMenuOption.Image = "beer";

            FineDining.Title = "Fine Dining";
            FineDining.Image = "serving";

            Cafes.Title = "Cafes";
            Cafes.Image = "cafe";

            Nearby.Title = "Nearby";
            Nearby.Image = "nearby";

            FastFood.Title = "Fast Food";
            FastFood.Image = "fastfood";

            FeaturedFoods.Image = "pizzaslice";
            FeaturedFoods.Title = "Feactured Foods";
        }
    }
}
