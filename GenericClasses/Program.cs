using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class Example<T>
    {
        T box;
        public T Box { get { return this.box; } set { this.box = value; } }

        //public Example(T a)
        //{
        //    this.box = a;
        //}
        //public  T getBox()
        //{
        //    Console.WriteLine(this.box); 
        //    return this.box;
        //}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example<int> aa = new Example<int>();
            Example<string> bb = new Example<string>();
            aa.Box = 22 ;
            bb.Box = "HIADS" ;
            Console.WriteLine(aa.Box);
            Console.WriteLine(bb.Box);
        }
    }
}
