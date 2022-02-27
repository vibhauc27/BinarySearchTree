using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
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

        //Method to check and add node value to either left or right by comparing
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

        //Displaying the data
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
    }
}
