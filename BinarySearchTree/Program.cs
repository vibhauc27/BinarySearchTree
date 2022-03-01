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
            //Displaying the message
            Console.WriteLine("Welcome To Binary Search Tree");
            
            //Creating binary search tree to insert and display node values
            BinSearchTree<int> binaryTree = new BinSearchTree<int>(56);

            //Inserting default values in binary tree
                        binaryTree.Insert(30);
                        binaryTree.Insert(70);
                        binaryTree.Insert(22);
                        binaryTree.Insert(40);
                        binaryTree.Insert(60);
                        binaryTree.Insert(95);
                        binaryTree.Insert(11);
                        binaryTree.Insert(65);
                        binaryTree.Insert(3);
                        binaryTree.Insert(16);
                        binaryTree.Insert(63);
                        binaryTree.Insert(67);
                        Console.WriteLine("\nValues are inserted into binary tree\n"); 
            
                        binaryTree.Display();          
            
                        binaryTree.GetSize();
                       
        }
    }
}