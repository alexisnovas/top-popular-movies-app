using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using TopPopularMoviesApp.Models;
using TopPopularMoviesApp.Services;
using Xamarin.Essentials;

namespace TopPopularMoviesApp.ViewModels
{
    public class MovieViewModel : BaseViewModel
    {
        //public ObservableCollection<string> MovieTitle { get; set; } = new ObservableCollection<string>();
        //public ObservableCollection<string> MovieImage { get; set; } = new ObservableCollection<string>();
        public ObservableCollection<Movie> Movies { get; set; } = new ObservableCollection<Movie>();


        public MovieViewModel(IMovieApiService movieApiService)
        {
            _movieApiService = movieApiService;
            LoadMoviesAsync();
        }

        public async Task LoadMoviesAsync()
        {
            //var response = await RestService.For<IMovieApi>("https://imdb-api.com/").GetMoviesAsync();

            if(Connectivity.NetworkAccess == NetworkAccess.Internet)
            {
                var movieResponse = await _movieApiService.GetMoviesAsync();

                if(movieResponse != null)
                { 
                    foreach(var movie in movieResponse.Movies)
                    {
                        Movies.Add(movie);
                    }
                }
            }
            else
            {
                MainThread.BeginInvokeOnMainThread(async () =>
                {
                    await App.Current.MainPage.DisplayAlert("Alerta", "No hay conexión a Internet", "OK");
                });
            }
        }
        

        IMovieApiService _movieApiService;
    }
}
