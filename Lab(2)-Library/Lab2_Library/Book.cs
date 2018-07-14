using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Library
{
    class Book : IComparable
    {
        private string title;
        Person author;

        Person age;



        public Book(string title)
        {
            this.title = title;
        }
    




        public Person Age
        {
            get { return age; }
            set { age = value; }
        }



    public string Title
        {
            get { return title; }
            set { title = value; }
        }


        public Person Author
        {
            get { return author; }
            set { author = value; }
        }



   

        public int CompareTo(Object obj) //implementation of CompareTo
        {                   // for IComparable

            Book other = (Book)obj;
            return Title.CompareTo(other.Title); //uses Name for comparison        
        }

  
    }
}

