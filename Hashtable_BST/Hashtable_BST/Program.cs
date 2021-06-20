using System;

namespace Hashtable_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to hashtable");
            MyMapNode<string, string> get = new MyMapNode<string, string>(5);
            get.Add("0", "To");
            get.Add("1", "Be");
            get.Add("2", "Or");
            get.Add("3", "Not");
            get.Add("4", "To");
            get.Add("5", "Be");
            Console.WriteLine(get.GetV("5"));
            Console.WriteLine(get.GetV("3"));
        }
    }
}
