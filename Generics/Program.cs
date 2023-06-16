using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            FindMaximum findMaximum = new FindMaximum();
            //findMaximum.FindMaxInt();
            //findMaximum.FindMaxFloat();
            //findMaximum.FindMaxString();
            findMaximum.FindMax<int>(50, 100, 90);
            findMaximum.FindMax<double>(15.2f, 19.8f, 99.9f);
            findMaximum.FindMax<string>("Peach", "Apple","Banana");

        }
    }
}
       
