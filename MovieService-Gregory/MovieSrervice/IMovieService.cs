using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSrervice
{
    interface IMovieService
    {
        void SearchMovie(string title);
        void SearchMovie(string title, string year);
        void GetMovieInfo(string title);
    }
}
