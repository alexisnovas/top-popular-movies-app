using Refit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TopPopularMoviesApp.Models;

namespace TopPopularMoviesApp.Services
{
    public class MovieApiService : IMovieApiService
    {
        IJsonSerializerService serializer = new JsonSerializerService();

        public MovieApiService()
        {
           _movieApi = RestService.For<IMovieApi>("https://imdb-api.com");
        }

        public async Task<MovieResponse> GetMoviesAsync()
        {
            var response = await _movieApi.GetMoviesAsync();

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();

                var movieResponse = serializer.Deserialize<MovieResponse>(responseString);

                return movieResponse;
            }
            return null;
        }

        IMovieApi _movieApi;
    }
}
