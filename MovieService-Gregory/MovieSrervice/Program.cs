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
            Console.WriteLine(movieService.SearchMovie("Ant Man"));
            Console.WriteLine(movieService.GetMovieInfo("Ant-Man"));
            Console.WriteLine(movieService.SearchMovie("Armageddon", "1998"));


            IMovieService movieService2 = MovieServiceFactory.GetMovieService(MovieServiceFactory.TMDB);
            movieService2.Authenticate();
            Console.ReadLine();
        }
    }
}
