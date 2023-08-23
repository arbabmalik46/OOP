using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProperty
{
    abstract class A
    {
        public abstract string Salary { get; set; }
    }

    class B : A
    {
        string _salary;
        public override string Salary {
            get
            {
                return this._salary;
            }
            set
            {
                this._salary = value;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.Salary = "12000";
            Console.WriteLine(b.Salary);
        }
    }
}
