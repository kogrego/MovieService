using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieSrervice;

namespace MovieServiceTest
{
    [TestClass]
    public class MovieServiceTest
    {
        [TestMethod]
        public void SearchMovieTest()
        {
            OmdbService service = OmdbService.Service;
            string title = "Ant man";
            SearchResult expected = new SearchResult();
            expected.Title.Add("Ant-Man");
            expected.Year.Add("2015");
            SearchResult actual = service.SearchMovie(title);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void SearchMovieTest2()
        {
            OmdbService service = OmdbService.Service;
            string title = "Armageddon";
            string year = "1998";
            SearchResult expected = new SearchResult();
            expected.Title.Add("Armageddon");
            expected.Title.Add("Countdown to Armageddon");
            expected.Title.Add("Armageddon: Target Earth");
            expected.Title.Add("Armageddon: Biblical Prophecy");
            expected.Year.Add("1998");
            expected.Year.Add("1998");
            expected.Year.Add("1998");
            expected.Year.Add("1998");
            SearchResult actual = service.SearchMovie(title, year);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void GetMovieInfoTest()
        {
            OmdbService service = OmdbService.Service;
            string title = "The matrix";
            MovieInfo expected = new MovieInfo();
            expected.Title = "The Matrix";
            expected.Year = "1999";
            expected.Rated = "R";
            expected.Released = "31 Mar 1999";
            expected.RunTime = "136 min";
            expected.Genre = "Action, Sci-Fi";
            expected.Director = "Andy Wachowski, Lana Wachowski";
            expected.Writer = "Andy Wachowski, Lana Wachowski";
            expected.Actors = "Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving";
            expected.Plot = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.";
            expected.Language = "English";
            expected.Country = "USA, Australia";
            expected.Awards = "Won 4 Oscars. Another 33 wins & 40 nominations.";
            expected.Rating = "8.7";
            MovieInfo actual = service.GetMovieInfo(title);
            Assert.AreNotEqual(expected, actual);

        }
    }
}
