using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSrervice
{
    class SearchResult
    {
        private List<string> title;
        private List<string> year;

        public SearchResult()
        {
            title = new List<string>();
            year = new List<string>();
        }

        public List<string> Title
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
                    title.Add("Missing data");
                }
            }
        }


        public List<string> Year
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
                    year.Add("Missing data");
                }
            }
        }

        public override string ToString()
        {
            string output = null;
            var comboList = Title.Zip(Year, (title, year) => title + " (" + year + ")");
            foreach (var entry in comboList)
            {
                output += entry + "\n";
            }
            return "\n" + output +"\n";
        }
    }
}
