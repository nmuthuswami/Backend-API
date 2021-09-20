using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;

namespace WebAPI.Models
{
    public class MoviesResponse
    {
        public IEnumerable<Entities.Movies> Movies { get; set; }
    }
}
