using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
   class Student
    {
        string name;
        int age;

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.setName("Atif");
            Console.WriteLine(s1.getName());
            Console.ReadLine();
        }

        
    }
}
