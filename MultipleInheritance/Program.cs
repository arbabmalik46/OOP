using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    //class A{}
    //class B{}
    //class C{}
    //class D : A,B,C{} --it will throw an error because in C#, we cannot have multiple inheritance without interfaces
    interface IInterface1
    {

    }
    interface IInterface2
    {

    }
    class C
    {

    }
    class D
    {

    }
    class A :C, IInterface1, IInterface2
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
