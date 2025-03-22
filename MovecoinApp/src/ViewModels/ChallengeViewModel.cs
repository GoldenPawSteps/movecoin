using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MovecoinApp.Models;

namespace MovecoinApp.ViewModels
{
    public class ChallengeViewModel : INotifyPropertyChanged
    {
        private Challenge _challenge;

        public Challenge Challenge
        {
            get => _challenge;
            set
            {
                _challenge = value;
                OnPropertyChanged();
            }
        }

        public ChallengeViewModel(Challenge challenge)
        {
            Challenge = challenge;
        }

        public void UpdateChallenge(Challenge updatedChallenge)
        {
            Challenge = updatedChallenge;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}