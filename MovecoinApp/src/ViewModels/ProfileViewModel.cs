using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MovecoinApp.ViewModels
{
    public class ProfileViewModel : INotifyPropertyChanged
    {
        private string _name;
        private string _email;
        private int _totalChallenges;
        private int _completedChallenges;

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged();
                }
            }
        }

        public int TotalChallenges
        {
            get => _totalChallenges;
            set
            {
                if (_totalChallenges != value)
                {
                    _totalChallenges = value;
                    OnPropertyChanged();
                }
            }
        }

        public int CompletedChallenges
        {
            get => _completedChallenges;
            set
            {
                if (_completedChallenges != value)
                {
                    _completedChallenges = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void UpdateProfile(string name, string email)
        {
            Name = name;
            Email = email;
            // Additional logic to save the updated profile can be added here
        }
    }
}