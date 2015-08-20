using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSrervice
{
    static class MovieServiceFactory
    {
        public static string OMDB = "OMDB";
        public static string TMDB = "TMDB";

        public static IMovieService GetMovieService(string service)
        {
            if (service == "OMDB")
            {
                return OmdbService.Service;
            }
            else if (service == "TMDB")
            {
                return TmdbService.Service;
            }
            else
            {
                throw new WrongServiceNameException("No such service");
            }
        }
    }
}
