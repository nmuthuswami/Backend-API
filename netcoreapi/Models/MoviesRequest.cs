using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class MoviesRequest
    {
        public string Location { get; set; }
        public string Language { get; set; }
    }
}
