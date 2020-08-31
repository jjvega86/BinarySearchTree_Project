using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        Node Root { get; set; }

        public void Add(int data)
        {
            Node newNode = new Node();
            newNode.Data = data;


            if (Root == null)
            {
                Root = newNode;
            }
            else if (newNode.Data < Root.Data)
            {
                Root.LeftChild = newNode;
                
            }
            else if (newNode.Data > Root.Data)
            {
                Root.RightChild = newNode;
            }

        }

        public void Search()
        {

        }
    }

    

  
}
