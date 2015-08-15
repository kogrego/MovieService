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
                    //throw AttributeNotFoundException("title");
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
                    //throw AttributeNotFoundException("year");
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
                    //throw AttributeNotFoundException("runTime");
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
                    //throw AttributeNotFoundException("genre");
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
                    //throw AttributeNotFoundException("director");
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
                    //throw AttributeNotFoundException("actors");
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
                    //throw AttributeNotFoundException("plot");
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
                    //throw AttributeNotFoundException("rating");
                }
            }
        }
        public override string ToString()
        {
            return "Title: " + Title + "\n" + "Year: " + Year + "\n" + "RunTime: " + RunTime + "\n" + "Genre: " + Genre + "\n" + "Director: " + Director + "\n"
                 + "Actors: " + Actors + "\n" + "Plot: " + Plot + "\n" + "Rating: " + Rating + "\n";
        }
    }
}
