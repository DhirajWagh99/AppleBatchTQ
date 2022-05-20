using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpPro
{
    internal class Stringsop
    {
        static void Main(string[] args)
        {
            string s1 = new string("Dhiraj");
            string s2 = new string("Dhiraj");
            string s11 = s1.ToLower();
            string rev = "";
            for(int i=s11.Length-1; i>=0; i--)
            {
                rev=rev+s11[i];
            }
            if (rev == s11)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("not palindrome");
            Console.WriteLine("//////////////////");
            int v=0;    
            for (int i=0;i<s11.Length;i++)
            {
                if (s11[i] == 'a' || s11[i] == 'e' || s11[i] == 'i' || s11[i] == 'o' || s11[i] == 'u')

                {
                    Console.WriteLine("vowel found"  +  s11[i]);
                    v++;
                }
            }
            Console.WriteLine(v);
            Console.WriteLine("//////////Reverse////////");
            for(int i=s11.Length-1; i>=0; i--)
            {
                Console.WriteLine(s11[i]);
            }

        }
    }
    class table
    {
        static void Main(string[] args)
        {
            int n;
            int r;
            int c = 0;
            n= int.Parse(Console.ReadLine());
            for (int i=0;i<n;i++)
            {
                 r = n % 10;
                n = n / 10;
                Console.Write(r);
               // c++;
                
            }
           // Console.WriteLine();
        }
    }
}
