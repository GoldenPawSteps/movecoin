using MovecoinApp.ViewModels;

namespace MovecoinApp.Views
{
    public partial class ChallengeDetailsPage : ContentPage
    {
        public ChallengeDetailsPage(ChallengeDetailsViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            // Load challenge details or any necessary data here
        }

        private void OnJoinChallengeClicked(object sender, EventArgs e)
        {
            // Logic to join the challenge
        }

        private void OnLeaveChallengeClicked(object sender, EventArgs e)
        {
            // Logic to leave the challenge
        }
    }
}