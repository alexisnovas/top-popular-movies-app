using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TopPopularMoviesApp.Services
{
    public interface IMovieApi
    {
        // Register and Get your API key here (More Info on Readme file)-> https://imdb-api.com/
        [Get("/en/API/MostPopularMovies/PASTE_YOUR_API_KEY_HERE")]
        Task<HttpResponseMessage> GetMoviesAsync();
    }
}
