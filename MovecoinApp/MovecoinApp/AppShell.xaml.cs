using System;
using Microsoft.Maui.Controls;
using MovecoinApp.Views;

namespace MovecoinApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            // Register routes for navigation
            Routing.RegisterRoute(nameof(ChallengeCreationPage), typeof(ChallengeCreationPage));
            Routing.RegisterRoute(nameof(ChallengeDetailsPage), typeof(ChallengeDetailsPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
        }
    }
}