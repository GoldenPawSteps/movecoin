using Microsoft.Maui.Controls;

namespace MovecoinApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}