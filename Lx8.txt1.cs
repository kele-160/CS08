using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<float> kset = new LinkedList<float>();
            kset.AddFirst(12.3f);
            kset.AddFirst(42.5f);
            kset.AddLast(9f);
            kset.AddLast(7.2f);
            kset.AddAfter(kset.Find(12.3f), 8.6f);
            var node1 = kset.Find(12.3f);
            var node2 = node1.Next;
            kset.Remove(node2);
            kset.AddBefore
                (node1, node2.Value);
            foreach (float n in kset)
                Console.WriteLine(n);
        }
    }
}
