using System.ComponentModel;
using System.Runtime.CompilerServices;
using DemoX.Annotations;

namespace DemoX
{
    class LoginViewModel : INotifyPropertyChanged
    {
        public const string UsernameProperty = "Username";
        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }

        public const string PasswordProperty = "Password";
        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public bool ValidateCredentials()
        {
            if (Password == "" || Username == "") return false;
            Username = "Username set from VM";
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
