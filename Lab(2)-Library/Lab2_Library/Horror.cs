using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Library
{
 
       class Horror : Book
        {
            public Horror(string Title) : base(Title)
            {
                base.Author = new Person("Stephen King");
        }
        }

    }

