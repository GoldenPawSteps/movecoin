using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MovecoinApp.ViewModels
{
    public class ProfileViewModel : INotifyPropertyChanged
    {
        private string _username;
        private int _movecoinsBalance;

        public string Username
        {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged();
                }
            }
        }

        public int MovecoinsBalance
        {
            get => _movecoinsBalance;
            set
            {
                if (_movecoinsBalance != value)
                {
                    _movecoinsBalance = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        
        // Added missing method
        public void LoadUserProfile()
        {
            // In a real app, this would load from a service
            Username = "Demo User";
            MovecoinsBalance = 100;
        }
    }
}