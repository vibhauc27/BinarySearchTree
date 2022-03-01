using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    //Creating binary search tree using generics and IComparable to use CompareTo method in program
    public class BinSearchTree<T> where T : IComparable<T>
    {
        //Initializing variables
        public int leftCount, rightCount;
        public bool result = false;

        //Declaring Properties
        public T NodeData { get; set; }
        public BinSearchTree<T> LeftTree { get; set; }
        public BinSearchTree<T> RightTree { get; set; }

        //Paramerterized constructor
        public BinSearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }


        //Method to check node and add node value to either left or right by comparing
        public void Insert(T data)
        {
            T currentNodeValue = NodeData;
            if ((data.CompareTo(currentNodeValue)) < 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new BinSearchTree<T>(data);
                else
                    this.LeftTree.Insert(data);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BinSearchTree<T>(data);
                else
                    this.RightTree.Insert(data);
            }
        }

        //Displaying the data in the binary tree
        public void Display()
        {
            if (this.LeftTree != null)
            {
                leftCount++;
                LeftTree.Display();
            }
            Console.Write("\nBinary Tree:{0}", NodeData.ToString() + " ");
            if (this.RightTree != null)
            {
                rightCount++;
                RightTree.Display();
            }
        }

        //Method to get the size of the binary tree
        public void GetSize()
        {
            Console.WriteLine("\n\nSize of the binary tree is : " + (1 + this.leftCount + this.rightCount) + "\n");
        }

        //Method to search the given value in the binary tree
        public bool IfValueExists(T data, BinSearchTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(data))
            {
                result = true;
            }
            else if (data.CompareTo(node.NodeData) < 0)
            {
                IfValueExists(data, node.LeftTree);
            }
            else
            {
                IfValueExists(data, node.RightTree);
            }
            return result;
        }

    }
}