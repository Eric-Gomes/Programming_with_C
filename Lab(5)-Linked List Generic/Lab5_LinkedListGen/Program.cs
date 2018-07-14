using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_LinkedListGen
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkListGen<int> list = new LinkListGen<int>();
            LinkListGen<int> list2 = new LinkListGen<int>();



            list.AddItem(40);
            list.AddItem(60);
            list.AddItem(80);
            list.AddItem(90);
            list.AddItem(70);
            list.AddItem(20);
            list.AddItem(15);

            list.Sort();


            System.Console.WriteLine("Copy " + list.DisplayItems());


            list.Clear();



            list2.AddItem(40);
            list2.AddItem(60);
            list2.AddItem(80);
            list2.AddItem(100);
            list.Copy(list2);


            System.Console.WriteLine("Copy " + list.DisplayItems());

            list.Clear();

            list2.Clear();


            list.AddItem(20);
            list.AddItem(40);
            list.AddItem(60);
            list.AddItem(80);
            list.AddItem(100);

            list2.AddItem(10);
            list2.AddItem(30);
            list2.AddItem(50);
            list2.AddItem(70);
            list2.AddItem(90);


            list.Concat(list2);
            System.Console.WriteLine("Concat Two Lists: " + list.DisplayItems());

            list.Clear();

            list2.Clear();



            list.AddItem(40);
           list.AddItem(11);
           list.AddItem(77);
            list.AppendItem(54);
            list.AppendItem(23);
            System.Console.WriteLine("Append Item " + list.DisplayItems());


   
           //Remove Item
            list.RemoveItem(40);
            list.RemoveItem(11);
            list.RemoveItem(77);
            list.RemoveItem(54);
            list.RemoveItem(23);
            list.RemoveItem(30);
            System.Console.WriteLine("Remove Item " + list.DisplayItems());


            //IsPresent

            System.Console.WriteLine("Current Number of Items in List " + list.NumberOfItems());

            //Display Items In Order
            list.InsertInOrder(80);
            list.InsertInOrder(10);
            list.InsertInOrder(15);
            list.InsertInOrder(25);
            list.InsertInOrder(38);
            list.InsertInOrder(78);
            list.InsertInOrder(100);
            list.InsertInOrder(81);



            System.Console.WriteLine("Insert in order " + list.DisplayItems());


        




            System.Console.ReadLine();
            Console.ReadKey();
        }
    }
}
