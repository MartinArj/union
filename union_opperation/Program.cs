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
        public static int union()
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[m] ;
            int[] b = new int[n] ;
            a = get(m);
            b = get(n);
            int count = 0;
            int j = 0;
            for (int i = 0; i < a.Length + b.Length; i++)
            {
               

                for (
                    j = 0; j < a.Length + b.Length; j++)
                {
                    if (i < a.Length)
                    {
                        if (a[i] == a[j])
                            break;
                    }
                    if (i >= a.Length)
                    {
                        if (j < a.Length && a[j] == b[i - a.Length])
                            break;
                        if (j >= a.Length && b[i - a.Length] == b[j - a.Length])
                            break;
                    }

                }
                if (i == j)
                    count++;


            }
            return count;

        }
    }
}
