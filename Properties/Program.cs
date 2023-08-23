using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{

    class Student
    {
        private int _age;

        public int Age
        {
            set
            {
                this._age = value;
            }
            get
            {
                return this._age;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student();
            a.Age = 20;

            Console.WriteLine(a.Age);
            Console.ReadLine();
        }
    }
}
