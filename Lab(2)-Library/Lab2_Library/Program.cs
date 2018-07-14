using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Library
{

  class Program
  {
        static void Main(string[] args)
        {


         Book[] books = new Book[7];  //declare an array of Book

         books[0] = new Book("Moby Dick");
         books[0].Author = new Person("Herman Melville");
         books[1] = new Horror("The Creeping");
         books[2] = new Horror("Dracula");
         books[2].Author = new Person("Bram Stoker");
         books[3] = new Book("Harry Potter and the Philosopher's Stone");
         books[3].Author = new Person("JK Rowling");
         books[4] = new Drama("Romeo And Juliet");
         books[5] = new History("1776");

        for (int i = 0; i < 6; i++)
            Console.WriteLine("{0}  {1}", books[i].Author.Name, books[i].Title);
            Console.ReadKey();

      }

  }


 }
       
