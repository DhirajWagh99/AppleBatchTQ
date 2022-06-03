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
                //sum = arr[i] + arr[i + 1];
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


    class Dhiraj
    {
        


            static void Main(string[] args)
            {


                string str = "Dhiraj Ramesh Wagh";
                string[] s = str.Split(" ");
                string word = " ";
                for (int i = 0; i < s.Length; i++)
                {
                    string s1 = s[i];
                    string str1 = "";
                    for (int j = 0; j < s1.Length; j++)
                    {
                        str1 = s1[j] + str1;

                    }
                    word = word + str1 + " ";
                }
                Console.WriteLine(word);

            }


        

    }
    class Aaaa
    {
        static void Main(string[] args)
        {
            string st = "Dhiraj Wagh";
            string[] st2 = st.Split();
            for (int i = 0;i<=st2.Length; i++) 
            {
                string word = st2[i];
                //Console.WriteLine(  st2[i]);
                for (int j=word.Length-1;j>=0; j--)
                {
                    Console.Write(word[j]+"");
                }
            }

        }
    }
    enum  Role
    {
          Admin,Developer,Tester
    }

    class Emp
    {
        string name;
        Role role;

        public string Name { get => name; set => name = value; }
        internal Role Role { get => role; set => role = value; }

        public override string ToString()
        {
            return $"Name:{name} TRole:{role}";
        }
        static void Main(string[] args)
        {
            Emp e = new Emp();
            Console.WriteLine(" Enter Name");
            string nm = Console.ReadLine();
            Console.WriteLine("Enter role from following list");
            foreach (var d in Enum.GetNames<Role>())
                Console.WriteLine(d);
            Console.WriteLine("enter your choice");
            string choice = Console.ReadLine();
            e.Name = nm;
            e.Role = Enum.Parse<Role>(choice);
            Console.WriteLine(e);

        }
    
    
    }

    class Threadd
    {
        static void m1()
        {
            Console.WriteLine("in m1");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("in m1..."+i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("m1 end ");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("main start");
            Thread t1=new Thread(m1);
            t1.Start();
            //t1.Join();
            for(int i = 0; i < 10; i=i+1)
            {
                Console.WriteLine("main "+i);
            }

        }
    }
     class Departname
     {
        string? empName;
        int dept_id;
        string dept_name;

       
        public string? EmpName { get => empName; set => empName = value; }
        public int Dept_id { get => dept_id; set => dept_id = value; }
        public string Dept_name { get => dept_name; set => dept_name = value; }


        public void accept()
        {
            Console.WriteLine("enter empname,dept id,dept name");
            empName=Console.ReadLine();
            dept_id=int.Parse(Console.ReadLine());
            dept_name=Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine($"employe name = {empName} dept id ={dept_id} dept name={dept_name}");
        }
     }
    class Company
    {
        static void Main(string[] args)
        {
            Departname D1 = new Departname();
            D1.accept();
            D1.display();
        }
    }

    class Prac
    {
        /*Input Array : [10, 0, -1, 20, 25, 30]
          Required Sum: 45
       Output: [20, 25]

           Required Sum: 59
Output: [10, -1, 20, 30]

Required Sum: 60
Output: [10, 20, 30]  */
        static void Main(string[] args)
        {
            //string[] arr = { "vaibhav", "dhiraj", "suraj", "akash" };
            //foreach(string s in arr)
            //Console.WriteLine(s);

        }
    }
    public class Product

    {
        public int Prod_id { get; set; }
        public string Name { get; set; }
        public int Prize { get; set; }
    }
    class Merchant
    {
        static void Main(string[] args)
        {
           Product[] prodList=new Product[]
            { 
            new Product { Prod_id = 1, Name ="pen",Prize=10},
            new Product { Prod_id = 2, Name ="pencil",Prize=5},
            new Product { Prod_id = 3, Name ="book",Prize=50},
            };
            foreach ( Product p in prodList)
            {
                Console.WriteLine($"{p.Prod_id}   {p.Name}  {p.Prize}");
            }
        }
    }
    class Aray2D
    {
        static void Main(string[] args)
        {
            int[,] array2D = new int[2,3] { { 1, 2,3 }, {  4,5,6 } };
            for (int i = 0; i <array2D.GetLength(0); i++)
            {
                for (int j = 0; j < array2D.GetLength(1); j++)
                {


                    Console.Write(array2D[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
    class Jagged
    {
        static void Main(string[] args)
        {
            int[][] jaggedarray = new int[][]
            {
                new int[]{1,2,3},
                new int[]{4,5,6,6},
                new int[]{5,6,8},
                new int[]{6,7},

            };
            for (int i = 0; i < jaggedarray[i].GetLength(0); i++)
            {
                for(int j = 0; j < jaggedarray[j].Length; j++)
                {
                    Console.Write(jaggedarray[i][j]+" ");
                }
            }
        }
    }
    class City
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> d= new Dictionary<int, string>();
            d.Add(1, "pune");
            d.Add(2, "nashik");
            d.Add(3, "mumbai");
            foreach (dynamic a in d)
            {
                Console.WriteLine(a.Key+" "+a.Value);
            }
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        StrManupulation str = new StrManupulation();
    //        MyDel obj1 = new MyDel(str.Lowercase);
    //        obj1 += new MyDel(str.Uppercase);
    //        Delegate[] list = obj1.GetInvocationList();
    //        foreach (Delegate a in list)
    //        {
    //            Console.WriteLine(a.Method);
    //            a.DynamicInvoke("pune");
    //        }
    //    }
    //}
    public delegate void Mydel();
    public class Student
    {
        public event Mydel Fail;
        public event Mydel Distinction;
        public void AcceptMark(int Marks)
        {
            if (Marks<40)
            {
                Fail();
            }
            else if (Marks>=75)
            {
                Distinction();
            }
            Console.WriteLine($"Your score is {Marks}");
        }
    }
    class Program
    {
        static void Failmsg()
        {
            Console.WriteLine("you are fail!!!!!");
        }
        static void DistinctionMsg()
        {
            Console.WriteLine("Congratulation ! you are pass with Distinction");
        }
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Fail += new Mydel(Failmsg);
            s1.Distinction+=new Mydel(DistinctionMsg);
            s1.AcceptMark(34);
        }
    }
   
    
    
    
    
    
    public delegate void Mydel1();
    class Bank
    {
        

        public event Mydel1 InsufficientBal;
        public event Mydel1 ZeroBal;
        int balance;
        public Bank()
        {
            balance = 900000;
        }
        public void credit(int i)
        {
            balance = balance + i;
        }
        public void debit(int i)
        {
            if (balance < i)
            {
                InsufficientBal();
            }
            if(balance >=i)
            {
                 balance -= i;
                if(balance == 0)
                {
                    ZeroBal();
                }
            }
        }
        
    }
    class Atm1
    {
        static void InsufficientBalMsg()
        {
            Console.WriteLine("your balance is low!!!!!");
        }
        static void ZeroBalMsg()
        {
            Console.WriteLine("Your Balance is zero");
        }
        static void Main(string[] args)
        {
            Bank b = new Bank();
            b.InsufficientBal += new Mydel1(InsufficientBalMsg);
            b.ZeroBal += new Mydel1(ZeroBalMsg);
            b.credit(60000);
        }
    }
}
