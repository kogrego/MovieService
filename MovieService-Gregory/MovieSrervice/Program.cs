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
            try
            {
                movieService.SearchMovie("Aasdasfasf-Man");
            }
            catch (TitleNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                movieService.SearchMovie("Ant-Man");
            }
            catch (TitleNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            movieService.GetMovieInfo("Ant-Man");
            movieService.SearchMovie("Armageddon", "1998");
            Console.ReadLine();
        }
    }
}
