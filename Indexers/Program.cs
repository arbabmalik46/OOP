using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Emplyee
    {
        private int[] Age = new int[3];

        public int this[int index]
        {
            set {
                Age[index] = value;
            }
            get {
                return Age[index];
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
