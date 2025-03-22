using MovecoinApp.ViewModels;

namespace MovecoinApp.Views
{
    public partial class ProfileView : ContentPage
    {
        public ProfileView()
        {
            InitializeComponent();
            BindingContext = new ProfileViewModel();
        }
    }
}