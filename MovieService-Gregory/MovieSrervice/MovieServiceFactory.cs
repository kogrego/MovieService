using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSrervice
{
    class MovieServiceFactory
    {
        public static ImdbService IMDB;

        public static IMovieService GetMovieService(IMovieService service)
        {
            return ImdbService.Service;
        }
    }
}
