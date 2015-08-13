using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSrervice
{
    class ImdbService : MovieService
    {
        private static ImdbService service;

        private ImdbService();
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
        public void getMovieData(ref Movie movie);
    }
}
