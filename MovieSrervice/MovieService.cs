using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSrervice
{
    class MovieService : IMovieService
    {
        public abstract void getMovieData(ref Movie movie);
    }
}
