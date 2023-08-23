using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IEmployee
    {
        void showData();
        int Ass { get; set; }
    }

    class A : IEmployee
    {
        private int _ass;
        public int Ass { get {
                return this._ass;
            } set {
                this._ass = value;
            } }

        public void showData()
        {
            Console.WriteLine("This is a method of IEmployee " + Ass);
        }
    }

    interface I 
    {
        void showData();
    }
    interface G
    {
        void showData1();
    }
    interface H : I , G
    {
        void showData2();
    }
    class Program : H
    {
        static void Main(string[] args)
        {
            A e = new A();
            e.Ass = 23;
            e.showData();
            H a = new Program();
            //Program a = new Program();
            a.showData();
            a.showData1();
            a.showData2();
        }

        public void showData()
        {
            Console.WriteLine("Interface 1");
        }

        public void showData1()
        {
            Console.WriteLine("Interface 2");
        }

        public void showData2()
        {
            Console.WriteLine("Interface 3");
        }
    }
}
