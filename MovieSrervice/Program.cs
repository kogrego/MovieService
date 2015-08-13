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
            Console.WriteLine(movieService.getMovieInfo("Matrix"));
            Console.WriteLine(movieService.SeachByYear("2000"));
            Console.WriteLine(movieService.getMovieInfo("Armagedon"));
        }
    }
}
