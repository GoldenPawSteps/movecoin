using System;
using Microsoft.Maui.Controls;
using MovecoinApp.ViewModels;

namespace MovecoinApp.Views
{
    public partial class ChallengeView : ContentPage
    {
        private ChallengeViewModel _viewModel;

        public ChallengeView()
        {
            InitializeComponent();
            _viewModel = new ChallengeViewModel();
            BindingContext = _viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.LoadChallengeDetails();
        }

        private void OnJoinChallengeClicked(object sender, EventArgs e)
        {
            _viewModel.JoinChallenge();
        }

        private void OnLeaveChallengeClicked(object sender, EventArgs e)
        {
            _viewModel.LeaveChallenge();
        }
    }
}