using Microsoft.Maui.Hosting;

namespace MovecoinApp
{
    public static class Program
    {
        // Entry point for the application
        [STAThread]
        public static void Main(string[] args)
        {
            var builder = MauiApp.CreateBuilder();
            var app = MauiProgram.CreateMauiApp();
            // The Run() method doesn't exist, we simply need to create the app
        }
    }
}