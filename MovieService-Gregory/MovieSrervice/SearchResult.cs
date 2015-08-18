using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSrervice
{
    class SearchResult
    {
        private string title;
        private string year;
        private string type;

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


        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if (value == "movie")
                {
                    type = value;
                }
                else
                {
                    type = "Missing data"; 
                }
            }
        }
        public override string ToString()
        {
            return "\n" + Title + " (" + Year + ")" + "\n";
        }
    }
}
