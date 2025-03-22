using System;
using Xamarin.Forms;
using MovecoinApp.ViewModels;

namespace MovecoinApp.Views
{
    public partial class CreateChallengeView : ContentPage
    {
        private CreateChallengeViewModel viewModel;

        public CreateChallengeView()
        {
            InitializeComponent();
            viewModel = new CreateChallengeViewModel();
            BindingContext = viewModel;
        }

        private void OnCreateChallengeClicked(object sender, EventArgs e)
        {
            if (viewModel.ValidateChallenge())
            {
                viewModel.SubmitChallenge();
                DisplayAlert("Success", "Challenge created successfully!", "OK");
            }
            else
            {
                DisplayAlert("Error", "Please fill in all required fields.", "OK");
            }
        }
    }
}