using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterface
{
    interface I1
    {
        void show();
    }
    interface I2
    {
        void show();
    }
    abstract class ABC : I2
    {
        public abstract void show();

        public abstract void showData();
    }

    class DEF : ABC
    {
        public override void show()
        {
            throw new NotImplementedException();
        }

        public override void showData()
        {
            throw new NotImplementedException();
        }
    }
    class MyClass : I1, I2
    {
        void I1.show()
        {
            Console.WriteLine("Interface 1");
        }
        void I2.show()
        {
            Console.WriteLine("Interface 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass c = new MyClass();
            ((I1)c).show(); //explicit implementation of interface 
            
        }
    }
}
