using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpPro
{
    internal class LinkedlistinC
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(90);
            list.AddLast(10);
            list.AddLast(20);
            list.AddLast(30);
            foreach(int i in list)
                Console.WriteLine(  i);

        }
    }
}
