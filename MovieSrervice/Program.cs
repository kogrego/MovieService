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
            Console.WriteLine(movieService.SearchByTitle("Matrix"));
            Console.WriteLine(movieService.GetMovieInfo("Matrix"));
            Console.WriteLine(movieService.SearchByYear("1998"));
            Console.WriteLine(movieService.GetMovieInfo("Armagedon"));
        }
    }
}
