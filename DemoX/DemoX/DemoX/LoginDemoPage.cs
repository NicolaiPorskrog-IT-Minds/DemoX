using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Serialization;
using Xamarin.Forms;

namespace DemoX
{
    public class LoginDemoPage : ContentPage
    {
        private LoginViewModel _viewModel;
        public LoginDemoPage()
        {
            _viewModel = new LoginViewModel();
            BindingContext = _viewModel;

            Title = "Xamarin Demo";
            Padding = new Thickness(left: 10, top: 0, right: 10, bottom: 0);
            Content = Stack();
        }

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
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            var usernameEntry = new Entry
            {
                Placeholder = "Username",
                HorizontalOptions = LayoutOptions.Fill,
            };
            usernameEntry.SetBinding(Entry.TextProperty, LoginViewModel.UsernameProperty, BindingMode.TwoWay);

            var passwordEntry = new Entry
            {
                Placeholder = "Password",
                IsPassword = true,
                HorizontalOptions = LayoutOptions.Fill,
            };
            passwordEntry.SetBinding(Entry.TextProperty, LoginViewModel.PasswordProperty);

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

            loginButton.Clicked += (sender, args) =>
            {
                if (_viewModel.ValidateCredentials())
                {
                    DisplayAlert("Credential Validated", "Credentials Validated", "OK");
                    return;
                }
                DisplayAlert("Credential Not Validated", "Credentials Not Validated", "OK");
            };

            var navigationButton = new Button
            {
                HorizontalOptions = LayoutOptions.Fill,
                Text = "Push Navigation"
            };

            Device.OnPlatform(() =>
            {
                navigationButton.TextColor = Color.White;
                navigationButton.BackgroundColor = Color.Black;
            });

            navigationButton.Clicked += (sender, args) =>
            {
                Navigation.PushAsync(new MainPage());
            };

            var navigationModalButton = new Button
            {
                HorizontalOptions = LayoutOptions.Fill,
                Text = "Push Modal"
            };

            Device.OnPlatform(() =>
            {
                navigationModalButton.TextColor = Color.White;
                navigationModalButton.BackgroundColor = Color.Black;
            });

            navigationModalButton.Clicked += (sender, args) =>
            {
                Navigation.PushModalAsync(new MainModalPage());
            };

            layout.Children.Add(label);
            layout.Children.Add(usernameEntry);
            layout.Children.Add(passwordEntry);
            layout.Children.Add(loginButton);
            layout.Children.Add(navigationModalButton);
            layout.Children.Add(navigationButton);

            return layout;
        }
    }
}
