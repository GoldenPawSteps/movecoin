using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace MovecoinApp.ViewModels
{
    public class ChallengeCreationViewModel : BaseViewModel
    {
        private string _challengeName;
        private ObservableCollection<string> _selectedMetrics;
        private double _fixedStake;
        private double _minStake;
        private double _maxStake;
        private double _organizerProfitMargin;
        private int _challengeDuration;
        private DateTime _startDate;
        private DateTime _endDate;

        public string ChallengeName
        {
            get => _challengeName;
            set => SetProperty(ref _challengeName, value);
        }

        public ObservableCollection<string> SelectedMetrics
        {
            get => _selectedMetrics;
            set => SetProperty(ref _selectedMetrics, value);
        }

        public double FixedStake
        {
            get => _fixedStake;
            set => SetProperty(ref _fixedStake, value);
        }

        public double MinStake
        {
            get => _minStake;
            set => SetProperty(ref _minStake, value);
        }

        public double MaxStake
        {
            get => _maxStake;
            set => SetProperty(ref _maxStake, value);
        }

        public double OrganizerProfitMargin
        {
            get => _organizerProfitMargin;
            set => SetProperty(ref _organizerProfitMargin, value);
        }

        public int ChallengeDuration
        {
            get => _challengeDuration;
            set => SetProperty(ref _challengeDuration, value);
        }

        public DateTime StartDate
        {
            get => _startDate;
            set => SetProperty(ref _startDate, value);
        }

        public DateTime EndDate
        {
            get => _endDate;
            set => SetProperty(ref _endDate, value);
        }

        public ICommand CreateChallengeCommand { get; }

        public ChallengeCreationViewModel()
        {
            SelectedMetrics = new ObservableCollection<string>();
            CreateChallengeCommand = new Command(CreateChallenge);
            StartDate = DateTime.Now;
            EndDate = DateTime.Now.AddDays(7);
        }

        private void CreateChallenge()
        {
            // Logic to create a challenge
        }
        
        // Add missing methods referenced in the view
        public void UpdateSelectedMetrics()
        {
            // Logic for handling metric selection changes
        }
        
        public void UpdateSelectedDuration()
        {
            // Logic for handling duration selection changes
            switch (ChallengeDuration)
            {
                case 0: // Day
                    EndDate = StartDate.AddDays(1);
                    break;
                case 1: // Weekend
                    EndDate = StartDate.AddDays(2);
                    break;
                case 2: // Week
                    EndDate = StartDate.AddDays(7);
                    break;
                case 3: // Month
                    EndDate = StartDate.AddMonths(1);
                    break;
            }
        }
        
        public void UpdateSelectedStakes()
        {
            // Logic for handling stakes selection changes
        }
        
        public void UpdateSelectedRewards()
        {
            // Logic for handling rewards selection changes
        }
    }
}