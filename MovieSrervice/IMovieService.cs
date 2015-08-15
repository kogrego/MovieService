using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSrervice
{
    interface IMovieService
    {
        List<string> SearchByTitle(string title);
        List<string> SearchByYear(string year);
        Movie GetMovieInfo(string title);
    }
}
