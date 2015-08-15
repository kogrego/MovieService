using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSrervice
{
    public class TitleNotFoundException : ApplicationException
    {
        public TitleNotFoundException(string msg)
        { 

        }
    }
    public class AttributeNotFoundException : ApplicationException 
    {
        public AttributeNotFoundException(string msg)
        {

        }
    }
    public class NoTitleFoundExeption : ApplicationException
    {
        public NoTitleFoundExeption(string msg)
        {

        }
    }
}
