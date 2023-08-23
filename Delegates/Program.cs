using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate void Calculation(int a, int b);
        public delegate void Calculation2(int a, int b);
        public delegate void Calculation3(int a, int b);
        public static void addition(int a, int b) {
            Console.WriteLine("Number are: " + (a+b));
        }
        public static void subtraction(int a, int b)
        {
            Console.WriteLine("Number are: " + (a - b));
        }
        public static void division(int a, int b)
        {
            Console.WriteLine("Number are: " + (a / b));
        }
        public static void multiplication(int a, int b)
        {
            Console.WriteLine("Number are: " + (a * b));
        }
        static void Main(string[] args)
        {
            //Single Cast Delegate
            Calculation c = new Calculation(Program.addition);
            c.Invoke(2,3);
            //Multiple Delegate
            Calculation2 c2 = new Calculation2(Program.subtraction);
            c2.Invoke(13, 3);
            Calculation3 c3 = new Calculation3(Program.multiplication);
            c3.Invoke(2, 3);
            // Multi Cast Delegate
            c += subtraction;
            c += multiplication;
            c(15, 6);
            
            

        }
    }
}
