using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Example
    {
        public static bool Check<T>(T a, T b)
        {
            bool c = a.Equals(b);
            Console.WriteLine(c);
            return c;
        }

        
        //public static void showArray<S>(S[] a)
        //{
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        Console.WriteLine(a[i]);
        //    }
        //}
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Example.Check(2,3);
            Example.Check("Ali","Ali");
            //int[] a = {1,2,3,4,5,6};
            //Example.showArray(a);
            //string[] b = { "Ali", "Atif", "Ammar" };
            //Example.showArray(b);
            
        }
    }
}
