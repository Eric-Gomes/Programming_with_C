using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Graph<T> where T : IComparable
    {
        //list of GraphNodes in this graph
        private LinkedList<GraphNode<T>> nodes;
        //constructor - set nodes to new empty list
        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>();
        }
        //only return true if the graph’s list of nodes is empty
        public bool IsEmptyGraph()
        {

            return nodes.Count == 0;
        }


        //Search through list of nodes for node
        //Node will be a new graphnode with the
        // containing the ID to be search for
        public bool ContainsGraph(GraphNode<T> node)
        {
            //search based on ID – incomplete!
            if (node.ID.CompareTo(node.ID) == 0)
                return true;
            else
            {
                return false;
            }
        }
        //find from in list of nodes and search its adjList for to
        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> to)
        {
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.Equals(from.ID))
                {

                    if (from.GetAdjList().Contains(to.ID))
                    {
                        return true;
                    }
                }
            }

            return false;

        }
        //add a new graphNode to list of nodes
        public void AddNode(T id)
        {

            GraphNode<T> n = new GraphNode<T>(id);
            nodes.AddFirst(n);
        }
        //Search through list of nodes for node with this ID
        public GraphNode<T> GetNodeByID(T id)
        {

            foreach (GraphNode<T> n in nodes)
            {
                if (id.Equals(n.ID))
                {
                    return n;
                }
            }
            return null;
        }
        //find from in list of nodes (look at other methods)
        //and call graphNode method to add an edge to to
        //think about validation here
        public void AddEdge(T from, T to)
        {

            foreach (GraphNode<T> n in nodes)
            {

                if (from.Equals(n.ID))
                {
                    n.GetAdjList().AddLast(to);
                    n.GetAdjList().AddFirst(from);

                }

            }
        }
        //perform a DFS traversal starting at startID, leaving a list
        //of visitied ID’s in the visited list.
        public void DepthFirstTraverse(T startID, ref List<GraphNode<T>> visited)
        {
            LinkedList<T> adj;
            Stack<T> toVisit = new Stack<T>();
            GraphNode<T> current;
            toVisit.Push(startID); //push the first id onto the stack

            while (toVisit.Count != 0)
            {
                current = GetNodeByID(toVisit.Peek());
                adj = current.GetAdjList();
                visited.Add(current);

                foreach (T type in adj)
                {
                    if (!toVisit.Contains(type) && !visited.Contains(GetNodeByID(type)))
                    {
                        toVisit.Push(type);
                    }
                }
            }
        }
        public void BreadthFirstTraverse(T startID, ref List<GraphNode<T>> visited)
        {
            LinkedList<T> adj;
            Queue<T> toVisit = new Queue<T>();
            GraphNode<T> current;
            toVisit.Enqueue(startID);

            while (toVisit.Count != 0)
            {
                //get it off from the list
                T currentID = toVisit.Dequeue();
                current = GetNodeByID(currentID);
                adj = current.GetAdjList();
                //add the current to the visited list, so we know where we have been
                visited.Add(current);
                foreach (T ID in adj)
                {
                    if (!toVisit.Contains(ID) && !visited.Contains(GetNodeByID(ID)))
                    {
                        toVisit.Enqueue(ID);
                    }
                }
            }
        }

    }


}
