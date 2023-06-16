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
            // FindMaximum findMaximum = new FindMaximum();
            //findMaximum.FindMaxInt();
            //findMaximum.FindMaxFloat();
            //findMaximum.FindMaxString();
            //findMaximum.FindMax<int>(50, 100, 90);
            //findMaximum.FindMax<double>(15.2f, 19.8f, 99.9f);
            //findMaximum.FindMax<string>("Peach", "Apple","Banana");
            FindMaximum<int> findMaximum1 = new FindMaximum<int>(10, 1000, 100);
            findMaximum1.FindMax();
            FindMaximum<double> findMaximum2 = new FindMaximum<double>(15.9f, 12.2f,5.25f);
            findMaximum2.FindMax();
            FindMaximum<string> findMaximum3 = new FindMaximum<string>("Peach", "Apple", "Banana");
            findMaximum3.FindMax();
        }
    }
}
       
