using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class School
    {
        public static int schoolID;
        public static string schoolName;
        public int classID;
        public string className;

        public School(int ID, string Name) //parameterized constructor -> will be called upon parameters identification
        {
            this.classID = ID;
            this.className = Name;
            Console.WriteLine(ID+Name);
        }

        public School() //default constructor -> will be called automatically
        {
            this.classID = 1122;
            this.className = "7A";
        }

        static School() //static constructor-> will be called before object creation
        {
            schoolID = 3473;
            schoolName = "Sadiq Memorial High School";
            Console.WriteLine("School ID: {0}, School Name: {1}",schoolID,schoolName);
        }
    }

    public class FIA
    {
        public int ID;
        public string Name;

        public FIA(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

        public string getName()
        {
            return Name;
        }
        public int getID()
        {
            return ID;
        }
        ~FIA()
        {

        }
    }


    static class KIA //static class can not initiated
    {
        public static int carID;
        public static string carModel;
        static KIA() //static class can have static constructor to initiate static variables
        {
            carID = 23;
            carModel = "Sportage";
        }

        public static void getDetails()
        {
            Console.WriteLine("CarID: {0}",carID);
            Console.WriteLine("Car Name: {0}",carModel);


    }

    }

    /*class Honda : KIA //Static Class can not be inherited
    {

    } */
        
    class Shooter
    {
        public string name;
        public int age;
        public static int number;

        public static int getNumber()
        {
            return number;
        }

        public Shooter(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
        //private constrcutor -> it is used to make it a private constructor so that no class can inherit it
        private Shooter() //it is mostly used if a class has only static members/methods and you don't want to allow to make an object of class
        {

        }

    }

    public class Netsol
    {
        public int employyeID;
        public string employeeName;
        public Netsol(int empID, string empName)
        {
            this.employeeName = empName;
            this.employyeID = empID;
        }
        public void getDetails()
        {
            Console.WriteLine("Name is {0}", employeeName);
            Console.WriteLine("ID is {0}",employyeID);
        }


        public Netsol(Netsol n)//Copy Constructor
        {
            this.employyeID = n.employyeID;
            this.employeeName = n.employeeName;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* School school = new School();
             Console.WriteLine(school.className + school.classID);
             School sh1 = new School(3344,"KPS");*/
            //Netsol netsol = new Netsol(7070,"Rabab Munawar");
            //netsol.getDetails();
            //Netsol ns1 = new Netsol(netsol);
            //ns1.getDetails();

            //Shooter shooter = new Shooter(); //got error because it has a private constructor
            Shooter.number = 23;
            Console.WriteLine(Shooter.getNumber());
            

            KIA.getDetails();

            FIA fia = new FIA(23,"Hamza");
            Console.WriteLine("Hi my name is {0} and My ID is {1}",fia.getName(),fia.getID());

        }
    }
}
