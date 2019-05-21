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
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(50);
            tree.Add(25);
            tree.Add(75);
            tree.Add(12);
            tree.Add(95);
            tree.Add(20);
            tree.Add(80);

            Console.WriteLine(tree.search(80));
            Console.ReadLine();
        }
    }
}
