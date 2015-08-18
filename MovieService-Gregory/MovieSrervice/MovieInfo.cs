using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSrervice
{
    class MovieInfo
    {
        private string title;
        private string year;
        private string runTime;
        private string genre;
        private string director;
        private string actors;
        private string plot;
        private string rating;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value != null)
                {
                    title = value;
                }
                else
                {
                    title = "Missing data";
                }
            }
        }

        public string Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value != null)
                {
                    year = value;
                }
                else
                {
                    year = "Missing data";
                }
            }
        }

        public string RunTime
        {
            get
            {
                return runTime;
            }
            set
            {
                if (value != null)
                {
                    runTime = value;
                }
                else
                {
                    runTime = "Missing data";
                }
            }
        }

        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                if (value != null)
                {
                    genre = value;
                }
                else
                {
                    genre = "Missing data";
                }
            }
        }

        public string Director
        {
            get
            {
                return director;
            }
            set
            {
                if (value != null)
                {
                    director = value;
                }
                else
                {
                    director = "Missing data";
                }
            }
        }

        public string Actors
        {
            get
            {
                return actors;
            }
            set
            {
                if (value != null)
                {
                    actors = value;
                }
                else
                {
                    actors = "Missing data";
                }
            }
        }

        public string Plot
        {
            get
            {
                return plot;
            }
            set
            {
                if (value != null)
                {
                    plot = value;
                }
                else
                {
                    plot = "Missing data";
                }
            }
        }

        public string Rating
        {
            get
            {
                return rating;
            }
            set
            {
                if (value != null)
                {
                    rating = value;
                }
                else
                {
                    rating = "Missing data";
                }
            }
        }
        public override string ToString()
        {
            return "\nTitle: " + Title + "\n" + "Year: " + Year + "\n" + "RunTime: " + RunTime + "\n" + "Genre: " + Genre + "\n" + "Director: " + Director + "\n"
                 + "Actors: " + Actors + "\n" + "Plot: " + Plot + "\n" + "IMDB Rating: " + Rating + "\n\n";
        }
    }
}
