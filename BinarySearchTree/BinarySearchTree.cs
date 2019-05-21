using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        //member variable
        public Node root;

        //constructor
        public BinarySearchTree()
        {
            root = null;
        }

        //member methods
        public void Add(int data)
        {
            Node node;
            Node temp = new Node(data);
            if (root == null)
            {
                root = temp;
            }
            else
            {
                node = root;
                Node newNode;
                while (true)
                {
                    newNode = node;
                    if (data <= node.info)
                    {
                        node = node.left;
                        if (node == null)
                        {
                            newNode.left = temp;
                            return;
                        }
                    }
                    else
                    {
                        node = node.right;
                        if (node == null)
                        {
                            newNode.right = temp;
                            return;
                        }
                    }
                }
            }
        }
        public int search(int data, Node node = null)
        {
            if (node == null)
            {
                node = root;
            }
            if (node.info == data)
            {
                return data;
            }            
            if (data <= node.info)
            {
                Console.WriteLine("left");
                return search(data, node.left);
            }
            else
            {
                Console.WriteLine("right");
                return search(data, node.right);
            }
        }

    }
}
