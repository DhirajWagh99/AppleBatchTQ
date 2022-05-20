using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ExpPro
{
    internal class Excp1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Sat");
            al.Add("Sun");
            al.Add("Mon");
            
            for (int i = 0; i < al.Count; i++)
            {
                for (int j = i + 1; j < al.Count; j++)
                {
                    
                    if (al[i] == al[j])
                    {
                        al.RemoveAt(j);
                        j--;
                    }

                }

            }
            for (int i = 0; i < al.Count; i++)
            {
                Console.WriteLine(al[i]);
            }

        }

    }


    class Excp2
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Sun");
            al.Add("Mon");
            al.Add("Tue");
            al.Add("Wed");
            al.Add("Thu");
            al.Add("Fri");
            al.Add("Sat");


            al.Sort();
            foreach (var i in al)
                Console.WriteLine(i);
        }
    }
    class Encryption
    {
        static void Main(string[] args)
        {
            string arr = "THE SKY IS THE LIMIT";
            string[] arr2 = arr.Split();

            int[] aa = new int[arr2.Length];
            for (int i = 0; i < arr2.Length; i++)
            {
                
                char[] ch = arr2[i].ToCharArray();
                int sum = 0;
                for (int j = 0; j < arr2[i].Length; j++)
                {

                    if (ch[j] >= 65 && ch[j] <= 90)
                    {
                        sum = sum + (ch[j] - 64);

                    }

                }
                Console.WriteLine(arr2[i] + " sum " + sum);
                aa[i] = sum;

            }
            
            for (int j = 0; j < aa.Length; j++)
            {
                for (int k = j + 1; k < aa.Length; k++)
                {
                    if (aa[j] > aa[k])
                    {
                        string temp1 = arr2[j];
                        arr2[j] = arr2[k];
                        arr2[k] = temp1;

                        int temp = aa[j];
                        aa[j] = aa[k];
                        aa[k] = temp;
                    }
                }
            }
            for (int j = 0; j < aa.Length; j++)
            {
                Console.WriteLine(arr2[j] + "  " + aa[j]);
            }  
        }
    }

   // 4.	Create ArrayList of T20 Players.

    //Create a class Player (playerid, Name, Country, team)
    //e.g.   (1,”MSDhoni”,”India”,”Chennai Super Kings”)
    //Then find out which team has maximum Australian players.
    public class Player20
    {

        int playerid;
        string playername, country, team;

        public Player20(int playerid, string playername, string country, string team)
        {
            this.Playerid = playerid;
            this.Playername = playername;
            this.Country = country;
            this.Team = team;
        }

        public int Playerid { get => playerid; set => playerid = value; }
        public string Playername { get => playername; set => playername = value; }
        public string Country { get => country; set => country = value; }
        public string Team { get => team; set => team = value; }
        public override string ToString()
        {
            return "pid=" + Playerid + " " + "player name=" + Playername + " " + "country=" + Country + " " + "Team=" + Team;
        }
    }
    class IPL20
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add(new Player(1, "Dhoni", "India", "CSK"));
            a1.Add(new Player(1, "Glenn", "AUS", "RCB"));
            a1.Add(new Player(1, "Virat", "India", "RCB"));
            a1.Add(new Player(1, "ABD", "AUS", "RCB"));
            a1.Add(new Player(1, "Aron", "AUS", "CSK"));
            a1.Add(new Player(1, "Surya", "India", "GT"));
            a1.Add(new Player(1, "FAB", "AUS", "Csk"));
            a1.Add(new Player(1, "Mahindra", "India", "Csk"));

            string max_teamname = " ";
            int maxcount = 0;
            foreach (Player p in a1)
            {
                string t = p.Team;
                int c = 0;
                foreach (Player p1 in a1)
                {
                    if (p1.Team == t && p1.Country == "AUS")
                        c++;
                }
                if (maxcount > c)
                    max_teamname = p.Team;
                maxcount = c;
            }
            Console.WriteLine($"Maximum Australian player in {max_teamname}={maxcount} ");
        }


    }



    //  5.	Write a program to get the value of a specified key in a HashTable
    //and also update the value for given key.

    class HashtB
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add('a', "Apple");
            ht.Add('b', "BadaApple");
            ht.Add('c', "ChotaApple");
            ht.Add('d', "DoubleApple");


            foreach (var AA in ht.Keys)
            {
                Console.WriteLine("keys  :" + AA + " Value :" + ht[AA]);
            }
            ht['d'] = "DogApple";
            Console.WriteLine("Updated Value");

            foreach (DictionaryEntry BB in ht)
            {
                Console.WriteLine(BB.Key + ";;" + BB.Value + ";;");
            }


        }
    }


    //6.	Write a program to get a set of keys contained in HashTable and print whole HashTable using for each loop.

    class HashTab
    {
        static void Main(string[] args)
        {
            
            
                Hashtable ht = new Hashtable();
                ht.Add("1", "One");
                ht.Add("2", "Two");
                ht.Add("3", "Three");
                ht.Add("4", "Four");
                ht.Add("5", "Five");
                ht.Add("6", "Six");
                ht.Add("7", "Seven");
                ht.Add("8", "Eight");
                ht.Add("9", "Nine");
                ht.Add("10", "Ten");
                foreach (DictionaryEntry d in ht)
                {
                    Console.WriteLine(d.Key + ":" + d.Value);

                }

                Console.ReadLine();
            
        }
    }




    //7.	Create a HashTable where key is integers 1 to 10 and string is number in Words.
    //Remove entry for which number is divisible by 3.

    class HashtabEven
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "One");
            ht.Add(2, "Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            ht.Add(5, "Five");
            ht.Add(6, "Six");
            ht.Add(7, "Seven");
            ht.Add(8, "Eight");
            ht.Add(9, "Nine");

            foreach (dynamic n in ht.Keys)
            {
                if (n % 3 == 0)
                {
                    Console.WriteLine(" " + n + " " + ht[n]);
                }

            }
            Console.WriteLine(  "////////////////////");
            foreach (object a in ht.Keys)
            {
                int data = (int)a;
                if (data % 2 == 0)
                {
                    Console.WriteLine(data + " " + ht[data]);
                }
            }
            Console.WriteLine("////////////////////");
            foreach (DictionaryEntry e in ht)
            {
                int data = (int)e.Key;
                if (data >= 6)
                {
                    Console.WriteLine(e.Key + " " + e.Value);
                }
            }

        }
    }

        /*8.	ArrayList Contains
    al.Add("pune");
    al.Add("Mumbai");
    al.Add("pune");
    al.Add("Mumbai");
    al.Add("Nasik");
    al.Add("pune");
    Create a HashTable which contain String as key and Integer as value key is name of city and value is frequency of that city.
    ("pune",3);

    ("Mumbai",2);
    Print hashtable using Foreach loop.*/


    class Pune
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("Nasik");
            al.Add("pune");
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("Nasik");

            Hashtable ht = new Hashtable();

            foreach (dynamic k in al)
            {
                if (ht.ContainsKey(k))
                {
                    int oldvalue = ht[k];
                    ht[k] = oldvalue + 1;

                }
                else
                {
                    ht.Add(k, 1);
                }
            }
            foreach (dynamic h in ht.Keys)
            {
                Console.WriteLine(h + " " + ht[h]);
            }



        }
    }

}


