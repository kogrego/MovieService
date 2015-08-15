using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSrervice
{
    interface IMovieService
    {
        void SearchByTitle(string title);
        void GetMovieInfo(string title);
    }
}
