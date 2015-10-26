using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace DemoX
{
    public class LoginDemoPage : ContentPage
    {
        /// <summary>
        /// The page constructor
        /// </summary>
        public LoginDemoPage()
        {
            Title = "Xamarin Demo";
            Padding = new Thickness(left: 10, top: 0, right: 10, bottom: 0);
            Content = Stack();
        }

        /// <summary>
        /// Builds the main layout
        /// </summary>
        /// <returns>The main stacklayout</returns>
        private StackLayout Stack()
        {
            var layout = new StackLayout
            {
                Padding = new Thickness(left: 0, top: 25, right: 0, bottom: 0),
                Spacing = 25
            };

            var label = new Label
            {
                Text = "Login",
                HorizontalOptions = LayoutOptions.Center,
                TextColor = Color.Black,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof (Label))
            };

            var usernameEntry = new Entry
            {
                Placeholder = "Username",
                HorizontalOptions = LayoutOptions.Fill,
            };

            var passwordEntry = new Entry
            {
                Placeholder = "Password",
                HorizontalOptions = LayoutOptions.Fill,
            };

            var loginButton = new Button
            {
                HorizontalOptions = LayoutOptions.Fill,
                Text = "Login"
            };

            //On iOS
            Device.OnPlatform(() =>
            {
                loginButton.TextColor = Color.White;
                loginButton.BackgroundColor = Color.Black;
            });

            loginButton.Clicked += (sender, args) => {
                DisplayAlert("Button clicked", "You clicked the button", "OK");
            };

            layout.Children.Add(label);
            layout.Children.Add(usernameEntry);
            layout.Children.Add(passwordEntry);
            layout.Children.Add(loginButton);

            return layout;
        }
    }
}
