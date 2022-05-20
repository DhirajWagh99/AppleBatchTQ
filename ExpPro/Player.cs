using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ExpPro
{
    
    
        public class Player
        {
            int playerid;
            string playername, country, team;

            public Player(int playerid, string playername, string country, string team)
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

        }

        class IPL
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
    
}
