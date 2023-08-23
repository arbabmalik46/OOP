using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousFunction
{
    public delegate void MyDelegate(int a);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate c = delegate (int num)
            {
                num += 10;
                Console.WriteLine(num);
            };
            c.Invoke(10);
        }
    }
}
