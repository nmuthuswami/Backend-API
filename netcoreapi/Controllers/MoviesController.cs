using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Services;
using WebAPI.Helper;
using WebAPI.Models;

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
            MoviesRequest request;
            MoviesResponse response;
            if (id == 1)
            {
                request = new MoviesRequest() { Location = param1, Language = string.Empty };
                response = _moviesService.GetMovies(request);
                return Ok(response.Movies);
            }
            else if (id == 2)
            {
                request = new MoviesRequest() { Location = string.Empty, Language = param1 };
                response = _moviesService.GetMovies(request);
                return Ok(response.Movies);
            }
            else if (id == 3)
            {
                request = new MoviesRequest() { Location = param1, Language = param2 };
                response = _moviesService.GetMovies(request);
                return Ok(response.Movies);
            }
            else
            {
                response = _moviesService.GetMovies();
                return Ok(response.Movies);
            }
        }
    }
}
