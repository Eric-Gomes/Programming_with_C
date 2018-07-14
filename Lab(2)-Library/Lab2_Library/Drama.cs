using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Library
{
    class Drama : Book
    {
        public Drama(string Title) : base(Title)
        {
            base.Author = new Person("Shakespeare");
        }
    }

}
