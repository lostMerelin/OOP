using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class TreeNode
    {
        public int Value { get; set; }
        public List<TreeNode> Children { get; set; }

        public TreeNode(int value)
        {
            Value = value;
            Children = new List<TreeNode>();
        }

        public void PrintChildren()
        {
            Console.WriteLine("Children of node with value " + Value + ":");
            foreach (var child in Children)
            {
                Console.WriteLine(child.Value);
                child.PrintChildrenRecursively();
           
            }
        }

        private void PrintChildrenRecursively()
        {
            foreach (var child in Children)
            {
                Console.WriteLine(child.Value);
                child.PrintChildrenRecursively();
            }
        }
    }
}
