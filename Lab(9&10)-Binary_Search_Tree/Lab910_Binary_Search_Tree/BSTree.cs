using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab910_Binary_Search_Tree
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {
        public BSTree()
        {
            root = null;
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T>(item);

            }

            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }

            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        public int Height(ref Node<T> tree)
        //Return the max level of the tree
        {
            if (tree == null)

                return 0;
            return (1 + Math.Max(Height(ref tree.Left), Height(ref tree.Right)));
        }


        public int Count(ref Node<T> tree)
        //Return the number of nodes in the tree
        {
            int counter = 0;

            if (tree == null)
            {
                return 0;
            }
            else if (tree.Left != null)
            {
                counter += Count(ref tree.Left);
                counter++;
            }

            if (tree.Right != null)
            {
                counter += Count(ref tree.Right);
                counter++;
            }
            return counter;
        }

        public Boolean Contains(T item)
        {
            Node<T> node = root;
            return contains(root, item);
        }


        private Boolean contains(Node<T> root, T item)
        {
            if (root == null)
            {
                return false;
            }

            if (item.CompareTo(root.Data) < 0)

                return contains(root.Left, item);

            if (item.CompareTo(root.Data) > 0)

                return contains(root.Right, item);

            return true;

        }

        T leastItem(Node<T> tree)
        {
            if (tree.Left == null)
            {
                return tree.Data;
            }
            else
            {
                return leastItem(tree.Left);
            }
        }

        public void RemoveItem(T item)
        {
            Node<T> node = root;
             removeItem(item, ref root);
        }


        private void removeItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                return;

            }

            if (item.CompareTo(tree.Data) < 0)
            {
                removeItem(item, ref tree.Left);
            }
            if (item.CompareTo(tree.Data) < 0)
            {
                removeItem(item, ref tree.Right);
            }

            if (tree.Left == null)
            {
                tree = tree.Right;

            }

           else if (tree.Right == null)
            {
                tree = tree.Left;

            }
        }

       public void foundItem(ref Node<T> tree)
        {
            if (tree.Left == null)
            {
                tree = tree.Right;
            }
            if (tree.Right == null)
            {
                tree = tree.Right;
            }

            T newRoot = leastItem(tree.Right);
            tree.Data = newRoot;
            removeItem(newRoot, ref tree.Right);
        }

    }
}


