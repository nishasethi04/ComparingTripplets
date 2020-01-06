using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            List<int> b = new List<int>();
            a.Add(20);
            a.Add(30);
            a.Add(30);
            b.Add(25);
            b.Add(20);
            b.Add(24);
            List<int> c = new List<int>();
            c.Add(0);
            c.Add(0);

            //Console.WriteLine("Valoue at c[0]={0}",c[0]);
            //Console.WriteLine("Valoue at c[1]={0}", c[1]);

            for (int i=0;i<a.Count;i++)
            {
                if (a[i] > b[i])
                {
                    c[0] = c[0] + 1;
                }
                else if (b[i] > a[i])
                {
                    c[1] = c[1] + 1;
                }
                else
                {
                    continue;
                }
            }
            for(int i=0;i<2;i++)
            {
                Console.WriteLine(c[i]);
                

            }

        }
        public class compare
        {
           

        }
    }
}
