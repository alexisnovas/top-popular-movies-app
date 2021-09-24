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
        // Get API key here -> 
        [Get("/en/API/MostPopularMovies/k_lr7ijm2d")]
        Task<HttpResponseMessage> GetMoviesAsync();
    }
}
