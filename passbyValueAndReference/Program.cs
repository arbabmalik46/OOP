using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passbyValueAndReference
{
    class Program
    {
        static void passByValue(int a)
        {
            a += 10;
            Console.WriteLine("New Value Is: " + a);
        }
        static void passByOut(out int a)
        {
            a = 10;
            Console.WriteLine("New Value Is: " + a);
        }
        static void passByReference(ref int a)
        {
            a += 10;
            Console.WriteLine("New Value is: " + a);
        }
        static void Main(string[] args)
        {
            int val;
            foreach (var item in args)
            {
                Console.WriteLine(item);
            }
            //Console.WriteLine("Original Value:" + val);
            //passByValue(val);
            //passByReference(ref val);
            passByOut(out val);

            Console.WriteLine("New Value: " + val);
            Console.ReadLine();
        }
    }
}
