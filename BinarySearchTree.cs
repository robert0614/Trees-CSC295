using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Trees
{
    public class BinarySearchTree
    {
        private Node<int>? Root;
        private int Count = 0;

        public bool DoesValueExist(int ValueToFind)
        {
            Node<int> currentNode = Root;

            while (currentNode != null)
            {
                if (currentNode.Data == ValueToFind)
                    return true;
                else if (ValueToFind <= currentNode.Data)
                {
                    currentNode = currentNode.Left;
                } else
                {
                    currentNode = currentNode.Right;
                }
            }

            return false;
        }

        public void Insert(int data)
        {
            Node<int> newNode = new Node<int>(data);
            InsertHelper(newNode, Root);
        }

        private void InsertHelper(Node<int> newNode, Node<int>? currentNode)
        {
            if (Root == null)
            {
                Root = newNode;
                Count++;
                return;
            }
            // go left
            if (newNode.Data <= currentNode.Data)
            {
                if (currentNode.Left == null)
                {
                    currentNode.Left = newNode;
                    Count++;
                }
                else
                {
                    InsertHelper(newNode, currentNode.Left);
                }
            }
            else // go right
            {
                if (newNode.Data <= currentNode.Data)
                {
                    if (currentNode.Right == null)
                    {
                        currentNode.Right = newNode;
                        Count++;
                    }
                    else
                    {
                        InsertHelper(newNode, currentNode.Right);
                    }
                }
            }
        }

    }
}
