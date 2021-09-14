using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Services;
using WebAPI.Helper;

namespace WebAPI.Controllers
{
    [ApiController]    
    public class MoviesController : ControllerBase
    {
        private IMoviesService _moviesService;

        public MoviesController(IMoviesService moviesService)
        {
            _moviesService = moviesService;
        }        

        [Authorize]
        [Route("[controller]/{id:int=0}/{param1?}/{param2?}")]
        public IActionResult GetMovies(int id, string param1, string param2)
        {
            if (id == 1)
            {
                var movies = _moviesService.GetMovies(location: param1, language: string.Empty);
                return Ok(movies);
            }
            else if (id == 2)
            {
                var movies = _moviesService.GetMovies(location:string.Empty, language: param1);
                return Ok(movies);
            }
            else if (id == 3)
            {
                var movies = _moviesService.GetMovies(location: param1, language: param2);
                return Ok(movies);
            }
            else
            {
                var movies = _moviesService.GetMovies();
                return Ok(movies);
            }
        }
    }
}
