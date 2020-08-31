using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        Node Root;

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Add(Node nodeToAdd)
        {
            if (Root == null)
            {
                Root = nodeToAdd;
            }
            else
            {              
                Node currentNode = Root;
                while (true)
                {
                    if (nodeToAdd.Data < currentNode.Data)
                    {
                        if(currentNode.LeftChild == null)
                        {
                            currentNode.LeftChild = nodeToAdd;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.LeftChild;
                        }
                       
                    }
                    else if (nodeToAdd.Data > currentNode.Data)
                    {
                        if (currentNode.RightChild == null)
                        {
                            currentNode.RightChild = nodeToAdd;
                            break;

                        }
                        else
                        {
                            currentNode = currentNode.RightChild;
                        }
                    }

                }

            }

        }

        public void Search(int value)
        {
            bool containsValue = false;

            if (Root.Data == value)
            {
                containsValue = true;
            }
            else
            {
                Node currentNode = Root;

                while (true)
                {
                    if (value < currentNode.Data)
                    {
                        if (currentNode.LeftChild == null)
                        {                         
                            break;
                        }
                        else if (currentNode.LeftChild.Data == value)
                        {
                            containsValue = true;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.LeftChild;
                        }

                    }
                    else if (value > currentNode.Data)
                    {
                        if (currentNode.RightChild == null)
                        {
                            break;

                        }
                        else if (currentNode.RightChild.Data == value)
                        {
                            containsValue = true;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.RightChild;
                        }
                    }


                }
            }
           
            if (containsValue == true)
            {
                Console.WriteLine("Your value is in this tree!");
            }
            else
            {
                Console.WriteLine("Your value is not in this tree!");
            }


          

        }
    }

    

  
}
