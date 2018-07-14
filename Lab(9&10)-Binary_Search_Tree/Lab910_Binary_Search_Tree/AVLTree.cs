using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab910_Binary_Search_Tree
{
    class AVLTree<T> : BSTree<T> where T : IComparable
    {
        public new void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            
               tree = new Node<T>(item);
            
            else if (item.CompareTo(tree.Data) < 0)
            
                insertItem(item, ref tree.Left);
            
            else if (item.CompareTo(tree.Data) > 0)
            
                insertItem(item, ref tree.Right);
            

            tree.BalanceFactor = Height(ref tree.Left) - Height(ref tree.Right);

            if (tree.BalanceFactor <= -2)
            
                rotateLeft(ref tree);
            
            if (tree.BalanceFactor >= 2)
            
                rotateRight(ref tree);
         
        }
        
    
        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor > 0)
            {
                rotateRight(ref tree.Right);
            }
            Node<T> oldRoot = tree;
            Node<T> newRoot = tree;

            tree.Right = oldRoot;
            tree.Left = newRoot;
            tree.Right = tree.Left;
        }

        private void rotateRight(ref Node<T> tree)
        {
            if (tree.Right.BalanceFactor < 0)
            {
                rotateLeft(ref tree.Left);
            }
            Node<T> oldRoot = tree;
            Node<T> newRoot = tree;


            tree.Right = oldRoot;
            tree.Left = newRoot;
            tree.Left = tree.Right;

        }
    }
}
