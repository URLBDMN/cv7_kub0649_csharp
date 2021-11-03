using ClassLib;
using System;

namespace cv7_kub0649
{
    class Program
    {
        static int Main(string[] args)
        {
            Node<int, string> root = new Node<int, string>(0, "Root");
            TreeMap<int, string> myTree = new TreeMap<int, string>(root);

            myTree[1] = "A";
            myTree[8] = "C";
            myTree[5] = "B";
            myTree[10] = "D";
            myTree[9] = "E";
            myTree[12] = "F";
            myTree[15] = "G";
            myTree[11] = "H";
            myTree[19] = "I";
            myTree[17] = "J";

            //var c = myTree.ToArray();

            //Console.Write("Vsetky: ");
            //for (int i = 0; i < c.Length; i++)
            //{
            //    Console.Write(c[i].Value + " ");
            //}

            //myTree.PrintTree(root);


            //Console.WriteLine("Value pre deletion: " + myTree[17]);
            //myTree.DeleteValueONKey(17);
            //Console.WriteLine("Value post deletion: " + myTree[17]);


            return 0;
        }
    }
}
