using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace DemoX
{
    public class MainModalPage : ContentPage
    {
        public MainModalPage()
        {
            var button = new Button { Text = "Back" };
            button.Clicked += (sender, args) =>
            {
                Navigation.PopModalAsync();
            };

            Content = new StackLayout
            {
                Children = {  button }
            };
        }
    }
}
