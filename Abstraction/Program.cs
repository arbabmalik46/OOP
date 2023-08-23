using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    //class Employee
    //{
    //    public int EmpID;
    //    public string EmpName;
    //    public double GrossPay;
    //    double TaxDecuction = 0.1;
    //    double NetSalary;
    //    public Employee(int EmpID, string Epmname, double GrossPay)
    //    {
    //        this.EmpID = EmpID;
    //        this.EmpName = Epmname;
    //        this.GrossPay = GrossPay;
    //    }
    //    void SalaryCalculate()
    //    {
    //        if(GrossPay>=30000)
    //        {
    //            NetSalary = GrossPay - (TaxDecuction * GrossPay);
    //            Console.WriteLine("your Pay is {0}", NetSalary);
    //        }
    //        else
    //        {
    //            Console.WriteLine("your Pay is {0}", GrossPay );
    //        }
    //    }
    //    public void ShowDetails()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("Emplyee Name: {0}", this.EmpName );
    //        Console.WriteLine("Emplyee ID: {0}", this.EmpID);
    //        SalaryCalculate();
    //    }
    //}
    abstract class Person
    {
        public int age;
        public string name;
        public string gender;
        

        public abstract void showDetails();

    }
    class Student : Person
    {
        public int rollNo;
        public string classname;

        public override void showDetails()
        {
            Console.WriteLine("Hi I am {0} and my age is {1}. My father name is {2} \n My roll no is {3} and my class Name is {4}", this.name, this.age, this.gender,this.rollNo,this.classname);
        }
    }
    class Teacher : Person
    {
        public string qualification;
        public int salary;
        public override void showDetails()
        {
            Console.WriteLine("Hi I am {0} and my age is {1}.I identify myself as {2} \nMy Qualification is {3} and My Salary is {4}", this.name, this.age, this.gender,this.qualification,this.salary);
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Teacher n = new Teacher();
            n.name = "Arbab";
            n.gender = "Male";
            n.age = 23;
            n.qualification = "MA";
            n.salary = 780000;
            n.showDetails();
            //Employee n = new Employee(12,"Arbab",35000);
            //n.ShowDetails();

            //Person p = new Person(); //Object for an abstract class can not created 
        }
    }
}
