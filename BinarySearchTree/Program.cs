using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            Node node1 = new Node(33);
            Node node2 = new Node(11);
            Node node3 = new Node(45);
            Node node4 = new Node(22);
            Node node5 = new Node(5);
            Node node6 = new Node(7);
            Node node7 = new Node(20);
            tree.Add(node1);
            tree.Add(node2);
            tree.Add(node3);
            tree.Add(node4);
            tree.Add(node5);
            tree.Add(node6);
            tree.Add(node7);

            tree.Search(20);

            Console.ReadLine();

        }
    }
}
