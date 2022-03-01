using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    //Creating binary search tree using generics and IComparable to use CompareTo method in program(UC1)
    public class BinSearchTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinSearchTree<T> LeftTree { get; set; }
        public BinSearchTree<T> RightTree { get; set; }

        public BinSearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }

        int leftCount = 0, rightCount = 0;

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

        public void Display()
        {
            if (this.LeftTree != null)
            {
                leftCount++;
                LeftTree.Display();
            }
            Console.Write("{0}", NodeData.ToString() + " ");
            if (this.RightTree != null)
            {
                rightCount++;
                RightTree.Display();
            }
        }

        //Method to get the size of the binary tree
        public void GetSize()
        {
            Console.WriteLine("\nSize of the binary tree is : " + (1 + this.leftCount + this.rightCount) + "\n");
        }
    }
}