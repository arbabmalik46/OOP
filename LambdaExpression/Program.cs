using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public delegate void myDelegate(int num);
    class Program
    {
        static void Main(string[] args)
        {
            myDelegate c = (a)=> {
                a += 10;
                Console.WriteLine(a);
            };
            c.Invoke(20);
        }
    }
}
