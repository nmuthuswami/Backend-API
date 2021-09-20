﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IMoviesService
    {
        MoviesResponse GetMovies(MoviesRequest request = null);        
    }
}
