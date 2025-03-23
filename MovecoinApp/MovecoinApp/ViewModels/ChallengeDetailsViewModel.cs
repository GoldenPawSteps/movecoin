using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using MovecoinApp.Models;
using MovecoinApp.Services;

namespace MovecoinApp.ViewModels
{
    public class ChallengeDetailsViewModel : BaseViewModel
    {
        private readonly ChallengeService _challengeService;
        private Challenge _challenge;

        public ChallengeDetailsViewModel(ChallengeService challengeService)
        {
            _challengeService = challengeService;
            JoinChallengeCommand = new Command(JoinChallenge);
        }

        public Challenge Challenge
        {
            get => _challenge;
            set => SetProperty(ref _challenge, value);
        }

        public ObservableCollection<ChallengeParticipant> Participants { get; } = new ObservableCollection<ChallengeParticipant>();

        public ICommand JoinChallengeCommand { get; }

        private void JoinChallenge()
        {
            // Logic to join the challenge
            // This would typically involve updating the challenge state and notifying participants
        }

        public void LoadChallenge(int challengeId)
        {
            Challenge = _challengeService.GetChallengeById(challengeId);
            Participants.Clear();
            foreach (var participant in Challenge.Participants)
            {
                Participants.Add(participant);
            }
        }
    }
}