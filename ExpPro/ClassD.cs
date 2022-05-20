using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ExpPro
{
    internal class ClassD
    {
        static void Main(string[] args)
        {
            Stack st=new Stack();
            st.Push(10);
            st.Push(20);
            st.Push(30);
             
            dynamic data=st.Pop();
            Console.WriteLine(data);

            while (st.Count!=0)
                Console.WriteLine(st.Pop());

            foreach (dynamic d in st)


                Console.WriteLine(d);

        }

    }
}
