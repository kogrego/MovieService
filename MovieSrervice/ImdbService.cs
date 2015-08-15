using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSrervice
{
    class ImdbService : IMovieService
    {
        private static ImdbService service;

        private ImdbService() { }
        public const string baseUrl = "http://www.omdbapi.com/?r=xml&";
        public static ImdbService Service
        {
            get
            {
                if (service == null)
                {
                    service = new ImdbService();
                }
                return service;
            }
        }

        public List<string> SearchByTitle(string title)
        {
            return Service.SearchByTitle(title);
        }

        public List<string> SearchByYear(string year)
        {
            return Service.SearchByYear(year);
        }

        public Movie GetMovieInfo(string title)
        {
            return Service.GetMovieInfo(title);
        }
    }
}
