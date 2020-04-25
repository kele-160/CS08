using System;
using System.Collections.Generic;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<decimal> Pass(List<decimal> scores)
            {
                foreach (decimal sc in scores)
                {
                    if (sc > 60) yield return sc;
                }
            }
            List<decimal> scSet = new List<decimal> { 80.5m, 56m, 71m, 70.5m, 49m };
            IEnumerable<decimal> passSet = Pass(scSet);
            Console.WriteLine("以下成绩及格");
            foreach (decimal n in passSet)
            {
                Console.WriteLine(n);
            }
        }
    }
}
