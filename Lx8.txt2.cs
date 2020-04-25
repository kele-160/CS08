using System;
using System.Collections.Concurrent;
namespace Lx8.txt2
{
    class Program
    {
        class Dorder<T> : IComparer<T> where T :IComparable
        {
            public int Cmopare(T m, T n) =>
                m-n;

                n.CompareTo(n);
        }
        static void Main(string[] args)
        {
            SortedSet<long> orderl =
                
                new SortedSet<long> { 15, 8, 45, 6 };
                foreach (long i in orderl) Console.WriteLine(i);
            SortedSet<string> order2 = 


            new SortedSet<string> { "jsp", "asp", "php" };
            foreach (string i in order2) Console.WriteLine(i);
            SortedSet<DateTime> order3 =
                
                new SortedSet<DateTime>
                { new DateTime(2012,5,6),new DateTime(2011,5,6),new DateTime(2013,5,6),};
            foreach (DateTime i in order3) 
                Console.WriteLine(i);
        }
    }
}
