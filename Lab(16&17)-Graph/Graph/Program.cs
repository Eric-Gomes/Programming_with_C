using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {

            GraphNode<char> current;  //current location
            GraphNode<char> to;  //current location

            GraphNode<char> current1;  //current location

            GraphNode<char> to1;  //current location
            Graph<char> myGraph = new Graph<char>();  //current location

            myGraph.AddNode('A');
            myGraph.AddNode('B');

            myGraph.AddNode('X');
            myGraph.AddNode('Y');

            myGraph.AddEdge('A', 'B');

            myGraph.AddEdge('X', 'Y');
            myGraph.AddEdge('Y', 'X');



            current = myGraph.GetNodeByID('X');
            to = myGraph.GetNodeByID('Y');

            current1 = myGraph.GetNodeByID('A');
            to1 = myGraph.GetNodeByID('B');

            Console.WriteLine("Is my graph empty? Answer : {0}", myGraph.IsEmptyGraph());
            Console.WriteLine("Does myGraph contain {0}? Answer: {1}", current.ID, myGraph.ContainsGraph(current));
            Console.WriteLine("Is node {0} and {1} adjacent? Answer: {2}", to.ID, current.ID, myGraph.IsAdjacent(to, current));
            Console.WriteLine("Is node {0} and {1} adjacent? Answer: {2}", current.ID, to.ID, myGraph.IsAdjacent(current, to));
            Console.WriteLine("Is node {0} and {1} adjacent? Answer: {2}", to1.ID, current1.ID, myGraph.IsAdjacent(to1, current1));
            Console.WriteLine("Is node {0} and {1} adjacent? Answer: {2}", current1.ID, to1.ID, myGraph.IsAdjacent(current1, to1));
            Console.ReadLine();

            


        }
    }

}
