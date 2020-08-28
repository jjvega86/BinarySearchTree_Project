using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        Node rootNode;  

        public BinarySearchTree()
        {
            rootNode = null;
      
        }

        public void Add(Node addedNode)
        {
            if (rootNode == null)
            {
                rootNode = addedNode;
            }
            else if (addedNode.Data < rootNode.Data)
            {
                rootNode.leftChild = addedNode;
                
            }
            else if (addedNode.Data > rootNode.Data)
            {
                rootNode.rightChild = addedNode;
            }

        }

        public void Search()
        {

        }
    }

    

  
}
