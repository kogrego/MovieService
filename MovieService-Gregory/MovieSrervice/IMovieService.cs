using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSrervice
{
    interface IMovieService
    {
        SearchResult SearchMovie(string title);
        SearchResult SearchMovie(string title, string year);
        MovieInfo GetMovieInfo(string title);
    }
}
