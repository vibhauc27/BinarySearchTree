using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Welcome To Binary Search Tree");
           
            //Creating binary search tree to insert and display node values

            BinSearchTree<int> binaryTree = new BinSearchTree<int>(56);
            binaryTree.Insert(30);
            binaryTree.Insert(70);
            binaryTree.Display();            
        }
    }
}