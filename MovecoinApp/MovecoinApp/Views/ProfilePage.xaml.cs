using System;
using Microsoft.Maui.Controls;
using MovecoinApp.ViewModels;

namespace MovecoinApp.Views
{
    public partial class ProfilePage : ContentPage
    {
        private ProfileViewModel _viewModel;

        public ProfilePage()
        {
            InitializeComponent();
            _viewModel = new ProfileViewModel();
            BindingContext = _viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.LoadUserProfile();
        }
    }
}