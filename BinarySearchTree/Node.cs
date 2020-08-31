using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int Data { get; set; }
        public Node RightChild { get; set; }
        public Node LeftChild { get; set; }

        public Node(int data)
        {
            Data = data;
        }

    }
}
