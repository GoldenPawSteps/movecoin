using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MovecoinApp.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        private ObservableCollection<Challenge> _userChallenges;
        private User _currentUser;

        public ObservableCollection<Challenge> UserChallenges
        {
            get => _userChallenges;
            set => SetProperty(ref _userChallenges, value);
        }

        public User CurrentUser
        {
            get => _currentUser;
            set => SetProperty(ref _currentUser, value);
        }

        public ICommand RefreshChallengesCommand { get; }

        public DashboardViewModel()
        {
            UserChallenges = new ObservableCollection<Challenge>();
            RefreshChallengesCommand = new Command(RefreshChallenges);
        }

        private void RefreshChallenges()
        {
            // Logic to refresh user challenges
        }
    }
}