﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpPro
{
    internal class ArrayPrac
    {
        static void Main(string[] args)
        {
            //Find duplicate word in string 
            //india is my country india is best
            // india is 


            string s = Console.ReadLine();
            string s1=s.ToLower();
            string []s2=s1.Split(' ');
            int count;
            for (int i = 0; i < s2.Length; i++)
            {
                count = 1;
                for(int j=i+1; j <s2.Length; j++)
                {
                    if (s2[i].Equals(s2[j]))
                    {
                        count++;
                        s2[j] = "0";

                    }

                }
                if (count >1 && s2[i]!="0")
                    Console.WriteLine(s2[i]);
            }



        }
    }
    class PrimeArrayy
    {
        static void Main(string[] args)
        {
            int i, j, p,s=0;
            int[] arr = new int[5];

            
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            for (i = 0; i < arr.Length; i++)
            {
                j = 2;
                p = 1;
                while (j < arr[i])
                {
                    if (arr[i] % j == 0)
                    {
                        p = 0;
                        break;
                    }
                    j++;
                }

                if (p == 1)
                {
                    s = s + arr[i];
                }

        
            }
            Console.WriteLine(s);
        }
       

    }
    class arrprint
    //Write a program in C# Sharp to store elements in an array and print it.
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("element {0} :",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("elements in array are");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(arr[i]);
            }
        }
    }
    class arrrevv
    // Write a program in C# Sharp to read n number of values in an array and display it in reverse order.
    {
        static void Main(string[] args)
        {
            int []arr=new int[100];
            Console.WriteLine("input the number of array to be store in ");
            int i;
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input{0}number of elements in array", n);

            for ( i = 0; i < n; i++)
            {
                Console.Write("element {0} ",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(" Elements in array are");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0} ",arr[i]);
            }
            Console.WriteLine("value store in array in reverse are");
                for (i=n-1;i>=0;i--)
                {
                   Console.Write("{0}",arr[i]);
                }
        }
    }
    class arrsum
    // Write a program in C# Sharp to find the sum of all elements of the array.
    {
        static void Main(string[] args)
        {
            int [] arr=new int[100];
            int i;
            int sum = 0;
            Console.WriteLine("enter a number of array to be store in array");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("element{0} in array",n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element {0}    ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write(" Elements in array are");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0} ", arr[i]);
            }
            for (i=0;i<n;i++)
            {
                sum=sum+arr[i];
            }
            Console.WriteLine("sum of element in array are  {0}   ",sum);
        }
    }
   class CopyArr
    // Write a program in C# Sharp to copy the elements one array into another array.
    {
        static void Main(string[] args)
        {
            int [] arr=new int[100];
            int [] arr1=new int[100];
            int i, n;

            Console.WriteLine("enter a number of array to be stored in array");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("element{0} in array ",n);

            for (i = 0; i < n; i++)
            {
                Console.Write("element {0} ",i);
               
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("elements in array are");
            for(i = 0; i < n; i++)
            {
                Console.WriteLine("{0}",arr[i]);
            }
            for (i=0; i < n; i++)
            {
                arr1[i]=arr[i];
                
            }
            for (i=0; i < n; i++)
            {
                Console.Write(" copy array is {0}",arr1[i]);
            }
        }
    }
    class Asc
    //Write a program in C# Sharp to sort elements of array in ascending order.
    {
        static void Main(string[] args)
        {
            int i,n,temp,j;
            int [] arr=new int[100];
            Console.WriteLine("enter size of array");
            n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("elements {0} in array ",n);
            for (i = 0; i < n; i++)
            {
                Console.Write("elements{0} ",i);
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("elements in array are ");
            for( i=0; i < n; i++)
            {
                Console.Write("{0}",arr[i]);
            }

            for(i=0; i < n; i++)
            {
                for (j = i + 1; j < n; j++) 
                {
                    if(arr[i] > arr[j])
                    {
                        temp=arr[i];
                        arr[i]=arr[j];
                        arr[j]=temp;
                    }
                }
            }
            Console.WriteLine("Array in ascending order is");
            for(i=0; i < n; i++)
            {
                Console.Write("{0}",arr[i]," ");
            }

        }
    }

    class Dupli
// total number of duplicate elements in array.
    {
        static void Main(string[] args)
        {
            int []arr1=new int[100];
            int []arr2=new int[100];
            int []arr3=new int[100];
            int i,j,k=1,l=0;
            Console.WriteLine("Enter total number of elements to be store in array ");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input {0} element in array",n);
            for(i=0;i<n;i++)
            {
                Console.WriteLine("elements {0}",i);
                arr1[i]=Convert.ToInt32(Console.ReadLine());

            }
            for(i=0;i < n;i++)
            {
                arr2[i] = arr1[i];
                arr3[i] = 0;
            }
            for (i=0;i<n;i++)
            {
                for (j=0;j<n;j++)
                {
                    if (arr1[i]== arr2[j])
                    {
                        arr3[i] = k;
                        k++;
                    }
                }
                k = 1;
            }
            for (i = 0;i < n; i++) { 
                if (arr3[i] == 2) { l++; }
            }
            Console.WriteLine("the number of duplicate elements are {0}  ",l);
        }
    }

   
}