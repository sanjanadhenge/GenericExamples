using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class FindMaximum<T> where T : IComparable
    {
        T a, b, c,d;
        public FindMaximum(T a, T b, T c,T d)
        {
           this.a = a;
           this.b = b;
           this.c = c;
           this.d = d;

        }

        public void FindMax()
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0 && a.CompareTo(d) > 0 || a.CompareTo(b) >= 0 && a.CompareTo(c) > 0  && a.CompareTo(d) > 0 || a.CompareTo(b) > 0 && a.CompareTo(c) >= 0 &&  a.CompareTo(d) > 0|| a.CompareTo(b) > 0 && a.CompareTo(c) > 0 && a.CompareTo(d) >= 0)
            {
                Console.WriteLine("{0} is Maximum", a);
            }
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0 && b.CompareTo(d) > 0 || b.CompareTo(a) >= 0 && b.CompareTo(c) > 0 && b.CompareTo(d) > 0 || b.CompareTo(a) > 0 && b.CompareTo(c) >= 0 && b.CompareTo(d) > 0 || b.CompareTo(a) > 0 && b.CompareTo(c) > 0 && b.CompareTo(d) >= 0)
            {
                Console.WriteLine("{0} is Maximum", b);
            }
            if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0 && c.CompareTo(d) > 0 || c.CompareTo(a) >= 0 && c.CompareTo(b) > 0 && c.CompareTo(d) > 0 || c.CompareTo(a) > 0 && c.CompareTo(b) >= 0 && c.CompareTo(d) > 0 || c.CompareTo(a) > 0 && c.CompareTo(b) > 0 && c.CompareTo(d) >= 0)
            {
                Console.WriteLine("{0} is Maximum", c);
            }
            if (d.CompareTo(a) > 0 && d.CompareTo(b) > 0 && d.CompareTo(c) > 0 || d.CompareTo(a) >= 0 && d.CompareTo(b) > 0 && d.CompareTo(c) > 0 || d.CompareTo(a) > 0 && d.CompareTo(b) >= 0 && d.CompareTo(c) > 0 || d.CompareTo(a) > 0 && d.CompareTo(b) > 0 && d.CompareTo(c) >= 0)
            {
                Console.WriteLine("{0} is Maximum", d);
            }
        }
       public void FindMaxInt()
        {
            Console.WriteLine("Enter 1st Number");
            int a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd Number");
            int c = Convert.ToInt32(Console.ReadLine());
            if(a.CompareTo(b) >0 && a.CompareTo(c)>0 || a.CompareTo(b) >= 0 && a.CompareTo(c) > 0|| a.CompareTo(b) > 0 && a.CompareTo(c) >= 0)
            {
                Console.WriteLine("{0} is Maximum",a);
            }
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0 || b.CompareTo(a) >= 0 && b.CompareTo(c) > 0 || b.CompareTo(a) > 0 && b.CompareTo(c) >= 0)
            {
                Console.WriteLine("{0} is Maximum", b);
            }
            if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0 || c.CompareTo(a) >= 0 && c.CompareTo(b) > 0 || c.CompareTo(a) > 0 && c.CompareTo(b) >= 0)
            {
                Console.WriteLine("{0} is Maximum", c);
            }


        }
        public void FindMaxString()
        {
            Console.WriteLine("Enter 1st string");
            string a =Console.ReadLine();
            Console.WriteLine("Enter 2nd string");
            string b = Console.ReadLine();
            Console.WriteLine("Enter 3rd string");
            string c = Console.ReadLine();
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0 || a.CompareTo(b) >= 0 && a.CompareTo(c) > 0 || a.CompareTo(b) > 0 && a.CompareTo(c) >= 0)
            {
                Console.WriteLine("{0} is Maximum", a);
            }
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0 || b.CompareTo(a) >= 0 && b.CompareTo(c) > 0 || b.CompareTo(a) > 0 && b.CompareTo(c) >= 0)
            {
                Console.WriteLine("{0} is Maximum", b);
            }
            if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0 || c.CompareTo(a) >= 0 && c.CompareTo(b) > 0 || c.CompareTo(a) > 0 && c.CompareTo(b) >= 0)
            {
                Console.WriteLine("{0} is Maximum", c);
            }
        }
        public void FindMaxFloat()
        {
            Console.WriteLine("Enter 1st Number");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 3rd Number");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0 || a.CompareTo(b) >= 0 && a.CompareTo(c) > 0 || a.CompareTo(b) > 0 && a.CompareTo(c) >= 0)
            {
                Console.WriteLine("{0} is Maximum", a);
            }
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0 || b.CompareTo(a) >= 0 && b.CompareTo(c) > 0 || b.CompareTo(a) > 0 && b.CompareTo(c) >= 0)
            {
                Console.WriteLine("{0} is Maximum", b);
            }
            if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0 || c.CompareTo(a) >= 0 && c.CompareTo(b) > 0 || c.CompareTo(a) > 0 && c.CompareTo(b) >= 0)
            {
                Console.WriteLine("{0} is Maximum", c);
            }
        }
    }
}
