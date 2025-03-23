using System;
using Microsoft.Maui.Controls;
using MovecoinApp.Models;
using MovecoinApp.Services;
using MovecoinApp.ViewModels;

namespace MovecoinApp.Views
{
    public partial class DashboardPage : ContentPage
    {
        private DashboardViewModel viewModel;

        public DashboardPage()
        {
            InitializeComponent();
            // Create service instances directly since DI isn't working properly
            var authService = new AuthService();
            var challengeService = new ChallengeService();
            viewModel = new DashboardViewModel(challengeService, authService);
            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            // Use a different command or method for loading challenges
            viewModel.LoadChallenges();
        }

        private async void OnCreateChallengeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChallengeCreationPage());
        }

        private async void OnChallengeSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Models.Challenge selectedChallenge)
            {
                // Create a proper ViewModel instance for the details page
                var challengeService = new ChallengeService();
                var viewModel = new ChallengeDetailsViewModel(challengeService);
                viewModel.Challenge = selectedChallenge;
                await Navigation.PushAsync(new ChallengeDetailsPage(viewModel));
            }
        }
    }
}