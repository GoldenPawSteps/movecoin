using MovecoinApp.ViewModels;

namespace MovecoinApp.Views
{
    public partial class DashboardView : ContentPage
    {
        private DashboardViewModel _viewModel;

        public DashboardView()
        {
            InitializeComponent();
            _viewModel = new DashboardViewModel();
            BindingContext = _viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.LoadUserChallenges();
        }
    }
}