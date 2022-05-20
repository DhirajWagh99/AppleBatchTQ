using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpPro
{
    internal class Dlegats1
    {
        public static void factorial(int n)
        {
            int fact = 1;
            for (int i = 0; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial   "  + fact);
        }
        public delegate void delegats2(int n);

        static void Main(string[] args)
        {
            delegats2 f = factorial;
            f(7);
            
        }

    }
    class D1
    {
        public  void add(int a, int b)
        {
            Console.WriteLine("sum "+(a+b));
        }
        public void multi(int a, int b)
        {
            Console.WriteLine("multi " + (a * b));
        }
        public void division(int a, int b)
        {
            Console.WriteLine("divide " + (a / b));
        }
        public delegate void de2(int a,int b);  
        static void Main(string[] args)
        {
            D1 d1 = new D1();
            de2 dd = d1.add;
            dd += d1.multi;
            dd += d1.division;
            dd(4, 7);

        }

    }
    class Add1
    {
        // static int Add(int a,int b)
        //{ return a + b; }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Func<int, int, int> fc;
            fc = Add;
            Console.WriteLine(fc(100,101));

            Func<int, int, int> Addition = (n1, n2) => n1 + n2;
            Console.WriteLine(Addition(30,5));

            Action<int> Del = delegate (int i)
            {
                Console.WriteLine(i);
            };

            Del(45);

        }
    }
}
