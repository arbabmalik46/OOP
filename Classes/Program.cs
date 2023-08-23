using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    class Employee
    {
        public int empID;
        public string empname;
        public int empAge;
        public string empContactNo;
    }
    class PermanentEmployee : Employee
    {
        public int permanentEmployeeSalary;
        public int permanentEmployeeWorkingHours;
    }
    class VisitingEmployee : Employee
    {
        public int visitingEmployeeSalary;
        public int visitingEmployeeWorkingHours;
    }
    class Program
    {
        static void Main(string[] args)
        {
            VisitingEmployee Asad = new VisitingEmployee();
            Asad.empname = "Asad";
            Asad.empAge = 23;
            Asad.empContactNo = "030011112223";
            Asad.empID = 7070;
            Asad.visitingEmployeeSalary = 670000;
            Asad.visitingEmployeeWorkingHours = 162;

            
        }
    }
}
