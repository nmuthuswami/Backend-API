using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Services
{
    public class MoviesService : IMoviesService
    {
        private List<Entities.Movies> _movies = new List<Entities.Movies>()
        {
            new Entities.Movies{ imdbID="imdb1", imdbRating="3",Language="English",listingType ="Sample Listing Type",Location="Europe",Plot="ABC",Poster="Poster1",
                SoundEffects=new List<string>{ "Dolby Atmos","DTS"},Stills=new List<string>{"still1.jpg", "still2.jpg" },Title="Title 1" },
            new Entities.Movies{ imdbID="imdb2", imdbRating="3",Language="Spanish",listingType ="Sample Listing Type",Location="NorthAmerica",Plot="ABC",Poster="Poster2",
                SoundEffects=new List<string>{ "Dolby Atmos","DTS"},Stills=new List<string>{"still1.jpg", "still2.jpg" },Title="Title 2" },
            new Entities.Movies{ imdbID="imdb3", imdbRating="3",Language="English",listingType ="Sample Listing Type",Location="NorthAmerica",Plot="ABC",Poster="Poster3",
                SoundEffects=new List<string>{ "Dolby Atmos","DTS"},Stills=new List<string>{"still1.jpg", "still2.jpg" },Title="Title 3" },
            new Entities.Movies{ imdbID="imdb4", imdbRating="3",Language="Hindi",listingType ="Sample Listing Type",Location="Asia",Plot="ABC",Poster="Poster4",
                SoundEffects=new List<string>{ "Dolby Atmos","DTS"},Stills=new List<string>{"still1.jpg", "still2.jpg" },Title="Title 4" },
            new Entities.Movies{ imdbID="imdb5", imdbRating="3",Language="Spanish",listingType ="Sample Listing Type",Location="Europe",Plot="ABC",Poster="Poster5",
                SoundEffects=new List<string>{ "Dolby Atmos","DTS"},Stills=new List<string>{"still1.jpg", "still2.jpg" },Title="Title 5" },
            new Entities.Movies{ imdbID="imdb6", imdbRating="3",Language="Japanese",listingType ="Sample Listing Type",Location="Asia",Plot="ABC",Poster="Poster6",
                SoundEffects=new List<string>{ "Dolby Atmos","DTS"},Stills=new List<string>{"still1.jpg", "still2.jpg" },Title="Title 6" },
            new Entities.Movies{ imdbID="imdb7", imdbRating="3",Language="Chinese",listingType ="Sample Listing Type",Location="Asia",Plot="ABC",Poster="Poster7",
                SoundEffects=new List<string>{ "Dolby Atmos","DTS"},Stills=new List<string>{"still1.jpg", "still2.jpg" },Title="Title 7" },
            new Entities.Movies{ imdbID="imdb8", imdbRating="3",Language="Tamil",listingType ="Sample Listing Type",Location="Asia",Plot="ABC",Poster="Poster8",
                SoundEffects=new List<string>{ "Dolby Atmos","DTS"},Stills=new List<string>{"still1.jpg", "still2.jpg" },Title="Title 8" },
            new Entities.Movies{ imdbID="imdb9", imdbRating="3",Language="English",listingType ="Sample Listing Type",Location="Europe",Plot="ABC",Poster="Poster9",
                SoundEffects=new List<string>{ "Dolby Atmos","DTS"},Stills=new List<string>{"still1.jpg", "still2.jpg" },Title="Title 9" },
            new Entities.Movies{ imdbID="imdb10", imdbRating="3",Language="English",listingType ="Sample Listing Type",Location="Europe",Plot="ABC",Poster="Poster10",
                SoundEffects=new List<string>{ "Dolby Atmos","DTS"},Stills=new List<string>{"still1.jpg", "still2.jpg" },Title="Title 10" }
        };

        public MoviesResponse GetMovies(MoviesRequest request =null)
        {
            MoviesResponse responseFilter = new MoviesResponse();
            responseFilter.Movies = _movies;

            if (request == null)
                return responseFilter;

            if (!string.IsNullOrEmpty(request.Location) && !request.Location.Equals("default"))//filters by location
                responseFilter.Movies = responseFilter.Movies.Where(w => w.Location.Equals(request.Location));
            if (!string.IsNullOrEmpty(request.Language) && !request.Language.Equals("default"))//filters by language
                responseFilter.Movies = responseFilter.Movies.Where(w => w.Language.Equals(request.Language));
                        
            return responseFilter;
        }            
    }
}
