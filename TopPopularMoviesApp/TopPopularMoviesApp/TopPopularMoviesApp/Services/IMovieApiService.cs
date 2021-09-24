using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TopPopularMoviesApp.Models;

namespace TopPopularMoviesApp.Services
{
    public interface IMovieApiService
    {
        Task<MovieResponse> GetMoviesAsync();
    }
}
