using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace MovecoinApp.src.ViewModels
{
    public class CreateChallengeViewModel : INotifyPropertyChanged
    {
        private string _challengeName;
        private ObservableCollection<string> _selectedMetrics;
        private double _stakes;
        private double _margin;
        private TimeSpan _duration;
        private ICommand _createChallengeCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        public string ChallengeName
        {
            get => _challengeName;
            set
            {
                _challengeName = value;
                OnPropertyChanged(nameof(ChallengeName));
            }
        }

        public ObservableCollection<string> SelectedMetrics
        {
            get => _selectedMetrics;
            set
            {
                _selectedMetrics = value;
                OnPropertyChanged(nameof(SelectedMetrics));
            }
        }

        public double Stakes
        {
            get => _stakes;
            set
            {
                _stakes = value;
                OnPropertyChanged(nameof(Stakes));
            }
        }

        public double Margin
        {
            get => _margin;
            set
            {
                _margin = value;
                OnPropertyChanged(nameof(Margin));
            }
        }

        public TimeSpan Duration
        {
            get => _duration;
            set
            {
                _duration = value;
                OnPropertyChanged(nameof(Duration));
            }
        }

        public ICommand CreateChallengeCommand
        {
            get
            {
                return _createChallengeCommand ??= new Command(CreateChallenge);
            }
        }

        private void CreateChallenge()
        {
            // Logic to create a challenge
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}