using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab910_Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {

            Node<int> root = new Node<int>(17);
            root.Left = new Node<int>(3);
            root.Right = new Node<int>(16);
            root.Left.Left = new Node<int>(8);
            root.Left.Right = new Node<int>(16);
            root.Left.Left.Left = new Node<int>(67342);
        
            BinTree<int> tree = new BinTree<int>(root);


            BSTree<int> x = new BSTree<int>();
            x.InsertItem(50);
            x.InsertItem(60);
            x.InsertItem(900);
   
            System.Console.WriteLine("Tree Contains 50: " + x.Contains(50));
            System.Console.WriteLine("Tree Contains 1 : " + x.Contains(1));

            x.RemoveItem(50);
            System.Console.WriteLine("Tree Contains 50: (Remove Item) " + x.Contains(50));




            System.Console.WriteLine("The number of nodes in the tree : " + x.Count(ref root));
            System.Console.WriteLine("Tree height is : " + x.Height(ref root));
      
            Console.ReadLine();

            string buffer = "";
            tree.InOrder(ref buffer);
            System.Console.WriteLine("In Order: " + buffer);

            string buffer1 = "";
            tree.postOrder(ref buffer1);
            System.Console.WriteLine("Post Order: " + buffer1);


            string buffer2 = "";
            tree.Preorder(ref buffer2);
            System.Console.WriteLine("Pre Order: " + buffer2);
            Console.ReadLine();

            


        }
    }
    }

