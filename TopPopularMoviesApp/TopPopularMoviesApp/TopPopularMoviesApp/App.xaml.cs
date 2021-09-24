using System;
using TopPopularMoviesApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TopPopularMoviesApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MoviePage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        } 
    }
}
