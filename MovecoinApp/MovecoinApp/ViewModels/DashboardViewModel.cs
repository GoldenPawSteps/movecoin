using System.Collections.ObjectModel;
using System.Windows.Input;
using MovecoinApp.Models;
using MovecoinApp.Services;

namespace MovecoinApp.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        private readonly ChallengeService _challengeService;
        private readonly AuthService _authService;

        public ObservableCollection<Challenge> Challenges { get; set; }
        public User CurrentUser { get; set; }

        public ICommand JoinChallengeCommand { get; }
        public ICommand CreateChallengeCommand { get; }

        public DashboardViewModel(ChallengeService challengeService, AuthService authService)
        {
            _challengeService = challengeService;
            _authService = authService;

            Challenges = new ObservableCollection<Challenge>();
            CurrentUser = _authService.GetCurrentUser();

            JoinChallengeCommand = new Command<Challenge>(JoinChallenge);
            CreateChallengeCommand = new Command(CreateChallenge);
        }

        public void LoadChallenges()
        {
            Challenges.Clear();
            var challenges = _challengeService.GetChallenges();
            foreach (var challenge in challenges)
            {
                Challenges.Add(challenge);
            }
        }

        private void JoinChallenge(Challenge challenge)
        {
            if (challenge != null)
            {
                // Fix the JoinChallenge call to match the method signature
                _challengeService.JoinChallenge(challenge.Name, CurrentUser, 10.0m); // Default stake amount
            }
        }

        private void CreateChallenge()
        {
            // Logic to navigate to the challenge creation page
        }
    }
}