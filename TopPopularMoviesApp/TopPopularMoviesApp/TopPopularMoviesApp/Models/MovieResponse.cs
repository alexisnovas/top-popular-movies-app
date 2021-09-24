using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace TopPopularMoviesApp.Models
{
    public class MovieResponse
    {
        [JsonPropertyName("items")]
        public List<Movie> Movies { get; set; }

        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }
    }

}
