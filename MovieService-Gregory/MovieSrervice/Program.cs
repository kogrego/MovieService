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
            movieService.SearchMovie("Suits");
            movieService.GetMovieInfo("Suits");
            movieService.SearchMovie("Armageddon", "1998");
            Console.ReadLine();
        }
    }
}
