using System;
using Microsoft.Maui.Controls;
using MovecoinApp.ViewModels;

namespace MovecoinApp.Views
{
    public partial class ChallengeCreationPage : ContentPage
    {
        private ChallengeCreationViewModel viewModel;

        public ChallengeCreationPage()
        {
            InitializeComponent();
            viewModel = new ChallengeCreationViewModel();
            BindingContext = viewModel;
        }

        private void OnCreateChallengeClicked(object sender, EventArgs e)
        {
            // Logic to create a challenge using the ViewModel
            viewModel.CreateChallengeCommand.Execute(null);
        }

        private void OnSelectMetricsChanged(object sender, EventArgs e)
        {
            // Logic to handle metric selection changes
            viewModel.UpdateSelectedMetrics();
        }

        private void OnDurationChanged(object sender, EventArgs e)
        {
            // Logic to handle duration selection changes
            viewModel.UpdateSelectedDuration();
        }

        private void OnStakesChanged(object sender, EventArgs e)
        {
            // Logic to handle stakes selection changes
            viewModel.UpdateSelectedStakes();
        }

        private void OnRewardsChanged(object sender, EventArgs e)
        {
            // Logic to handle rewards selection changes
            viewModel.UpdateSelectedRewards();
        }
    }
}