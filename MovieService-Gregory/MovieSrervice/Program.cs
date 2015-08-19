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
            IMovieService movieService = MovieServiceFactory.GetMovieService(MovieServiceFactory.OMDB);
            Console.WriteLine(movieService.SearchMovie("Ant Man"));
            Console.WriteLine(movieService.GetMovieInfo("Ant-Man"));
            Console.WriteLine(movieService.SearchMovie("Armageddon", "1998"));


            IMovieService movieService2 = MovieServiceFactory.GetMovieService(MovieServiceFactory.TMDB);
            Console.WriteLine(movieService2.Authenticate());
            Console.WriteLine(movieService2.SearchMovie("Ant Man"));
            Console.WriteLine(movieService2.SearchMovie("Ant Man", "2015"));
            Console.ReadLine();
        }
    }
}
