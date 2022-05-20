using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpPro
{
    internal class Mock
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = arr[i] + arr[i + 1];
                Console.WriteLine(sum);
            }
        }
    }
    class Abc
    {
        static void Main(string[] args)
        {
            string s1 = new string("dhiraj");
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                Console.Write(s1[i]);
            }
        }
    }
}
