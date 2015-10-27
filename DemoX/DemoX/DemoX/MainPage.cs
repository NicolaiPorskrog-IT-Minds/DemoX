using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace DemoX
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            var button = new Button { Text = "Back" };
            button.Clicked += (sender, args) =>
            {
                Navigation.PopAsync();
            };

            Content = new StackLayout
            {
                Children = { button }
            };
        }
    }
}
