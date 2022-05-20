using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ExpPro
{
    internal class Collec
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add("Dhi");
            a1.Add("Pune");
            a1.Add(30);
           // Console.WriteLine(a1.Count);
           // Console.WriteLine(a1.Capacity);
            a1.Add("Shivajinagar");
            a1.Add(true);
            a1.Remove("Pune");

          //  a1.Reverse();
            //a1.RemoveAt(0);
            //for(int i = 0; i < a1.Capacity; i++)
            //{
            //    Console.WriteLine(a1[i]);
            //}
        }
    }
}
