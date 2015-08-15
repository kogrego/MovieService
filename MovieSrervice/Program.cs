using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSrervice
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovieService movieService = MovieServiceFactory.GetMovieService(MovieServiceFactory.IMDB);
            movieService.SearchByTitle("Suits");
            movieService.GetMovieInfo("Suits");
            Console.ReadLine();
        }
    }
}
