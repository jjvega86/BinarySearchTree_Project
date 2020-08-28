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
        public int Data;
        public Node leftChild;
        public Node rightChild;

        public Node(int data)
        {
            Data = data;
            leftChild = null;
            rightChild = null;
        }
    }
}
