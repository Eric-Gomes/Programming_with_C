using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_LinkedListGen
{
    class LinkListGen<T> where T : IComparable
    {
        private LinkGen<T> list;


        public LinkListGen()
        {
            this.list = null;

        }

        public void AddItem(T item)
        {

            list = new LinkGen<T>(item, list);

        }

        public string DisplayItems() //write items to string and return
        {
            LinkGen<T> temp = list;
            string buffer = "";
            while (temp != null) // move one link and add head to the buffer
            {
                buffer += temp.Data + "";
                temp = temp.Next;
            }
            return buffer;
        }

        public int NumberOfItems() // returns number of items in list
        {
            LinkGen<T> temp = list;
            int count = 0;
            while (temp != null) // move one link and add 1 to count
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }



        public void RemoveItem(int item)
        {
            LinkGen<T> current = list;
            LinkGen<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    if (previous != null)
                    {

                        previous.Next = current.Next;
                        current = current.Next;

                    }


                    else
                    {
                        previous = current;
                        current = current.Next;
                        list = current;
                    }
                }
                else
                    previous = current;
                current = previous.Next;
            }

        }



        public void InsertInOrder(T item)
        {
            LinkGen<T> temp = list;
            LinkListGen<T> tempList = new LinkListGen<T>();
            int a = 0;

            while (temp != null)
            {
                if (item.CompareTo(temp.Data) < 0 && a == 0)
                {
                    tempList.AppendItem(item);
                    tempList.AppendItem(temp.Data);
                    a++;
                    temp = temp.Next;
                }

                else
                {
                    tempList.AppendItem(temp.Data);
                    temp = temp.Next;
                }
            }
            if (a == 0)
            {
                tempList.AppendItem(item);
            }
            list = tempList.list;

        }// end InsertInOrder



        public void AppendItem(T item)
        {
            LinkGen<T> temp = list;
            if (temp == null)
            {
               list = new LinkGen<T>(item, null);
            }
            else
            {
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new LinkGen<T>(item);
            }
        }

       


        public void Concat(LinkListGen<T> list2)
        {

            LinkGen<T> temp = list2.list;
            while (temp != null)
            {
                AppendItem(temp.Data);
                temp = temp.Next;
            }
        }

    

        public void Copy(LinkListGen<T> list2)
        {
          ;
            LinkGen<T> temp = list2.list;
            while (temp != null)
            {
                AppendItem(temp.Data);
                temp = temp.Next;
            }
        }

        public void Sort()
        {
            LinkGen<T> temp = list;
            LinkListGen<T> tempList = new LinkListGen<T>();

            while (temp != null)
            {
                tempList.InsertInOrder(temp.Data);
                temp = temp.Next;
            }
            list = tempList.list;

        }

        public void Clear()
        {
            list = null;
        }

    }
}








        

 
 

