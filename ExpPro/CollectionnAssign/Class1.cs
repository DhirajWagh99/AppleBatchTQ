using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpPro.CollectionnAssign
{
    // Collection test 2 
    internal class Class1
    {
        //1.	WAP to sort the elements of List that contains String objects. Print List.

        static void Main(string[] args)
        {
            List<String> s = new List<String>();
            s.Add(new String("C Language"));
            s.Add(new String("C #"));
            s.Add(new String("C++"));
            s.Add(new String("Python"));
            s.Add(new String("Java"));
            s.Add(new String("Ruby"));

            foreach (object s2 in s)
            {
                Console.WriteLine(s2);
            }
            Console.WriteLine("///////////////////////////");
            s.Sort();
            foreach (object s3 in s)
            {
                Console.WriteLine(s3);
            }

        }
    }
    class String : IComparable<String>
    {
        string lang_name;
        String()
        { }


        public String(string lang_name)
        {
            this.Lang_name = lang_name;
        }
        public string Lang_name { get => lang_name; set => lang_name = value; }

        public int CompareTo(String other)
        { return this.Lang_name.CompareTo(other.Lang_name); }

        public override string ToString()
        {
            return base.ToString();
        }


    }

    //2.	WAP to create a class Employee with (name, designation ,salary).Now create and add Employee objects elements to List. Print List.
    class Employe
    {
        static void Main(string[] args)
        {

        }
    }
    // WAP to create a Queue with some colors(String) using generics.
    class Que3
    {
        static void Main(string[] args)
        {
            Queue<string> colors = new Queue<string>();
            colors.Enqueue("RED");
            colors.Enqueue("BLUE");
            colors.Enqueue("GREEN");
            colors.Enqueue("YELLOW");
            colors.Enqueue("BLACK");
            foreach (object color in colors)
            {
                Console.WriteLine(color);
            }
            Console.ReadLine();
        }

    }
    class que4
    /*WAP to add user defined objects of type Employee in a HashSet employee object. Make sure if I create 2
    different objects with same data the other one should not be added as hashset stores unique objects.*/
    {
        static void Main(string[] args)
        {


        }


    }
    // 5.	WAP to create SortedList where key is of Integer type and value string and print all key-value pairs.
    class Quee5
    {
        static void Main(string[] args)
        {
            SortedList<int, string> st = new SortedList<int, string>();
            st.Add(5, "FIVE");
            st.Add(1, "ONE");
            st.Add(4, "FOUR");
            st.Add(3, "THREE");
            st.Add(2, "TWO");
            st.Add(7, "SEVEN");
            foreach (var q in st)
            {
                Console.WriteLine(q.Key + " " + q.Value);
            }
            Console.ReadLine();
        }
    }
    /*7.	Make use of such collection that stores moviename such that last entered movie is first
    deleted and accordingly previous one.*/
    class Quee7

    {
        //we have to use stack
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();
            st.Push("RRR");
            st.Push("Kashmir Files");
            st.Push("KGF");
            st.Push("DR Strange");
            foreach (string s in st)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("//////////////////////////");
            st.Pop();
            foreach (string s in st)
            {
                Console.WriteLine(s);
            }

        }
    }
    //6.	WAP to create Dictionary where key is of string type and value of float type and print all key-value pairs.
    class Quee6
    {
        static void Main(string[] args)
        {
            Dictionary<string,float> dd=new Dictionary<string,float>();
            dd.Add("RRR", 9.5f);
            dd.Add("Kashmir Files", 8.9f);
            dd.Add("KGF", 10.10f);
            dd.Add("DR Strange", 6.4f);
            dd.Add("Pushpa", 8.5f);
            foreach (var rating in dd)
            {
                Console.WriteLine(rating.Key+""+rating.Value);
            }
            
        }
    }


}

