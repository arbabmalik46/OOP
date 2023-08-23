using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphism
{
    sealed class MainClass //sealed class cannot be inherited
    {
        
    }
    
    //class ChildClass : MainClass //it is throwing error    
    //{

    //}
    class School
    {
        public virtual void getSchoolName()
        {
            Console.WriteLine("Parent");
        }
    }
    class Class : School
    {
        //<summary>
        //This is a overriden method class
        //</summary>
        public void Show()
        {
            Console.WriteLine("Show");
        }
        public override void getSchoolName()
        {
            Console.WriteLine("Child");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            School School = new Class();
            School.getSchoolName();
            Class c = new Class();
            c.Show();
            MainClass sc = new MainClass();
            
        }
    }
}
