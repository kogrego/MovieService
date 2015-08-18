using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Xml;
using System.Xml.Linq;

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

        public void SearchMovie(string title)
        {
            string url = baseUrl + "s=" + title;
            XDocument xDoc = XDocument.Load(url);
            string response = xDoc.Descendants("root").Attributes("response").First().Value;
            if (response == "True")
            {
                var moviesQuery = from root in xDoc.Root.Descendants("Movie")
                                  select new
                                  {
                                      Title = root.Attribute("Title").Value,
                                      Year = root.Attribute("Year").Value,
                                      Type = root.Attribute("Type").Value
                                  };
                var movies = moviesQuery.ToList();
                foreach (var movie in movies)
                {
                    if (movie.Type == "movie")
                    {
                        SearchResult result = new SearchResult();
                        result.Title = movie.Title;
                        result.Year = movie.Year;
                        Console.WriteLine(result.ToString());
                    }
                }

            }
            else
            {
                //throw TitleNotFoundException;
            }
        }

        public void SearchMovie(string title, string year)
        {
            string url = baseUrl + "s=" + title + "&y=" + year;
            XDocument xDoc = XDocument.Load(url);
            string response = xDoc.Descendants("root").Attributes("response").First().Value;
            if (response == "True")
            {
                var moviesQuery = from root in xDoc.Root.Descendants("Movie")
                                  select new
                                  {
                                      Title = root.Attribute("Title").Value,
                                      Year = root.Attribute("Year").Value,
                                      Type = root.Attribute("Type").Value
                                  };
                var movies = moviesQuery.ToList();
                foreach (var movie in movies)
                {
                    if (movie.Type == "movie")
                    {
                        SearchResult result = new SearchResult();
                        result.Title = movie.Title;
                        result.Year = movie.Year;
                        Console.WriteLine(result.ToString());
                    }
                }

            }
            else
            {
                //throw TitleNotFoundException;
            }
        }

        public void GetMovieInfo(string title)
        {
            string query = baseUrl + "t=" + title;
            XDocument xDoc = XDocument.Load(query);
            string response = xDoc.Descendants("root").Attributes("response").First().Value;
            if (response == "True")
            {
                var moviesQuery = from root in xDoc.Root.Descendants("movie")
                                  select new
                                  {
                                      Title = root.Attribute("title").Value,
                                      Year = root.Attribute("year").Value,
                                      Runtime = root.Attribute("runtime").Value,
                                      Genre = root.Attribute("genre").Value,
                                      Director = root.Attribute("director").Value,
                                      Plot = root.Attribute("plot").Value,
                                      Actors = root.Attribute("actors").Value,
                                      Rating = root.Attribute("imdbRating").Value,
                                      Type = root.Attribute("type").Value
                                  };
                var movies = moviesQuery.ToList();
                foreach (var movie in movies)
                {
                    MovieInfo result = new MovieInfo();
                    result.Title = movie.Title;
                    result.Year = movie.Year;
                    result.RunTime = movie.Runtime;
                    result.Genre = movie.Genre;
                    result.Director = movie.Director;
                    result.Plot = movie.Plot;
                    result.Actors = movie.Actors;
                    result.Rating = movie.Rating;
                    if (movie.Type == "movie")
                    {
                        Console.WriteLine(result.ToString());
                    }
                    else
                    {
                        //throw TitleNotFoundException;
                    }
                }

            }
            else
            {
                //throw TitleNotFoundException;
            }
        }

    }
}
