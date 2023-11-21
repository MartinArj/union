using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace union_opperation
{
    class Program
    {
        static void Main(string[] args)
        { 
        
        }
        public static int[] get(int n)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
         
    }
}
