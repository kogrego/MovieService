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
                title = value;
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
                year = value;
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
                    //trow NoTitleFoundExeption();
                }
            }
        }
        public override string ToString()
        {
            return Title + " " + "(" + Year + ")";
        }
    }
}
