using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        public Node rootNode;

        public BinarySearchTree()
        {
            rootNode = null;
        }

        public void Add(int value)
        {
            if (rootNode == null)
            {
                rootNode.Data = value;
            }
            else if (value < rootNode.Data)
            {

            }

        }

        public void Search()
        {

        }
    }

    

  
}
