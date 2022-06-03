using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpPro
{
    internal class RockPaper
    {


        static void Main(string[] args)

        {

            string userInput,input, systemInput;

            int randomNum;
            int count1 = 0,count2=0;

            for (int i = 1; i <= 5; i++)
            {

                Console.Write("Give an input from Rock/ Paper/ Scissor ");

               input = Console.ReadLine();
                userInput = input.ToLower();
                Random rnd = new Random();

                randomNum = rnd.Next(1, 4);




                switch (randomNum)

                {

                    case 1:

                        systemInput = "Rock";

                        Console.WriteLine("Computer chose Rock");

                        if (userInput == "Rock")

                        {

                            Console.WriteLine("It is a draw");

                        }
                        else if (userInput == "Paper")

                        {

                            Console.WriteLine("You Loose");
                            count2++;

                        }

                        else

                        {

                            Console.WriteLine("YOu win");
                            count1++;
                        }

                        break;

                    case 2:

                        systemInput = "Paper";

                        Console.WriteLine("Computer chose Paper");

                        if (userInput == "Rock")

                        {

                            Console.WriteLine("You Loose");
                            count2++;
                        }

                        else if (userInput == "Paper")

                        {

                            Console.WriteLine("It is a draw");

                        }

                        else

                        {

                            Console.WriteLine("You win");
                            count1++;
                        }

                        break;

                    case 3:

                        systemInput = "Scissor";

                        Console.WriteLine("Computer chose Scissor");

                        if (userInput == "Rock")

                        {

                            Console.WriteLine("You Win");
                            count1++;
                        }

                        else if (userInput == "Paper")

                        {

                            Console.WriteLine("You Loose");
                            count2++;
                        }

                        else

                        {

                            Console.WriteLine("It is a draw");

                        }

                        break;

                    default:

                        Console.WriteLine("invalid entry!");

                        break;

                }

        
            
            }

            Console.WriteLine("Score"+count1);
            Console.WriteLine("computer score"+count2);
            Console.WriteLine(" final result is");
            if (count2>count1)
            {
                Console.WriteLine("computer wins");
            }
            else { Console.WriteLine("You win"); }
        }

        
    }
}
