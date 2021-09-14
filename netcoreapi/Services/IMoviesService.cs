using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity = WebAPI.Entities;

namespace WebAPI.Services
{
    public interface IMoviesService
    {        
        IEnumerable<Entity.Movies> GetMovies(string location = "", string language = "");        
    }
}
